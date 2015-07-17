
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Dominio.Dtos;
using PersistenciaDatos;
using System.Data.Objects.DataClasses;

namespace Dominio.Convertidores
{

   
    public static partial class usuarioAssembler
    {
        
        public static usuario ToEntity(this usuarioDTO dto)
        {

            if (dto == null) return null;

            var entity = new usuario();

            if (dto.proyecto == null)
            {

                entity.ID_Usuario = dto.ID_Usuario;
                entity.ID_Departamento = dto.ID_Departamento;
                entity.DNI = dto.DNI;
                entity.password = dto.password;
                entity.nombres = dto.nombres;
                entity.apellidos = dto.apellidos;
                entity.fecha_nacimiento = dto.fecha_nacimiento;
                entity.email = dto.email;
                entity.celular = dto.celular;
                entity.estado = dto.estado;
                // entity.proyecto = detallesEntities;
            }


            if (dto.proyecto != null)
            {
                EntityCollection<proyecto> proyectoEntities = new EntityCollection<proyecto>();

                foreach (var proyectoDTO in dto.proyecto)
                {
                    var proyectoEntity = Convertidores.proyectoAssembler.ToEntity(proyectoDTO);
                    proyectoEntities.Add(proyectoEntity);
                }

                entity.ID_Usuario = dto.ID_Usuario;
                entity.ID_Departamento = dto.ID_Departamento;
                entity.DNI = dto.DNI;
                entity.password = dto.password;
                entity.nombres = dto.nombres;
                entity.apellidos = dto.apellidos;
                entity.fecha_nacimiento = dto.fecha_nacimiento;
                entity.email = dto.email;
                entity.celular = dto.celular;
                entity.estado = dto.estado;
                entity.proyecto = proyectoEntities;

            }

          
            return entity;
     
        }

      
        public static usuarioDTO ToDTO(this usuario entity)
        {
            if (entity == null) return null;

            var dto = new usuarioDTO();

            dto.ID_Usuario = entity.ID_Usuario;
            dto.ID_Departamento = entity.ID_Departamento;
            dto.DNI = entity.DNI;
            dto.password = entity.password;
            dto.nombres = entity.nombres;
            dto.apellidos = entity.apellidos;
            dto.fecha_nacimiento = entity.fecha_nacimiento;
            dto.email = entity.email;
            dto.celular = entity.celular;
            dto.estado = entity.estado;

            dto.proyecto = Dominio.Convertidores.proyectoAssembler.ToDTOs(entity.proyecto);
           //dto.proyecto = proyectoDTO; 

            return dto;
        }

        public static List<usuario> ToEntities(this IEnumerable<usuarioDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

      
        public static List<usuarioDTO> ToDTOs(this IEnumerable<usuario> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
        public static void Actualizar(Dominio.Dtos.usuarioDTO dto, PersistenciaDatos.usuario entity)
        {

            
            
            entity.ID_Usuario = dto.ID_Usuario;
            entity.ID_Departamento = dto.ID_Departamento;
            entity.DNI = dto.DNI;
            entity.password = dto.password;
            entity.nombres = dto.nombres;
            entity.apellidos = dto.apellidos;
            entity.fecha_nacimiento = dto.fecha_nacimiento;
            entity.email = dto.email;
            entity.celular = dto.celular;
            entity.estado = dto.estado;
            // entity.proyecto = proyectoEntities;

            var modelo = new PersistenciaDatos.BDlogisticaEntities();

            foreach (var proyectoDTOX in dto.proyecto)
            {
                if (proyectoDTOX.ID_Proyecto == 0)
                {
                    proyectoDTOX.ID_Usuario = dto.ID_Usuario;
                    modelo.proyecto.Add(Convertidores.proyectoAssembler.ToEntity(proyectoDTOX));
                }

                if (proyectoDTOX.ID_Proyecto != 0)
                {
                    var w = modelo.proyecto.FirstOrDefault(d => d.ID_Proyecto == proyectoDTOX.ID_Proyecto);
                    if (w != null)
                    {
                        Convertidores.proyectoAssembler.Actualizar(proyectoDTOX, w);
                    }
                }

            }


            modelo.SaveChanges();

            

        }
    }
}
