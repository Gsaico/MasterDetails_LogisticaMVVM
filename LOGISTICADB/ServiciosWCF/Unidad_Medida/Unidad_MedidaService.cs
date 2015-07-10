using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class LogisticaDB_ServiceWCF : Unidad_Medida.IUnidad_MedidaService
    {
        LogicaDeNegocios.Unidad_Medida.IUnidad_MedidaLogicaNegocio unidadmedidaLogicaNegocio = new LogicaDeNegocios.LogisticaDB_LogicaNegocio();

        public bool InsertarUnidadMedida(Dominio.Dtos.unidad_medidaDTO dto)
        {
            try
            {
                return unidadmedidaLogicaNegocio.InsertarUnidadMedida(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUnidadMedida(Dominio.Dtos.unidad_medidaDTO dto)
        {
            try
            {
                return unidadmedidaLogicaNegocio.ActualizarUnidadMedida(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUnidadMedida(string idunidadmedida)
        {
            try
            {
                return unidadmedidaLogicaNegocio.EliminarUnidadMedida(idunidadmedida);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.unidad_medidaDTO> ListarUnidadMedidaXnombre(string nombreunidadmedida)
        {
            try
            {
                return unidadmedidaLogicaNegocio.ListarUnidadMedidaXnombre(nombreunidadmedida);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.unidad_medidaDTO> ListarUnidadDeMedidas()
        {
            try
            {
                return unidadmedidaLogicaNegocio.ListarUnidadDeMedidas();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.unidad_medidaDTO BuscarUnidadMedidaPorID(string idunidadmedida)
        {
            try
            {
                return unidadmedidaLogicaNegocio.BuscarUnidadMedidaPorID(idunidadmedida);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}