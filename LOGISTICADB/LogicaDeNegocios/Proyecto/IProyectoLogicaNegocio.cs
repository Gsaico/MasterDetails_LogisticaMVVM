using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Proyecto
{
    public interface IProyectoLogicaNegocio
    {
        int InsertarProyecto(Dominio.Dtos.proyectoDTO dto);
        bool ActualizarProyecto(Dominio.Dtos.proyectoDTO dto);
        bool EliminarProyecto(int idproyecto);
        List<Dominio.Dtos.proyectoDTO> ListarProyectoXnombre(string nombreproyecto);
        List<Dominio.Dtos.proyectoDTO> ListarProyectoXidusuario(int idusuario);
        List<Dominio.Dtos.proyectoDTO> ListarProyectos();
        Dominio.Dtos.proyectoDTO BuscarProyectoPorID(int idproyecto);
    }
}
