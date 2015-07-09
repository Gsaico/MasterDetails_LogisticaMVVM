using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Almacen.IAlmacenQuery
    {

        public int InsertarAlmacen(Dtos.almacenDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.almacen.Add(entity);
                    modelo.SaveChanges();
                    return entity.ID_Almacen;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarAlmacen(Dtos.almacenDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var w = modelo.almacen.Where(q => q.ID_Almacen  == dto.ID_Almacen).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.almacenAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarAlmacen(int IDAlmacen)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.almacen x = modelo.almacen.Where(q => q.ID_Almacen == IDAlmacen).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.almacen.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.almacenDTO> ListarAlmacenXnombre(string nombrealmacen)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.almacen.Where(q => q.nombre_almacen.Contains(nombrealmacen)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.almacenAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.almacenDTO> ListarAlmacenes()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.almacen.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.almacenAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.almacenDTO BuscarAlmacenPorID(int IDAlmacen)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.almacen.Where(q => q.ID_Almacen == IDAlmacen).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.almacenAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
