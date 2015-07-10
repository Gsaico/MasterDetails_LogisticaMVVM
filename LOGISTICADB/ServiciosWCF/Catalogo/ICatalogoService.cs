using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Catalogo
{
    [ServiceContract]
    public interface ICatalogoService
    {
        [OperationContract]
        bool InsertarCatalogo(Dominio.Dtos.catalogoDTO dto);
        [OperationContract]
    bool ActualizarCatalogo(Dominio.Dtos.catalogoDTO dto);
        [OperationContract]
    bool EliminarCatalogo(string IDcatalogo);
        [OperationContract]
    List<Dominio.Dtos.catalogoDTO> ListarCatalogoXnombre(string nombre_bien);
        [OperationContract]                                         
    List<Dominio.Dtos.catalogoDTO> ListarCatalogoXtipobien(string tipobien);
        [OperationContract]
    List<Dominio.Dtos.catalogoDTO> ListarCatalogos();
        [OperationContract]
    Dominio.Dtos.catalogoDTO BuscarCatalogoPorID(string IDcatalogo);  
    }
}
