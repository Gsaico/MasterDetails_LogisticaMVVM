using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
    public partial class Querys : Requerimiento_Detalle.IRequerimiento_DetalleQuery 
    {

        public int InsertarRequerimientoDetalle(Dtos.requerimiento_detalleDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.requerimiento_detalle.Add(entity);
                    modelo.SaveChanges();
                    return entity.ID_RequerimientoDetalle;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarRequerimientoDetalle(Dtos.requerimiento_detalleDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var w = modelo.requerimiento_detalle.Where(q => q.ID_RequerimientoDetalle == dto.ID_RequerimientoDetalle).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.requerimiento_detalleAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarRequerimientoDetalle(int idrequerimientodetalle)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.requerimiento_detalle x = modelo.requerimiento_detalle.Where(q => q.ID_RequerimientoDetalle == idrequerimientodetalle).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.requerimiento_detalle.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalleXID_Requerimiento(int id_requerimiento)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.requerimiento_detalle.Where(q => q.ID_Requerimiento == id_requerimiento).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.requerimiento_detalleAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalles()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.requerimiento_detalle.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.requerimiento_detalleAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.requerimiento_detalleDTO BuscarRequerimientoDetallePorIdrequerimientodetalle(int idrequerimientodetalle)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.requerimiento_detalle.Where(q => q.ID_RequerimientoDetalle == idrequerimientodetalle).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.requerimiento_detalleAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
