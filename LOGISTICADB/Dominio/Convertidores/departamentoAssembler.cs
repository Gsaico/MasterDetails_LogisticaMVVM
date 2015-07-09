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
    /// Assembler for <see cref="departamento"/> and <see cref="departamentoDTO"/>.
    /// </summary>
    public static partial class departamentoAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="departamentoDTO"/> converted from <see cref="departamento"/>.</param>
        static partial void OnDTO(this departamento entity, departamentoDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="departamento"/> converted from <see cref="departamentoDTO"/>.</param>
        static partial void OnEntity(this departamentoDTO dto, departamento entity);

        /// <summary>
        /// Converts this instance of <see cref="departamentoDTO"/> to an instance of <see cref="departamento"/>.
        /// </summary>
        /// <param name="dto"><see cref="departamentoDTO"/> to convert.</param>
        public static departamento ToEntity(this departamentoDTO dto)
        {
            if (dto == null) return null;

            var entity = new departamento();

            entity.ID_Departamento = dto.ID_Departamento;
            entity.nombre_departamento = dto.nombre_departamento;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="departamento"/> to an instance of <see cref="departamentoDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="departamento"/> to convert.</param>
        public static departamentoDTO ToDTO(this departamento entity)
        {
            if (entity == null) return null;

            var dto = new departamentoDTO();

            dto.ID_Departamento = entity.ID_Departamento;
            dto.nombre_departamento = entity.nombre_departamento;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="departamentoDTO"/> to an instance of <see cref="departamento"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<departamento> ToEntities(this IEnumerable<departamentoDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="departamento"/> to an instance of <see cref="departamentoDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<departamentoDTO> ToDTOs(this IEnumerable<departamento> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}