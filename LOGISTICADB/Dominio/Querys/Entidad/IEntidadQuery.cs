using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Entidad
{
    public interface IEntidadQuery
    {
        bool InsertarEntidad(Dtos.entidadDTO  dto);
        bool ActualizarEntidad(Dtos.entidadDTO dto);
        bool EliminarEntidad(string ruc);
        List<Dtos.entidadDTO> ListarEntidadXnombre(string nombreentidad);
        List<Dtos.entidadDTO> ListarEntidades();
        Dtos.entidadDTO BuscarEntidadPorID(string ruc);
    }
}
