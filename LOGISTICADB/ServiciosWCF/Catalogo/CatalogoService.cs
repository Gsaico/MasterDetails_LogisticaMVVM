using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class LogisticaDB_ServiceWCF : Catalogo.ICatalogoService 
    {
        LogicaDeNegocios.Catalogo.ICatalogoLogicaNegocio catalogoLogicaNegocio = new LogicaDeNegocios.LogisticaDB_LogicaNegocio();

        public bool InsertarCatalogo(Dominio.Dtos.catalogoDTO dto)
        {
            try
            {
                return catalogoLogicaNegocio.InsertarCatalogo(dto);
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
                return catalogoLogicaNegocio.ActualizarCatalogo(dto);
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
                return catalogoLogicaNegocio.EliminarCatalogo(IDcatalogo);
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
                return catalogoLogicaNegocio.ListarCatalogoXnombre(nombre_bien);
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
                return catalogoLogicaNegocio.ListarCatalogoXtipobien(tipobien);
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
                return catalogoLogicaNegocio.ListarCatalogos();
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
                return catalogoLogicaNegocio.BuscarCatalogoPorID(IDcatalogo);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}