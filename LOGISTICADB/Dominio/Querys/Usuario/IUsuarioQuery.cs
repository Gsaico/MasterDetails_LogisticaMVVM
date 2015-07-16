using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Usuario
{
    public interface IUsuarioQuery
    {
        int InsertarUsuario(Dtos.usuarioDTO   dto);
        bool ActualizarUsuario(Dtos.usuarioDTO dto);
        bool EliminarUsuario(int idusuario);
        IEnumerable<Dtos.usuarioDTO> ListarUsuarioXnombre(string nombresusuario);
        IEnumerable<Dtos.usuarioDTO> ListarUsuarios();
        Dtos.usuarioDTO BuscarUsuarioPorID(int idusuario);
    }
}
