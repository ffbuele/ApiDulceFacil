using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using DulceFacil.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.ServiciosImpl
{
    public class UsuariosServicioImpl : IUsuariosServicio
    {
        private IUsuariosRepositorio _usuariosRepositorio;
        private readonly DulceFacilDBContext _dbContext;

        public UsuariosServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _dbContext = dulceFacilDBContext;
            _usuariosRepositorio = new UsuariosRepositorioImpl(_dbContext);
        }

        public async Task AddUsuariosAsync(Usuarios usuario)
        {
            await _usuariosRepositorio.AddAsync(usuario);
        }

        public async Task DeleteUsuariosAsync(int id)
        {
            await _usuariosRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<Usuarios>> GetAllUsuariosAsync()
        {
            return await _usuariosRepositorio.GetAllAsync();
        }

        public async Task<Usuarios> GetUsuariosByIdAsync(int id)
        {
            return await _usuariosRepositorio.GetByIdAsync(id);
        }

        public async Task<bool> UpdateUsuariosAsync(UsuarioDTO dto)
        {
            var usuario = await _usuariosRepositorio.GetByIdAsync(dto.IdUsuario);
            if (usuario == null)
                return false;

            usuario.NombreUsuario = dto.NombreUsuario;
            usuario.Email = dto.Email;
            usuario.Password = dto.Password;
            usuario.IdRol = dto.IdRol;
            usuario.Estado = dto.Estado;
            usuario.FechaModificacion = DateTime.UtcNow;

            await _usuariosRepositorio.UpdateAsync(usuario);
            return true;
        }

        public async Task<List<UsuarioDTO>> GetUsuariosRoles()
        {
            return await _usuariosRepositorio.GetUsuariosRoles();
        }

        public async Task<List<UsuarioDTO>> UsuariosPorNombres(string nombres)
        {
            return await _usuariosRepositorio.UsuariosPorNombres(nombres);
        }
    }
}
