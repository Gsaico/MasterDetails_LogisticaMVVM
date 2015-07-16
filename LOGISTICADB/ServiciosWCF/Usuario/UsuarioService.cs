using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class LogisticaDB_ServiceWCF : Usuario.IUsuarioService
    {
        LogicaDeNegocios.Usuario.IUsuarioLogicaNegocio usuarioLogicaNegocio = new LogicaDeNegocios.LogisticaDB_LogicaNegocio();

        public int InsertarUsuario(Dominio.Dtos.usuarioDTO dto)
        {
            try
            {
                return usuarioLogicaNegocio.InsertarUsuario(dto);
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
                return usuarioLogicaNegocio.ActualizarUsuario(dto);
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
                return usuarioLogicaNegocio.EliminarUsuario(idusuario);
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
                return usuarioLogicaNegocio.ListarUsuarioXnombre(nombresusuario);
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
                return usuarioLogicaNegocio.ListarUsuarios();
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
                return usuarioLogicaNegocio.BuscarUsuarioPorID(idusuario);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}