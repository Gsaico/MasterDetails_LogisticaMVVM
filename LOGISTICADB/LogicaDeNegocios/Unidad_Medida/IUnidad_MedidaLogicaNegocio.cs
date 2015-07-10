using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Unidad_Medida
{
    public interface IUnidad_MedidaLogicaNegocio
    {
        bool InsertarUnidadMedida(Dominio.Dtos.unidad_medidaDTO dto);
        bool ActualizarUnidadMedida(Dominio.Dtos.unidad_medidaDTO dto);
        bool EliminarUnidadMedida(string idunidadmedida);
        List<Dominio.Dtos.unidad_medidaDTO> ListarUnidadMedidaXnombre(string nombreunidadmedida);
        List<Dominio.Dtos.unidad_medidaDTO> ListarUnidadDeMedidas();
        Dominio.Dtos.unidad_medidaDTO BuscarUnidadMedidaPorID(string idunidadmedida);
    }
}
