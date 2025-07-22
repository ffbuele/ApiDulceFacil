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
        private readonly DulceFacilDBContext _dbContext;

        public CategoriasClientesServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _dbContext = dulceFacilDBContext;
            _categoriasClientesRepositorio = new CategoriasClientesRepositorioImpl(_dbContext);
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

        public async Task<bool> UpdateCategoriasClientesAsync(CategoriasClientes categoriasClientes)
        {
            var catCliente = await _categoriasClientesRepositorio.GetByIdAsync(categoriasClientes.IdCategoriaCliente);
            if (catCliente == null)
                return false;

            catCliente.Nombre = categoriasClientes.Nombre;
            catCliente.Descripcion = categoriasClientes.Descripcion;
            catCliente.Estado = categoriasClientes.Estado;

            await _categoriasClientesRepositorio.UpdateAsync(catCliente);
            return true;
        }

        public async Task<IEnumerable<CategoriasClientes>> BuscarPorNombres(string nombres)
        {
            return await _categoriasClientesRepositorio.BuscarPorNombres(nombres);
        }
    }
}
