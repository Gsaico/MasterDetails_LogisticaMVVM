using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class LogisticaDB_ServiceWCF : Departamento.IDepartamentoService
    {
        LogicaDeNegocios.Departamento.IDepartamentoLogicaNegocio departamentoLogicaNegocio = new LogicaDeNegocios.LogisticaDB_LogicaNegocio();

        public int InsertarDepartamento(Dominio.Dtos.departamentoDTO dto)
        {
            try
            {
                return departamentoLogicaNegocio.InsertarDepartamento(dto);
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
                return departamentoLogicaNegocio.ActualizarDepartamento(dto);
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
                return departamentoLogicaNegocio.EliminarDepartamento(IDdepartamento);
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
                return departamentoLogicaNegocio.ListarDepartamentoXnombre(nombre_departamento);
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
                return departamentoLogicaNegocio.ListarDepartamentos();
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
                return departamentoLogicaNegocio.BuscarDepartamentoPorID(IDdepartamento);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}