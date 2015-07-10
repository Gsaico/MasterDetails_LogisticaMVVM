using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogisticaDB_LogicaNegocio : Requerimiento.IRequerimientoLogicaNegocio
    {
        Dominio.Querys.Requerimiento.IRequerimientoQuery requerimientoQuerys = new Dominio.Querys.Querys();


        public int InsertarRequerimiento(Dominio.Dtos.requerimientoDTO dto)
        {

            try
            {
                return requerimientoQuerys.InsertarRequerimiento(dto);
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
                return requerimientoQuerys.ActualizarRequerimiento(dto);
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
                return requerimientoQuerys.EliminarRequerimiento(idrequerimiento);
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
                return requerimientoQuerys.ListarRequerimientoXidusuario(idusuario);
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
                return requerimientoQuerys.ListarRequerimientoXidalmacen(idalmacen);
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
                return requerimientoQuerys.ListarRequerimientoXdetallerequerimiento(detallerequerimiento);
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
                return requerimientoQuerys.ListarRequerimientos();
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
                return requerimientoQuerys.BuscarRequerimientoPorID(idrequerimiento);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
