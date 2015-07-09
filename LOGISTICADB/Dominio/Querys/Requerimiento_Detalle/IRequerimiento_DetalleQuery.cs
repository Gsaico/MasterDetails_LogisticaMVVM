using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Requerimiento_Detalle
{
    public interface IRequerimiento_DetalleQuery
    {
        int InsertarRequerimientoDetalle(Dtos.requerimiento_detalleDTO  dto);
        bool ActualizarRequerimientoDetalle(Dtos.requerimiento_detalleDTO dto);
        bool EliminarRequerimientoDetalle(int idrequerimientodetalle);
        List<Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalleXID_Requerimiento(int id_requerimiento);
        List<Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalles();
        Dtos.requerimiento_detalleDTO BuscarRequerimientoDetallePorIdrequerimientodetalle(int idrequerimientodetalle);
    }
}
