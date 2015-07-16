using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogisticaDB_LogicaNegocio : Usuario.IUsuarioLogicaNegocio
    {
        Dominio.Querys.Usuario.IUsuarioQuery usuarioQuerys = new Dominio.Querys.Querys();

        public int InsertarUsuario(Dominio.Dtos.usuarioDTO dto)
        {
            try
            {
                return usuarioQuerys.InsertarUsuario(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsuario(Dominio.Dtos.usuarioDTO dto)
        {
            try
            {
                return usuarioQuerys.ActualizarUsuario(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUsuario(int idusuario)
        {
            try
            {
                return usuarioQuerys.EliminarUsuario(idusuario);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Dominio.Dtos.usuarioDTO> ListarUsuarioXnombre(string nombresusuario)
        {
            try
            {
                return usuarioQuerys.ListarUsuarioXnombre(nombresusuario);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Dominio.Dtos.usuarioDTO> ListarUsuarios()
        {
            try
            {
                return usuarioQuerys.ListarUsuarios();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.usuarioDTO BuscarUsuarioPorID(int idusuario)
        {
            try
            {
                return usuarioQuerys.BuscarUsuarioPorID(idusuario);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
