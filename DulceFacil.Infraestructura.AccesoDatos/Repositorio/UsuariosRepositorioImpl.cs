using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Dominio.Modelos.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class UsuariosRepositorioImpl : RepositorioImpl<Usuarios>, IUsuariosRepositorio
    {
        private readonly DulceFacilDBContext _dbContext;

        public UsuariosRepositorioImpl(DulceFacilDBContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<List<UsuarioDTO>> GetUsuariosRoles()
        {
            try
            {
                var resultado = (from usuarios in _dbContext.Usuarios
                                 join roles in _dbContext.Roles
                                 on usuarios.IdRol equals roles.IdRol
                                 select new UsuarioDTO
                                 {
                                     IdUsuario = usuarios.IdUsuario,
                                     NombreUsuario = usuarios.NombreUsuario,
                                     IdRol = roles.IdRol,
                                     RolNombre = roles.Nombre,  
                                     Email = usuarios.Email,
                                     Password = usuarios.Password,
                                     Estado = usuarios.Estado,
                                 }).ToListAsync();

                return await resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener usuario con roles: {ex.Message}");
            }
        }
        
        public async Task<List<UsuarioDTO>> UsuariosPorNombres(string nombres)
        {
            try
            {
                var resultado = (from usuarios in _dbContext.Usuarios
                                 join roles in _dbContext.Roles
                                 on usuarios.IdRol equals roles.IdRol
                                 where usuarios.NombreUsuario.Contains(nombres)
                                 select new UsuarioDTO
                                 {
                                     IdUsuario = usuarios.IdUsuario,
                                     NombreUsuario = usuarios.NombreUsuario,
                                     IdRol = roles.IdRol,
                                     RolNombre = roles.Nombre,  
                                     Email = usuarios.Email,
                                     Password = usuarios.Password,
                                     Estado = usuarios.Estado,
                                 }).ToListAsync();

                return await resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener usuario por nombres: {ex.Message}");
            }
        }
    }
}
