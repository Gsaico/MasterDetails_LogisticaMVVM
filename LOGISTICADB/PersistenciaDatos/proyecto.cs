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
    
    public partial class proyecto
    {
        public int ID_Proyecto { get; set; }
        public Nullable<int> ID_Usuario { get; set; }
        public string year_ejec { get; set; }
        public string nombre { get; set; }
        public string estado { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}
