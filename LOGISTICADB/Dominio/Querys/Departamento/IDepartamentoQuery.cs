using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Departamento
{
    public interface IDepartamentoQuery
    {
        int InsertarDepartamento(Dtos.departamentoDTO    dto);
        bool ActualizarDepartamento(Dtos.departamentoDTO dto);
        bool EliminarDepartamento(int IDdepartamento);
        List<Dtos.departamentoDTO> ListarDepartamentoXnombre(string nombre_departamento);
        List<Dtos.departamentoDTO> ListarDepartamentos();
        Dtos.departamentoDTO BuscarDepartamentoPorID(int IDdepartamento);
    }
}
