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
    public class RolesServicioImpl : IRolesServicio
    {
        private IRolesRepositorio _rolesRepositorio;
        private readonly DulceFacilDBContext _dbContext;

        public RolesServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _dbContext = dulceFacilDBContext;
            _rolesRepositorio = new RolesRepositorioImpl(_dbContext);
        }

        public async Task AddRolesAsync(Roles rol)
        {
            await _rolesRepositorio.AddAsync(rol);
        }

        public async Task DeleteRolesAsync(int id)
        {
            await _rolesRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<Roles>> GetAllRolesAsync()
        {
            return await _rolesRepositorio.GetAllAsync();
        }

        public async Task<Roles> GetRolesByIdAsync(int id)
        {
            return await _rolesRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateRolesAsync(Roles rol)
        {
            await _rolesRepositorio.UpdateAsync(rol);
        }
    }
}
