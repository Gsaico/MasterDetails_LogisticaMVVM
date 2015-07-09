using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Departamento.IDepartamentoQuery 
    {


        public int InsertarDepartamento(Dtos.departamentoDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.departamento.Add(entity);
                    modelo.SaveChanges();
                    return entity.ID_Departamento;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarDepartamento(Dtos.departamentoDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var w = modelo.departamento.Where(q => q.ID_Departamento == dto.ID_Departamento).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.departamentoAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarDepartamento(int IDdepartamento)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.departamento x = modelo.departamento.Where(q => q.ID_Departamento == IDdepartamento).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.departamento.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.departamentoDTO> ListarDepartamentoXnombre(string nombre_departamento)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.departamento.Where(q => q.nombre_departamento.Contains(nombre_departamento)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.departamentoAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.departamentoDTO> ListarDepartamentos()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.departamento.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.departamentoAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.departamentoDTO BuscarDepartamentoPorID(int IDdepartamento)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.departamento.Where(q => q.ID_Departamento == IDdepartamento).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.departamentoAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
