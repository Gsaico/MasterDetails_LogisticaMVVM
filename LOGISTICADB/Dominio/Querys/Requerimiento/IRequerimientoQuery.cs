using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Requerimiento
{
    public interface IRequerimientoQuery
    {
        int InsertarRequerimiento(Dtos.requerimientoDTO    dto);
        bool ActualizarRequerimiento(Dtos.requerimientoDTO dto);
        bool EliminarRequerimiento(int idrequerimiento);
        List<Dtos.requerimientoDTO> ListarRequerimientoXidusuario(int idusuario);
        List<Dtos.requerimientoDTO> ListarRequerimientoXidalmacen(int idalmacen);
        List<Dtos.requerimientoDTO> ListarRequerimientoXdetallerequerimiento(string detallerequerimiento);
        List<Dtos.requerimientoDTO> ListarRequerimientos();
        Dtos.requerimientoDTO BuscarRequerimientoPorID(int idrequerimiento);
    }
}
