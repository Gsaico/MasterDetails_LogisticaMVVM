//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersistenciaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class almacen
    {
        public almacen()
        {
            this.requerimiento = new HashSet<requerimiento>();
        }
    
        public int ID_Almacen { get; set; }
        public string year { get; set; }
        public string nombre_almacen { get; set; }
        public string direccion { get; set; }
        public string estado { get; set; }
    
        public virtual ICollection<requerimiento> requerimiento { get; set; }
    }
}
