using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Proyecto
{
    public interface IProyectoQuery
    {
        int InsertarProyecto(Dtos.proyectoDTO    dto);
        bool ActualizarProyecto(Dtos.proyectoDTO dto);
        bool EliminarProyecto(int idproyecto);
        bool EliminarProyectosXidUsuario(int idusuario);
        List<Dtos.proyectoDTO> ListarProyectoXnombre(string nombreproyecto);
        List<Dtos.proyectoDTO> ListarProyectoXidusuario(int idusuario);
        List<Dtos.proyectoDTO> ListarProyectos();
        Dtos.proyectoDTO BuscarProyectoPorID(int idproyecto);
    }
}
