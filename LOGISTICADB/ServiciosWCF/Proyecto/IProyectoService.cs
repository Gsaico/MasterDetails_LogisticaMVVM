using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Proyecto
{
    [ServiceContract]
    public interface IProyectoService
    {
        [OperationContract]
        int InsertarProyecto(Dominio.Dtos.proyectoDTO dto);
         [OperationContract]
        bool ActualizarProyecto(Dominio.Dtos.proyectoDTO dto);
         [OperationContract]
        bool EliminarProyecto(int idproyecto);
         [OperationContract]
        List<Dominio.Dtos.proyectoDTO> ListarProyectoXnombre(string nombreproyecto);
         [OperationContract]
        List<Dominio.Dtos.proyectoDTO> ListarProyectoXidusuario(int idusuario);
         [OperationContract]
        List<Dominio.Dtos.proyectoDTO> ListarProyectos();
         [OperationContract]
        Dominio.Dtos.proyectoDTO BuscarProyectoPorID(int idproyecto);
    }
}
