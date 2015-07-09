using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
   public partial class Querys: Catalogo.ICatalogoQuery 
    {

        public bool InsertarCatalogo(Dtos.catalogoDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.catalogo.Add(entity);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarCatalogo(Dtos.catalogoDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var w = modelo.catalogo.Where(q => q.ID_Catalogo == dto.ID_Catalogo).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.catalogoAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarCatalogo(string IDcatalogo)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.catalogo x = modelo.catalogo.Where(q => q.ID_Catalogo == IDcatalogo).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.catalogo.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.catalogoDTO> ListarCatalogoXnombre(string nombre_bien)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.catalogo.Where(q => q.nombre_bien.Contains(nombre_bien)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.catalogoAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.catalogoDTO> ListarCatalogoXtipobien(string tipobien)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.catalogo.Where(q => q.tipo_bien.Contains(tipobien)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.catalogoAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.catalogoDTO> ListarCatalogos()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.catalogo.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.catalogoAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.catalogoDTO BuscarCatalogoPorID(string IDcatalogo)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.catalogo.Where(q => q.ID_Catalogo == IDcatalogo).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.catalogoAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
