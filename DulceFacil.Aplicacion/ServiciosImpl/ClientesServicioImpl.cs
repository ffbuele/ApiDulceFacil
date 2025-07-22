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
    public class ClientesServicioImpl : IClientesServicio
    {
        private IClientesRepositorio _clientesRepositorio;
        private readonly DulceFacilDBContext _dbContext;

        public ClientesServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _dbContext = dulceFacilDBContext;
            _clientesRepositorio = new ClientesRepositorioImpl(_dbContext);
        }

        public async Task AddClientesAsync(ClienteDTO cliente)
        {
            var data = new Clientes
            {
                Nombre = cliente.Nombre,
                TipoIdentificacion = cliente.TipoIdentificacion,
                Identificacion = cliente.Identificacion,
                Telefono = cliente.Telefono,
                Email = cliente.Email,
                Direccion = cliente.Direccion,
                IdZonaGeografica = cliente.IdZonaGeografica,
                IdCategoriaCliente = cliente.IdCategoriaCliente,
            };

            await _clientesRepositorio.AddAsync(data);
        }

        public async Task DeleteClientesAsync(int id)
        {
            await _clientesRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<ClienteDTO>> GetAllClientesAsync()
        {
            return await _clientesRepositorio.GetClientesDetalles();
        }

        public async Task<Clientes> GetClientesByIdAsync(int id)
        {
            return await _clientesRepositorio.GetByIdAsync(id);
        }

        public async Task<bool> UpdateClientesAsync(ClienteDTO dto)
        {
            var data = await _clientesRepositorio.GetByIdAsync(dto.IdCliente);
            if (data == null)
                return false;

            data.Nombre = dto.Nombre;
            data.TipoIdentificacion = dto.TipoIdentificacion;
            data.Identificacion = dto.Identificacion;
            data.Telefono = dto.Telefono;
            data.Email = dto.Email;
            data.Direccion = dto.Direccion;
            data.IdZonaGeografica = dto.IdZonaGeografica;
            data.IdCategoriaCliente = dto.IdCategoriaCliente;
            data.Estado = dto.Estado;
            data.FechaModificacion = DateTime.UtcNow;

            await _clientesRepositorio.UpdateAsync(data);
            return true;
        }

        public async Task<IEnumerable<ClienteDTO>> BuscarPorNombres(string nombres)
        {
            return await _clientesRepositorio.ClientesPorNombres(nombres);
        }
    }
}
