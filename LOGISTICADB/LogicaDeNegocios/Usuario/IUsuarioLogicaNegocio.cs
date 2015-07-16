using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Usuario
{
    public interface IUsuarioLogicaNegocio
    {
        int InsertarUsuario(Dominio.Dtos.usuarioDTO dto);
        bool ActualizarUsuario(Dominio.Dtos.usuarioDTO dto);
        bool EliminarUsuario(int idusuario);
        IEnumerable<Dominio.Dtos.usuarioDTO> ListarUsuarioXnombre(string nombresusuario);
        IEnumerable<Dominio.Dtos.usuarioDTO> ListarUsuarios();
        Dominio.Dtos.usuarioDTO BuscarUsuarioPorID(int idusuario);
    }
}
