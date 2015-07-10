using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogisticaDB_LogicaNegocio : Requerimiento_Detalle.IRequerimiento_DetalleLogicaNegocio
    {
        Dominio.Querys.Requerimiento_Detalle.IRequerimiento_DetalleQuery  requerimientodetalleQuerys = new Dominio.Querys.Querys();


        public int InsertarRequerimientoDetalle(Dominio.Dtos.requerimiento_detalleDTO dto)
        {

            try
            {
                return requerimientodetalleQuerys.InsertarRequerimientoDetalle(dto);
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
                return requerimientodetalleQuerys.ActualizarRequerimientoDetalle(dto);
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
                return requerimientodetalleQuerys.EliminarRequerimientoDetalle(idrequerimientodetalle);
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
                return requerimientodetalleQuerys.ListarRequerimientoDetalleXID_Requerimiento(id_requerimiento);
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
                return requerimientodetalleQuerys.ListarRequerimientoDetalles();
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
                return requerimientodetalleQuerys.BuscarRequerimientoDetallePorIdrequerimientodetalle(idrequerimientodetalle);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
