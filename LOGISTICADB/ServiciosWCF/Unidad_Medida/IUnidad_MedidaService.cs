using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Unidad_Medida
{
    [ServiceContract]
    public interface IUnidad_MedidaService
    {
        [OperationContract]
        bool InsertarUnidadMedida(Dominio.Dtos.unidad_medidaDTO dto);
        [OperationContract]
        bool ActualizarUnidadMedida(Dominio.Dtos.unidad_medidaDTO dto);
        [OperationContract]
        bool EliminarUnidadMedida(string idunidadmedida);
        [OperationContract]
        List<Dominio.Dtos.unidad_medidaDTO> ListarUnidadMedidaXnombre(string nombreunidadmedida);
        [OperationContract]
        List<Dominio.Dtos.unidad_medidaDTO> ListarUnidadDeMedidas();
        [OperationContract]
        Dominio.Dtos.unidad_medidaDTO BuscarUnidadMedidaPorID(string idunidadmedida);
    }
}
