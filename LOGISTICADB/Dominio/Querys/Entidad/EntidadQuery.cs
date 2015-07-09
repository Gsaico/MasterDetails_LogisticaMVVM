using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
    public partial class Querys : Entidad.IEntidadQuery
    {


        public bool InsertarEntidad(Dtos.entidadDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.entidad.Add(entity);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarEntidad(Dtos.entidadDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var w = modelo.entidad.Where(q => q.Ruc == dto.Ruc).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.entidadAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarEntidad(string ruc)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.entidad x = modelo.entidad.Where(q => q.Ruc == ruc).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.entidad.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.entidadDTO> ListarEntidadXnombre(string nombreentidad)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.entidad.Where(q => q.nombre_entidad.Contains(nombreentidad)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.entidadAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.entidadDTO> ListarEntidades()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.entidad.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.entidadAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.entidadDTO BuscarEntidadPorID(string ruc)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.entidad.Where(q => q.Ruc == ruc).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.entidadAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
