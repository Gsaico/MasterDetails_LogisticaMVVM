using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class LogisticaDB_ServiceWCF : Requerimiento.IRequerimientoService
    {
        LogicaDeNegocios.Requerimiento.IRequerimientoLogicaNegocio requerimientoLogicaNegocio = new LogicaDeNegocios.LogisticaDB_LogicaNegocio();

        public int InsertarRequerimiento(Dominio.Dtos.requerimientoDTO dto)
        {
            try
            {
                return requerimientoLogicaNegocio.InsertarRequerimiento(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarRequerimiento(Dominio.Dtos.requerimientoDTO dto)
        {
            try
            {
                return requerimientoLogicaNegocio.ActualizarRequerimiento(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarRequerimiento(int idrequerimiento)
        {
            try
            {
                return requerimientoLogicaNegocio.EliminarRequerimiento(idrequerimiento);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.requerimientoDTO> ListarRequerimientoXidusuario(int idusuario)
        {
            try
            {
                return requerimientoLogicaNegocio.ListarRequerimientoXidusuario(idusuario);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.requerimientoDTO> ListarRequerimientoXidalmacen(int idalmacen)
        {
            try
            {
                return requerimientoLogicaNegocio.ListarRequerimientoXidalmacen(idalmacen);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.requerimientoDTO> ListarRequerimientoXdetallerequerimiento(string detallerequerimiento)
        {
            try
            {
                return requerimientoLogicaNegocio.ListarRequerimientoXdetallerequerimiento(detallerequerimiento);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.requerimientoDTO> ListarRequerimientos()
        {
            try
            {
                return requerimientoLogicaNegocio.ListarRequerimientos();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.requerimientoDTO BuscarRequerimientoPorID(int idrequerimiento)
        {
            try
            {
                return requerimientoLogicaNegocio.BuscarRequerimientoPorID(idrequerimiento);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}