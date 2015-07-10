using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogisticaDB_LogicaNegocio : Almacen.IAlmacenLogicaNegocio
    {
        Dominio.Querys.Almacen.IAlmacenQuery almacenQuerys = new Dominio.Querys.Querys();


        public int InsertarAlmacen(Dominio.Dtos.almacenDTO dto)
        {
      
            try
            {
                return almacenQuerys.InsertarAlmacen(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
      
        }

        public bool ActualizarAlmacen(Dominio.Dtos.almacenDTO dto)
        {
            try
            {
                return almacenQuerys.ActualizarAlmacen(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarAlmacen(int IDAlmacen)
        {
            try
            {
                return almacenQuerys.EliminarAlmacen(IDAlmacen);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.almacenDTO> ListarAlmacenXnombre(string nombrealmacen)
        {
            try
            {
                return almacenQuerys.ListarAlmacenXnombre(nombrealmacen);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.almacenDTO> ListarAlmacenes()
        {
            try
            {
                return almacenQuerys.ListarAlmacenes();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.almacenDTO BuscarAlmacenPorID(int IDAlmacen)
        {
            try
            {
                return almacenQuerys.BuscarAlmacenPorID(IDAlmacen);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
