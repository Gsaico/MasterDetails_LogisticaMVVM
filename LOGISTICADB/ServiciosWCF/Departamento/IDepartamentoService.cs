using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Departamento
{
    [ServiceContract]
    public interface IDepartamentoService
    {
        [OperationContract]
        int InsertarDepartamento(Dominio.Dtos.departamentoDTO dto);
         [OperationContract]
    bool ActualizarDepartamento(Dominio.Dtos.departamentoDTO dto);
         [OperationContract]
    bool EliminarDepartamento(int IDdepartamento);
         [OperationContract]
    List<Dominio.Dtos.departamentoDTO> ListarDepartamentoXnombre(string nombre_departamento);
         [OperationContract]
    List<Dominio.Dtos.departamentoDTO> ListarDepartamentos();
         [OperationContract]
    Dominio.Dtos.departamentoDTO BuscarDepartamentoPorID(int IDdepartamento);
    }
}
