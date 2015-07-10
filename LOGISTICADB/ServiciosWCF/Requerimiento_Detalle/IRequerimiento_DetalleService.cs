using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Requerimiento_Detalle
{
    [ServiceContract]
    public interface IRequerimiento_DetalleService
    {
        [OperationContract]
        int InsertarRequerimientoDetalle(Dominio.Dtos.requerimiento_detalleDTO dto);
         [OperationContract]
        bool ActualizarRequerimientoDetalle(Dominio.Dtos.requerimiento_detalleDTO dto);
         [OperationContract]
        bool EliminarRequerimientoDetalle(int idrequerimientodetalle);
         [OperationContract]
        List<Dominio.Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalleXID_Requerimiento(int id_requerimiento);
         [OperationContract]
        List<Dominio.Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalles();
         [OperationContract]
        Dominio.Dtos.requerimiento_detalleDTO BuscarRequerimientoDetallePorIdrequerimientodetalle(int idrequerimientodetalle);
    }
}
