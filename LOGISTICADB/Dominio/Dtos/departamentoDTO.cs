//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/07/08 - 22:06:36
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
    public partial class departamentoDTO
    {
        [DataMember()]
        public Int32 ID_Departamento { get; set; }

        [DataMember()]
        public String nombre_departamento { get; set; }

        [DataMember()]
        public List<usuarioDTO> usuario { get; set; }

        public departamentoDTO()
        {
        }

        public departamentoDTO(Int32 iD_Departamento, String nombre_departamento, List<usuarioDTO> usuario)
        {
			this.ID_Departamento = iD_Departamento;
			this.nombre_departamento = nombre_departamento;
			this.usuario = usuario;
        }
    }
}
