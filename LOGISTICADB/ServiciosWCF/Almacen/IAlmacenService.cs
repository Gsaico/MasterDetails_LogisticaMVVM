using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Almacen
{
    [ServiceContract]
    public interface IAlmacenService
    {[OperationContract]
        int InsertarAlmacen(Dominio.Dtos.almacenDTO dto);
        [OperationContract]
    bool ActualizarAlmacen(Dominio.Dtos.almacenDTO dto);
        [OperationContract]
    bool EliminarAlmacen(int IDAlmacen);
        [OperationContract]
    List<Dominio.Dtos.almacenDTO> ListarAlmacenXnombre(string nombrealmacen);
        [OperationContract]
    List<Dominio.Dtos.almacenDTO> ListarAlmacenes();
        [OperationContract]
    Dominio.Dtos.almacenDTO BuscarAlmacenPorID(int IDAlmacen);
    }
}
