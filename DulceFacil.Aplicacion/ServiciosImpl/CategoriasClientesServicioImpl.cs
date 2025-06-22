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
    public class CategoriasClientesServicioImpl : ICategoriasClientesServicio
    {
        private ICategoriasClientesRepositorio _categoriasClientesRepositorio;

        public CategoriasClientesServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _categoriasClientesRepositorio = new CategoriasClientesRepositorioImpl(dulceFacilDBContext);
        }

        public async Task AddCategoriasClientesAsync(CategoriasClientes categoriasClientes)
        {
            await _categoriasClientesRepositorio.AddAsync(categoriasClientes);
        }

        public async Task DeleteCategoriasClientesAsync(int id)
        {
            await _categoriasClientesRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoriasClientes>> GetAllCategoriasClientesAsync()
        {
            return await _categoriasClientesRepositorio.GetAllAsync();
        }

        public async Task<CategoriasClientes> GetCategoriasClientesByIdAsync(int id)
        {
            return await _categoriasClientesRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateCategoriasClientesAsync(CategoriasClientes categoriasClientes)
        {
            await _categoriasClientesRepositorio.UpdateAsync(categoriasClientes);
        }
    }
}
