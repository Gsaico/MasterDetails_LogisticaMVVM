using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Entidad
{
    [ServiceContract]
    public interface IEntidadService
    {
        [OperationContract]
        bool InsertarEntidad(Dominio.Dtos.entidadDTO dto);
           [OperationContract]
    bool ActualizarEntidad(Dominio.Dtos.entidadDTO dto);
           [OperationContract]
    bool EliminarEntidad(string ruc);
           [OperationContract]
    List<Dominio.Dtos.entidadDTO> ListarEntidadXnombre(string nombreentidad);
           [OperationContract]
    List<Dominio.Dtos.entidadDTO> ListarEntidades();
           [OperationContract]
    Dominio.Dtos.entidadDTO BuscarEntidadPorID(string ruc);
    }
}
