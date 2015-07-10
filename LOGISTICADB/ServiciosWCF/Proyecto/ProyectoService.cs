using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class LogisticaDB_ServiceWCF : Proyecto.IProyectoService 
    {
        LogicaDeNegocios.Proyecto.IProyectoLogicaNegocio proyectoLogicaNegocio = new LogicaDeNegocios.LogisticaDB_LogicaNegocio();

        public int InsertarProyecto(Dominio.Dtos.proyectoDTO dto)
        {
            try
            {
                return proyectoLogicaNegocio.InsertarProyecto(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarProyecto(Dominio.Dtos.proyectoDTO dto)
        {
            try
            {
                return proyectoLogicaNegocio.ActualizarProyecto(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarProyecto(int idproyecto)
        {
            try
            {
                return proyectoLogicaNegocio.EliminarProyecto(idproyecto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.proyectoDTO> ListarProyectoXnombre(string nombreproyecto)
        {
            try
            {
                return proyectoLogicaNegocio.ListarProyectoXnombre(nombreproyecto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.proyectoDTO> ListarProyectoXidusuario(int idusuario)
        {
            try
            {
                return proyectoLogicaNegocio.ListarProyectoXidusuario(idusuario);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.proyectoDTO> ListarProyectos()
        {
            try
            {
                return proyectoLogicaNegocio.ListarProyectos();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.proyectoDTO BuscarProyectoPorID(int idproyecto)
        {
            try
            {
                return proyectoLogicaNegocio.BuscarProyectoPorID(idproyecto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}