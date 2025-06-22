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
    public class ProductosServicioImpl : IProductosServicio
    {
        private IProductosRepositorio _productosRepositorio;

        public ProductosServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _productosRepositorio = new ProductosRepositorioImpl(dulceFacilDBContext);
        }

        public async Task AddProductosAsync(Productos producto)
        {
            await _productosRepositorio.AddAsync(producto);
        }

        public async Task DeleteProductosAsync(int id)
        {
            await _productosRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<Productos>> GetAllProductosAsync()
        {
            return await _productosRepositorio.GetAllAsync();
        }

        public async Task<Productos> GetProductosByIdAsync(int id)
        {
            return await _productosRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateProductosAsync(Productos producto)
        {
            await _productosRepositorio.UpdateAsync(producto);
        }
    }
}
