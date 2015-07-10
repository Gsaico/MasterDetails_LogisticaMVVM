using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class LogisticaDB_ServiceWCF : Entidad.IEntidadService
    {
        LogicaDeNegocios.Entidad.IEntidadLogicaNegocio entidadLogicaNegocio = new LogicaDeNegocios.LogisticaDB_LogicaNegocio();

        public bool InsertarEntidad(Dominio.Dtos.entidadDTO dto)
        {
            try
            {
                return entidadLogicaNegocio.InsertarEntidad(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarEntidad(Dominio.Dtos.entidadDTO dto)
        {
            try
            {
                return entidadLogicaNegocio.ActualizarEntidad(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarEntidad(string ruc)
        {
            try
            {
                return entidadLogicaNegocio.EliminarEntidad(ruc);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.entidadDTO> ListarEntidadXnombre(string nombreentidad)
        {
            try
            {
                return entidadLogicaNegocio.ListarEntidadXnombre(nombreentidad);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.entidadDTO> ListarEntidades()
        {
            try
            {
                return entidadLogicaNegocio.ListarEntidades();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.entidadDTO BuscarEntidadPorID(string ruc)
        {
            try
            {
                return entidadLogicaNegocio.BuscarEntidadPorID(ruc);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}