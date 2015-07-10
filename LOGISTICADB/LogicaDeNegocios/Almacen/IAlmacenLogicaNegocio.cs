using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.Almacen
{
    public interface IAlmacenLogicaNegocio
    {
        int InsertarAlmacen(Dominio.Dtos.almacenDTO dto);
        bool ActualizarAlmacen(Dominio.Dtos.almacenDTO dto);
        bool EliminarAlmacen(int IDAlmacen);
        List<Dominio.Dtos.almacenDTO> ListarAlmacenXnombre(string nombrealmacen);
        List<Dominio.Dtos.almacenDTO> ListarAlmacenes();
        Dominio.Dtos.almacenDTO BuscarAlmacenPorID(int IDAlmacen);
    }
}
