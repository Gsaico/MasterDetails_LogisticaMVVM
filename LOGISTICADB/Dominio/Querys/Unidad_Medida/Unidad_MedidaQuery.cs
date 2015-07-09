using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
    public partial class Querys : Unidad_Medida.IUnidad_MedidaQuery 
    {

        public bool InsertarUnidadMedida(Dtos.unidad_medidaDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.unidad_medida.Add(entity);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUnidadMedida(Dtos.unidad_medidaDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var w = modelo.unidad_medida.Where(q => q.ID_UnidadMedida == dto.ID_UnidadMedida).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.unidad_medidaAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUnidadMedida(string idunidadmedida)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.unidad_medida x = modelo.unidad_medida.Where(q => q.ID_UnidadMedida == idunidadmedida).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.unidad_medida.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.unidad_medidaDTO> ListarUnidadMedidaXnombre(string nombreunidadmedida)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.unidad_medida.Where(q => q.nombre.Contains(nombreunidadmedida)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.unidad_medidaAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.unidad_medidaDTO> ListarUnidadDeMedidas()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.unidad_medida.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.unidad_medidaAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.unidad_medidaDTO BuscarUnidadMedidaPorID(string idunidadmedida)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.unidad_medida.Where(q => q.ID_UnidadMedida == idunidadmedida).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.unidad_medidaAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
