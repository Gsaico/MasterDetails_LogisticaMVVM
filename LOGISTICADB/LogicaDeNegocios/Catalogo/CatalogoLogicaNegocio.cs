using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogisticaDB_LogicaNegocio : Catalogo.ICatalogoLogicaNegocio
    {
        Dominio.Querys.Catalogo.ICatalogoQuery  catalogoQuerys = new Dominio.Querys.Querys();


        public bool InsertarCatalogo(Dominio.Dtos.catalogoDTO dto)
        {

            try
            {
                return catalogoQuerys.InsertarCatalogo(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }

        }

        public bool ActualizarCatalogo(Dominio.Dtos.catalogoDTO dto)
        {

            try
            {
                return catalogoQuerys.ActualizarCatalogo(dto);
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
                return catalogoQuerys.EliminarCatalogo(IDcatalogo);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.catalogoDTO> ListarCatalogoXnombre(string nombre_bien)
        {

            try
            {
                return catalogoQuerys.ListarCatalogoXnombre(nombre_bien);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.catalogoDTO> ListarCatalogoXtipobien(string tipobien)
        {

            try
            {
                return catalogoQuerys.ListarCatalogoXtipobien(tipobien);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.catalogoDTO> ListarCatalogos()
        {

            try
            {
                return catalogoQuerys.ListarCatalogos();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.catalogoDTO BuscarCatalogoPorID(string IDcatalogo)
        {

            try
            {
                return catalogoQuerys.BuscarCatalogoPorID(IDcatalogo);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
