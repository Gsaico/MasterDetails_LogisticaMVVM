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
    
    public partial class unidad_medida
    {
        public unidad_medida()
        {
            this.requerimiento_detalle = new HashSet<requerimiento_detalle>();
        }
    
        public string ID_UnidadMedida { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<requerimiento_detalle> requerimiento_detalle { get; set; }
    }
}
