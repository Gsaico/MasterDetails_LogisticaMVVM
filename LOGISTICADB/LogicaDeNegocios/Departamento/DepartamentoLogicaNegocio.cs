using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogisticaDB_LogicaNegocio : Departamento.IDepartamentoLogicaNegocio
    {
        Dominio.Querys.Departamento.IDepartamentoQuery  departamentoQuerys = new Dominio.Querys.Querys();


        public int InsertarDepartamento(Dominio.Dtos.departamentoDTO dto)
        {
         
            try
            {
                return departamentoQuerys.InsertarDepartamento(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
       
        }

        public bool ActualizarDepartamento(Dominio.Dtos.departamentoDTO dto)
        {
            try
            {
                return departamentoQuerys.ActualizarDepartamento(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarDepartamento(int IDdepartamento)
        {
            try
            {
                return departamentoQuerys.EliminarDepartamento(IDdepartamento);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.departamentoDTO> ListarDepartamentoXnombre(string nombre_departamento)
        {
            try
            {
                return departamentoQuerys.ListarDepartamentoXnombre(nombre_departamento);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.departamentoDTO> ListarDepartamentos()
        {
            try
            {
                return departamentoQuerys.ListarDepartamentos();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.departamentoDTO BuscarDepartamentoPorID(int IDdepartamento)
        {
            try
            {
                return departamentoQuerys.BuscarDepartamentoPorID(IDdepartamento);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
