using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Unidad_Medida
{
    public interface IUnidad_MedidaQuery
    {
        bool InsertarUnidadMedida(Dtos.unidad_medidaDTO    dto);
        bool ActualizarUnidadMedida(Dtos.unidad_medidaDTO dto);
        bool EliminarUnidadMedida(string idunidadmedida);
        List<Dtos.unidad_medidaDTO> ListarUnidadMedidaXnombre(string nombreunidadmedida);
        List<Dtos.unidad_medidaDTO> ListarUnidadDeMedidas();
        Dtos.unidad_medidaDTO BuscarUnidadMedidaPorID(string idunidadmedida);
    }
}
