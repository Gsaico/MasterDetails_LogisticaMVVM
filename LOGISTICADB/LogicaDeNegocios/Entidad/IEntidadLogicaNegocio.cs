using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Entidad
{
    public interface IEntidadLogicaNegocio
    {
        bool InsertarEntidad(Dominio.Dtos.entidadDTO dto);
        bool ActualizarEntidad(Dominio.Dtos.entidadDTO dto);
        bool EliminarEntidad(string ruc);
        List<Dominio.Dtos.entidadDTO> ListarEntidadXnombre(string nombreentidad);
        List<Dominio.Dtos.entidadDTO> ListarEntidades();
        Dominio.Dtos.entidadDTO BuscarEntidadPorID(string ruc);
    }
}
