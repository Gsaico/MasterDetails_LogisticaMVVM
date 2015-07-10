using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Departamento
{
    public interface IDepartamentoLogicaNegocio
    {
        int InsertarDepartamento(Dominio.Dtos.departamentoDTO dto);
        bool ActualizarDepartamento(Dominio.Dtos.departamentoDTO dto);
        bool EliminarDepartamento(int IDdepartamento);
        List<Dominio.Dtos.departamentoDTO> ListarDepartamentoXnombre(string nombre_departamento);
        List<Dominio.Dtos.departamentoDTO> ListarDepartamentos();
        Dominio.Dtos.departamentoDTO BuscarDepartamentoPorID(int IDdepartamento);
    }
}
