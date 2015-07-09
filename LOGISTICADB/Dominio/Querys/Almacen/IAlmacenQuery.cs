using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaDatos;

namespace Dominio.Querys.Almacen
{
    public interface IAlmacenQuery
    {
        int InsertarAlmacen(Dtos.almacenDTO    dto);
        bool ActualizarAlmacen(Dtos.almacenDTO dto);
        bool EliminarAlmacen(int IDAlmacen);
        List<Dtos.almacenDTO> ListarAlmacenXnombre(string nombrealmacen);
        List<Dtos.almacenDTO> ListarAlmacenes();
        Dtos.almacenDTO BuscarAlmacenPorID(int IDAlmacen);
    }
}
