using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Requerimiento
{
    public interface IRequerimientoLogicaNegocio
    {
        int InsertarRequerimiento(Dominio.Dtos.requerimientoDTO dto);
        bool ActualizarRequerimiento(Dominio.Dtos.requerimientoDTO dto);
        bool EliminarRequerimiento(int idrequerimiento);
        List<Dominio.Dtos.requerimientoDTO> ListarRequerimientoXidusuario(int idusuario);
        List<Dominio.Dtos.requerimientoDTO> ListarRequerimientoXidalmacen(int idalmacen);
        List<Dominio.Dtos.requerimientoDTO> ListarRequerimientoXdetallerequerimiento(string detallerequerimiento);
        List<Dominio.Dtos.requerimientoDTO> ListarRequerimientos();
        Dominio.Dtos.requerimientoDTO BuscarRequerimientoPorID(int idrequerimiento);

    }
}
