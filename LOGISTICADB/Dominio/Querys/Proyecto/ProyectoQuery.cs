using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
    public partial class Querys : Proyecto.IProyectoQuery
    {
        
        public int InsertarProyecto(Dtos.proyectoDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.proyecto.Add(entity);
                    modelo.SaveChanges();
                    return entity.ID_Proyecto;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarProyecto(Dtos.proyectoDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var w = modelo.proyecto.Where(q => q.ID_Proyecto == dto.ID_Proyecto).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.proyectoAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarProyecto(int idproyecto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.proyecto x = modelo.proyecto.Where(q => q.ID_Proyecto  == idproyecto).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.proyecto.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public bool EliminarProyectosXidUsuario(int idusuario)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.proyecto  x = modelo.proyecto.Where(q => q.ID_Usuario == idusuario).Select(q => q).FirstOrDefault ();
                    if (x == null) return false;
                    modelo.proyecto.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public List<Dtos.proyectoDTO> ListarProyectoXnombre(string nombreproyecto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.proyecto.Where(q => q.nombre.Contains(nombreproyecto)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.proyectoAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.proyectoDTO> ListarProyectoXidusuario(int idusuario)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.proyecto.Where(q => q.ID_Usuario ==idusuario).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.proyectoAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.proyectoDTO> ListarProyectos()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.proyecto.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.proyectoAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.proyectoDTO BuscarProyectoPorID(int idproyecto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.proyecto.Where(q => q.ID_Proyecto == idproyecto).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.proyectoAssembler.ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
