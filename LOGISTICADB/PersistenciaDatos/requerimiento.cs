//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersistenciaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class requerimiento
    {
        public requerimiento()
        {
            this.requerimiento_detalle = new HashSet<requerimiento_detalle>();
        }
    
        public int ID_Requerimiento { get; set; }
        public Nullable<int> ID_Usuario { get; set; }
        public Nullable<int> ID_Almacen { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string detalle_requerimiento { get; set; }
        public string estado { get; set; }
        public string observaciones_requerimiento { get; set; }
    
        public virtual almacen almacen { get; set; }
        public virtual ICollection<requerimiento_detalle> requerimiento_detalle { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
