//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/07/08 - 22:06:41
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
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

    /// <summary>
    /// Assembler for <see cref="usuario"/> and <see cref="usuarioDTO"/>.
    /// </summary>
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
                //
                EntityCollection<proyecto> detallesEntities = new EntityCollection<proyecto>();

                foreach (var detalleDto in dto.proyecto)
                {
                    var detalleEntity = Convertidores.proyectoAssembler.ToEntity(detalleDto);
                    detallesEntities.Add(detalleEntity);
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
                entity.proyecto = detallesEntities;

            }

            return entity;
            
           

        }

        /// <summary>
        /// Converts this instance of <see cref="usuario"/> to an instance of <see cref="usuarioDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="usuario"/> to convert.</param>
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
           //     dto.proyecto = proyectoDTO; 

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="usuarioDTO"/> to an instance of <see cref="usuario"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<usuario> ToEntities(this IEnumerable<usuarioDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="usuario"/> to an instance of <see cref="usuarioDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
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

            var modelo = new PersistenciaDatos.BDlogisticaEntities();
            foreach (var detallenuevo in dto.proyecto.Where(d => d.ID_Proyecto  == 0))
            {
                detallenuevo.ID_Usuario   = dto.ID_Usuario;
                modelo.proyecto.Add(Convertidores.proyectoAssembler.ToEntity(detallenuevo));
            }

            foreach (var detalleactualizar in dto.proyecto.Where(d => d.ID_Proyecto != 0))
            {
                var detalleantiguo = modelo.proyecto.FirstOrDefault(d => d.ID_Proyecto == detalleactualizar.ID_Proyecto);
                if (detalleantiguo != null)
                {
                    Convertidores.proyectoAssembler.Actualizar(detalleactualizar,detalleantiguo);
                }
            }

         
            modelo.SaveChanges();
        }
    }
}
