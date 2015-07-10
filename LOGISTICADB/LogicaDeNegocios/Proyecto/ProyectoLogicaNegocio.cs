using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogisticaDB_LogicaNegocio : Proyecto.IProyectoLogicaNegocio
    {
        Dominio.Querys.Proyecto.IProyectoQuery  proyectoQuerys = new Dominio.Querys.Querys();


        public int InsertarProyecto(Dominio.Dtos.proyectoDTO dto)
        {

            try
            {
                return proyectoQuerys.InsertarProyecto(dto);
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
                return proyectoQuerys.ActualizarProyecto(dto);
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
                return proyectoQuerys.EliminarProyecto(idproyecto);
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
                return proyectoQuerys.ListarProyectoXnombre(nombreproyecto);
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
                return proyectoQuerys.ListarProyectoXidusuario(idusuario);
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
                return proyectoQuerys.ListarProyectos();
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
                return proyectoQuerys.BuscarProyectoPorID(idproyecto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
