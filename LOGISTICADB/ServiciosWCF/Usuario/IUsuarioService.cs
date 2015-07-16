using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Usuario
{
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
    int InsertarUsuario(Dominio.Dtos.usuarioDTO dto);
        [OperationContract]
    bool ActualizarUsuario(Dominio.Dtos.usuarioDTO dto);
        [OperationContract]
    bool EliminarUsuario(int idusuario);
        [OperationContract]
        IEnumerable<Dominio.Dtos.usuarioDTO> ListarUsuarioXnombre(string nombresusuario);
        [OperationContract]
        IEnumerable<Dominio.Dtos.usuarioDTO> ListarUsuarios();

         [OperationContract]
    Dominio.Dtos.usuarioDTO BuscarUsuarioPorID(int idusuario);
    }
}
