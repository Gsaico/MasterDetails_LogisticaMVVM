//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/07/08 - 22:06:37
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Dominio.Dtos
{
    [DataContract()]
    public partial class requerimientoDTO
    {
        [DataMember()]
        public Int32 ID_Requerimiento { get; set; }

        [DataMember()]
        public Nullable<Int32> ID_Usuario { get; set; }

        [DataMember()]
        public Nullable<Int32> ID_Almacen { get; set; }

        [DataMember()]
        public Nullable<DateTime> fecha { get; set; }

        [DataMember()]
        public String detalle_requerimiento { get; set; }

        [DataMember()]
        public String estado { get; set; }

        [DataMember()]
        public String observaciones_requerimiento { get; set; }

        [DataMember()]
        public almacenDTO almacen { get; set; }

        [DataMember()]
        public List<requerimiento_detalleDTO> requerimiento_detalle { get; set; }

        [DataMember()]
        public usuarioDTO usuario { get; set; }

        public requerimientoDTO()
        {
        }

        public requerimientoDTO(Int32 iD_Requerimiento, Nullable<Int32> iD_Usuario, Nullable<Int32> iD_Almacen, Nullable<DateTime> fecha, String detalle_requerimiento, String estado, String observaciones_requerimiento, almacenDTO almacen, List<requerimiento_detalleDTO> requerimiento_detalle, usuarioDTO usuario)
        {
			this.ID_Requerimiento = iD_Requerimiento;
			this.ID_Usuario = iD_Usuario;
			this.ID_Almacen = iD_Almacen;
			this.fecha = fecha;
			this.detalle_requerimiento = detalle_requerimiento;
			this.estado = estado;
			this.observaciones_requerimiento = observaciones_requerimiento;
			this.almacen = almacen;
			this.requerimiento_detalle = requerimiento_detalle;
			this.usuario = usuario;
        }
    }
}
