using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Requerimiento_Detalle
{
    public interface IRequerimiento_DetalleLogicaNegocio
    {
        int InsertarRequerimientoDetalle(Dominio.Dtos.requerimiento_detalleDTO dto);
        bool ActualizarRequerimientoDetalle(Dominio.Dtos.requerimiento_detalleDTO dto);
        bool EliminarRequerimientoDetalle(int idrequerimientodetalle);
        List<Dominio.Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalleXID_Requerimiento(int id_requerimiento);
        List<Dominio.Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalles();
        Dominio.Dtos.requerimiento_detalleDTO BuscarRequerimientoDetallePorIdrequerimientodetalle(int idrequerimientodetalle);
    }
}
