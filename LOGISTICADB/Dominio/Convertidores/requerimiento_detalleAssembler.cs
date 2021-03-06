//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/07/08 - 22:06:40
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Dominio.Dtos;
using PersistenciaDatos;

namespace Dominio.Convertidores
{

    /// <summary>
    /// Assembler for <see cref="requerimiento_detalle"/> and <see cref="requerimiento_detalleDTO"/>.
    /// </summary>
    public static partial class requerimiento_detalleAssembler
    {
       
        public static requerimiento_detalle ToEntity(this requerimiento_detalleDTO dto)
        {
            if (dto == null) return null;

            var entity = new requerimiento_detalle();

            entity.ID_RequerimientoDetalle = dto.ID_RequerimientoDetalle;
            entity.ID_Requerimiento = dto.ID_Requerimiento;
            entity.ID_Catalogo = dto.ID_Catalogo;
            entity.ID_UnidadMedida = dto.ID_UnidadMedida;
            entity.cantidad = dto.cantidad;
            entity.valor_referencial = dto.valor_referencial;

          

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="requerimiento_detalle"/> to an instance of <see cref="requerimiento_detalleDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="requerimiento_detalle"/> to convert.</param>
        public static requerimiento_detalleDTO ToDTO(this requerimiento_detalle entity)
        {
            if (entity == null) return null;

            var dto = new requerimiento_detalleDTO();

            dto.ID_RequerimientoDetalle = entity.ID_RequerimientoDetalle;
            dto.ID_Requerimiento = entity.ID_Requerimiento;
            dto.ID_Catalogo = entity.ID_Catalogo;
            dto.ID_UnidadMedida = entity.ID_UnidadMedida;
            dto.cantidad = entity.cantidad;
            dto.valor_referencial = entity.valor_referencial;

           

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="requerimiento_detalleDTO"/> to an instance of <see cref="requerimiento_detalle"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<requerimiento_detalle> ToEntities(this IEnumerable<requerimiento_detalleDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="requerimiento_detalle"/> to an instance of <see cref="requerimiento_detalleDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<requerimiento_detalleDTO> ToDTOs(this IEnumerable<requerimiento_detalle> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
        public static void Actualizar(Dominio.Dtos.requerimiento_detalleDTO dto, PersistenciaDatos.requerimiento_detalle entity)
        {
            entity.ID_RequerimientoDetalle = dto.ID_RequerimientoDetalle;
            entity.ID_Requerimiento = dto.ID_Requerimiento;
            entity.ID_Catalogo = dto.ID_Catalogo;
            entity.ID_UnidadMedida = dto.ID_UnidadMedida;
            entity.cantidad = dto.cantidad;
            entity.valor_referencial = dto.valor_referencial;

        }
    }
}
