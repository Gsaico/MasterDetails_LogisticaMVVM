using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class LogisticaDB_ServiceWCF : Requerimiento_Detalle.IRequerimiento_DetalleService
    {
        LogicaDeNegocios.Requerimiento_Detalle.IRequerimiento_DetalleLogicaNegocio requerimientodetalleLogicaNegocio = new LogicaDeNegocios.LogisticaDB_LogicaNegocio();

        public int InsertarRequerimientoDetalle(Dominio.Dtos.requerimiento_detalleDTO dto)
        {
            try
            {
                return requerimientodetalleLogicaNegocio.InsertarRequerimientoDetalle(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarRequerimientoDetalle(Dominio.Dtos.requerimiento_detalleDTO dto)
        {
            try
            {
                return requerimientodetalleLogicaNegocio.ActualizarRequerimientoDetalle(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarRequerimientoDetalle(int idrequerimientodetalle)
        {
            try
            {
                return requerimientodetalleLogicaNegocio.EliminarRequerimientoDetalle(idrequerimientodetalle);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalleXID_Requerimiento(int id_requerimiento)
        {
            try
            {
                return requerimientodetalleLogicaNegocio.ListarRequerimientoDetalleXID_Requerimiento(id_requerimiento);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.requerimiento_detalleDTO> ListarRequerimientoDetalles()
        {
            try
            {
                return requerimientodetalleLogicaNegocio.ListarRequerimientoDetalles();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.requerimiento_detalleDTO BuscarRequerimientoDetallePorIdrequerimientodetalle(int idrequerimientodetalle)
        {
            try
            {
                return requerimientodetalleLogicaNegocio.BuscarRequerimientoDetallePorIdrequerimientodetalle(idrequerimientodetalle);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}