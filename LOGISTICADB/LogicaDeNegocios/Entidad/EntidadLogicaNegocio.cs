using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogisticaDB_LogicaNegocio : Entidad.IEntidadLogicaNegocio
    {
        Dominio.Querys.Entidad.IEntidadQuery  entidadQuerys = new Dominio.Querys.Querys();


        public bool InsertarEntidad(Dominio.Dtos.entidadDTO dto)
        {
            
            try
            {
                return entidadQuerys.InsertarEntidad(dto);
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
                return entidadQuerys.ActualizarEntidad(dto);
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
                return entidadQuerys.EliminarEntidad(ruc);
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
                return entidadQuerys.ListarEntidadXnombre(nombreentidad);
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
                return entidadQuerys.ListarEntidades();
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
                return entidadQuerys.BuscarEntidadPorID(ruc);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
