using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Catalogo
{
    public interface ICatalogoQuery
    {
        bool InsertarCatalogo(Dtos.catalogoDTO    dto);
        bool ActualizarCatalogo(Dtos.catalogoDTO dto);
        bool EliminarCatalogo(string IDcatalogo);
        List<Dtos.catalogoDTO> ListarCatalogoXnombre(string nombre_bien);
        List<Dtos.catalogoDTO> ListarCatalogoXtipobien(string tipobien);
        List<Dtos.catalogoDTO> ListarCatalogos();
        Dtos.catalogoDTO BuscarCatalogoPorID(string IDcatalogo);
    }
}
