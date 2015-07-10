using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Requerimiento
{
    [ServiceContract]
    public interface IRequerimientoService
    {
        [OperationContract]
        int InsertarRequerimiento(Dominio.Dtos.requerimientoDTO dto);
          [OperationContract]
        bool ActualizarRequerimiento(Dominio.Dtos.requerimientoDTO dto);
          [OperationContract]
        bool EliminarRequerimiento(int idrequerimiento);
          [OperationContract]
        List<Dominio.Dtos.requerimientoDTO> ListarRequerimientoXidusuario(int idusuario);
          [OperationContract]
        List<Dominio.Dtos.requerimientoDTO> ListarRequerimientoXidalmacen(int idalmacen);
          [OperationContract]
        List<Dominio.Dtos.requerimientoDTO> ListarRequerimientoXdetallerequerimiento(string detallerequerimiento);
          [OperationContract]
        List<Dominio.Dtos.requerimientoDTO> ListarRequerimientos();
          [OperationContract]
        Dominio.Dtos.requerimientoDTO BuscarRequerimientoPorID(int idrequerimiento);
    }
}
