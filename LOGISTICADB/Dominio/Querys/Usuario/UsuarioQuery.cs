using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys
{
    public partial class Querys : Usuario.IUsuarioQuery
    {

        public int InsertarUsuario(Dtos.usuarioDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities ())
                {
                    var entity = dto.ToEntity();
                    modelo.usuario.Add(entity);
                    modelo.SaveChanges();
                    return entity.ID_Usuario;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsuario(Dtos.usuarioDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var w = modelo.usuario.Where(q => q.ID_Usuario == dto.ID_Usuario).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.usuarioAssembler.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUsuario(int idusuario)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    PersistenciaDatos.usuario x = modelo.usuario.Where(q => q.ID_Usuario == idusuario).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.usuario.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.usuarioDTO> ListarUsuarioXnombre(string nombresusuario)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.usuario.Where(q => q.nombres.Contains(nombresusuario)).Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.usuarioAssembler.ToDTOs(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.usuarioDTO> ListarUsuarios()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.usuario.Select(q => q).ToList();

                    if (entity == null) return null;
                    return Dominio.Convertidores.usuarioAssembler.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.usuarioDTO BuscarUsuarioPorID(int idusuario)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.BDlogisticaEntities())
                {
                    var entity = modelo.usuario.Where(q => q.ID_Usuario == idusuario).Select(q => q).FirstOrDefault();

                    if (entity == null) return null;
                    return Dominio.Convertidores.usuarioAssembler .ToDTO(entity);

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }
    }
}
