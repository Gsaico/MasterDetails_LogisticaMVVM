using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Catalogo
{
    public interface ICatalogoLogicaNegocio
    {
        bool InsertarCatalogo(Dominio.Dtos.catalogoDTO dto);
        bool ActualizarCatalogo(Dominio.Dtos.catalogoDTO dto);
        bool EliminarCatalogo(string IDcatalogo);
        List<Dominio.Dtos.catalogoDTO> ListarCatalogoXnombre(string nombre_bien);
        List<Dominio.Dtos.catalogoDTO> ListarCatalogoXtipobien(string tipobien);
        List<Dominio.Dtos.catalogoDTO> ListarCatalogos();
        Dominio.Dtos.catalogoDTO BuscarCatalogoPorID(string IDcatalogo);  
    }
}
