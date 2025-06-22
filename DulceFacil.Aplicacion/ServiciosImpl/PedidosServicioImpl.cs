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
    public class PedidosServicioImpl : IPedidosServicio
    {
        private IPedidosRepositorio _pedidosRepositorio;

        public PedidosServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _pedidosRepositorio = new PedidosRepositorioImpl(dulceFacilDBContext);
        }

        public async Task AddPedidosAsync(Pedidos pedido)
        {
            await _pedidosRepositorio.AddAsync(pedido);
        }

        public async Task DeletePedidosAsync(int id)
        {
            await _pedidosRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<Pedidos>> GetAllPedidosAsync()
        {
            return await _pedidosRepositorio.GetAllAsync();
        }

        public async Task<Pedidos> GetPedidosByIdAsync(int id)
        {
            return await _pedidosRepositorio.GetByIdAsync(id);
        }

        public async Task UpdatePedidosAsync(Pedidos pedido)
        {
            await _pedidosRepositorio.UpdateAsync(pedido);
        }
    }
}
