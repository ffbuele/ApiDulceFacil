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
    public class DetallesPedidosServicioImpl : IDetallesPedidosServicio
    {
        private IDetallerPedidosRepositorio _detallerPedidosRepositorio;

        public DetallesPedidosServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _detallerPedidosRepositorio = new DetallesPedidosRepositorioImpl(dulceFacilDBContext);
        }

        public async Task AddDetallesPedidosAsync(DetallesPedidos detallePedido)
        {
            await _detallerPedidosRepositorio.AddAsync(detallePedido);
        }

        public async Task DeleteDetallesPedidosAsync(int id)
        {
            await _detallerPedidosRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<DetallesPedidos>> GetAllDetallesPedidosAsync()
        {
            return await _detallerPedidosRepositorio.GetAllAsync();
        }

        public async Task<DetallesPedidos> GetDetallesPedidosByIdAsync(int id)
        {
            return await _detallerPedidosRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateDetallesPedidosAsync(DetallesPedidos detallePedido)
        {
            await _detallerPedidosRepositorio.UpdateAsync(detallePedido);
        }
    }
}
