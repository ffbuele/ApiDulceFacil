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
    public class InventariosServicioImpl : IInventariosServicio
    {
        private IInventariosRepositorio _inventariosRepositorio;

        public InventariosServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _inventariosRepositorio = new InventariosRepositorioImpl(dulceFacilDBContext);
        }

        public async Task AddInventariosAsync(Inventarios inventario)
        {
            await _inventariosRepositorio.AddAsync(inventario);
        }

        public async Task DeleteInventariosAsync(int id)
        {
            await _inventariosRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<Inventarios>> GetAllInventariosAsync()
        {
            return await _inventariosRepositorio.GetAllAsync();
        }

        public async Task<Inventarios> GetInventariosByIdAsync(int id)
        {
            return await _inventariosRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateInventariosAsync(Inventarios inventario)
        {
            await _inventariosRepositorio.UpdateAsync(inventario);
        }
    }
}
