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
    public class CategoriasProductosServicioImpl : ICategoriasProductosServicio
    {
        private ICategoriasProductosRepositorio _categoriasProductosRepositorio;

        public CategoriasProductosServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _categoriasProductosRepositorio = new CategoriasProductosRepositorioImpl(dulceFacilDBContext);
        }

        public async Task AddCategoriasProductosAsync(CategoriasProductos categoriaProducto)
        {
            await _categoriasProductosRepositorio.AddAsync(categoriaProducto);
        }

        public async Task DeleteCategoriasProductosAsync(int id)
        {
            await _categoriasProductosRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoriasProductos>> GetAllCategoriasProductosAsync()
        {
            return await _categoriasProductosRepositorio.GetAllAsync();
        }

        public async Task<CategoriasProductos> GetCategoriasProductosByIdAsync(int id)
        {
            return await _categoriasProductosRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateCategoriasProductosAsync(CategoriasProductos categoriaProduct)
        {
            await _categoriasProductosRepositorio.UpdateAsync(categoriaProduct);
        }
    }
}
