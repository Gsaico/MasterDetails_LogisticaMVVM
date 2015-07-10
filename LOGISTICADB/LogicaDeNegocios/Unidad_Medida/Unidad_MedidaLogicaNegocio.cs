using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogisticaDB_LogicaNegocio : Unidad_Medida.IUnidad_MedidaLogicaNegocio
    {
        Dominio.Querys.Unidad_Medida.IUnidad_MedidaQuery  unidadmedidaQuerys = new Dominio.Querys.Querys();


        public bool InsertarUnidadMedida(Dominio.Dtos.unidad_medidaDTO dto)
        {

            try
            {
                return unidadmedidaQuerys.InsertarUnidadMedida(dto);
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
                return unidadmedidaQuerys.ActualizarUnidadMedida(dto);
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
                return unidadmedidaQuerys.EliminarUnidadMedida(idunidadmedida);
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
                return unidadmedidaQuerys.ListarUnidadMedidaXnombre(nombreunidadmedida);
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
                return unidadmedidaQuerys.ListarUnidadDeMedidas();
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
                return unidadmedidaQuerys.BuscarUnidadMedidaPorID(idunidadmedida);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
