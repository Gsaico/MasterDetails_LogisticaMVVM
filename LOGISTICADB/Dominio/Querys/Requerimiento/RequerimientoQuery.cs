using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
    public partial class Querys : Requerimiento.IRequerimientoQuery 
    {


        public int InsertarRequerimiento(Dtos.requerimientoDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.requerimiento.Add(entity);
                    modelo.SaveChanges();
                    return entity.ID_Requerimiento;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarRequerimiento(Dtos.requerimientoDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var w = modelo.requerimiento.Where(q => q.ID_Requerimiento == dto.ID_Requerimiento).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.requerimientoAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarRequerimiento(int idrequerimiento)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.requerimiento x = modelo.requerimiento.Where(q => q.ID_Requerimiento == idrequerimiento).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.requerimiento.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.requerimientoDTO> ListarRequerimientoXidusuario(int idusuario)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.requerimiento.Where(q => q.ID_Usuario == idusuario).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.requerimientoAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.requerimientoDTO> ListarRequerimientoXidalmacen(int idalmacen)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.requerimiento.Where(q => q.ID_Almacen == idalmacen).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.requerimientoAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.requerimientoDTO> ListarRequerimientoXdetallerequerimiento(string detallerequerimiento)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.requerimiento.Where(q => q.detalle_requerimiento.Contains(detallerequerimiento)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.requerimientoAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.requerimientoDTO> ListarRequerimientos()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.requerimiento.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.requerimientoAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.requerimientoDTO BuscarRequerimientoPorID(int idrequerimiento)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.requerimiento.Where(q => q.ID_Requerimiento == idrequerimiento).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.requerimientoAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
