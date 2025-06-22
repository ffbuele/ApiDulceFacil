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
    public class ClientesServicioImpl : IClientesServicio
    {
        private IClientesRepositorio _clientesRepositorio;

        public ClientesServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _clientesRepositorio = new ClientesRepositorioImpl(dulceFacilDBContext);
        }

        public async Task AddClientesAsync(Clientes cliente)
        {
            await _clientesRepositorio.AddAsync(cliente);
        }

        public async Task DeleteClientesAsync(int id)
        {
            await _clientesRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<Clientes>> GetAllClientesAsync()
        {
            return await _clientesRepositorio.GetAllAsync();
        }

        public async Task<Clientes> GetClientesByIdAsync(int id)
        {
            return await _clientesRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateClientesAsync(Clientes cliente)
        {
            await _clientesRepositorio.UpdateAsync(cliente);
        }
    }
}
