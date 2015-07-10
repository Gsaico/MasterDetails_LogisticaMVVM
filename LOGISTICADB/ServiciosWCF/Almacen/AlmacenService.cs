using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class LogisticaDB_ServiceWCF : Almacen.IAlmacenService 
    {
        LogicaDeNegocios.Almacen.IAlmacenLogicaNegocio almacenLogicaNegocio = new LogicaDeNegocios.LogisticaDB_LogicaNegocio();

        public int InsertarAlmacen(Dominio.Dtos.almacenDTO dto)
        {
            try
            {
                return almacenLogicaNegocio.InsertarAlmacen(dto);
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
                return almacenLogicaNegocio.ActualizarAlmacen(dto);
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
                return almacenLogicaNegocio.EliminarAlmacen(IDAlmacen);
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
                return almacenLogicaNegocio.ListarAlmacenXnombre(nombrealmacen);
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
                return almacenLogicaNegocio.ListarAlmacenes();
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
                return almacenLogicaNegocio.BuscarAlmacenPorID(IDAlmacen);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}