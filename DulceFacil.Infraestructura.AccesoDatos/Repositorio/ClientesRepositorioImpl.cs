using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Dominio.Modelos.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ClientesRepositorioImpl : RepositorioImpl<Clientes>, IClientesRepositorio
    {
        private readonly DulceFacilDBContext _dbContext;

        public ClientesRepositorioImpl(DulceFacilDBContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<List<ClienteDTO>> ClientesPorNombres(string nombres)
        {
            try
            {
                var resultado = (from clientes in _dbContext.Clientes
                                 join zonas in _dbContext.ZonasGeograficas
                                 on clientes.IdZonaGeografica equals zonas.IdZonaGeografica
                                 join categorias in _dbContext.CategoriasClientes
                                 on clientes.IdCategoriaCliente equals categorias.IdCategoriaCliente
                                 where clientes.Nombre.Contains(nombres)
                                 select new ClienteDTO
                                 {
                                     IdCliente = clientes.IdCliente,
                                     Nombre = clientes.Nombre,
                                     TipoIdentificacion = clientes.TipoIdentificacion,
                                     Identificacion = clientes.Identificacion,
                                     Telefono = clientes.Telefono,
                                     Email = clientes.Email,
                                     Direccion = clientes.Direccion,
                                     IdZonaGeografica = clientes.IdZonaGeografica,
                                     NombreZonaGeografica = zonas.Nombre,
                                     IdCategoriaCliente = clientes.IdCategoriaCliente,
                                     NombreCategoriaCliente = categorias.Nombre,
                                     Estado = clientes.Estado,
                                 }).ToListAsync();

                return await resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener clientes por nombres: {ex.Message}");
            }

        }

        public async Task<List<ClienteDTO>> GetClientesDetalles()
        {
            try
            {
                var resultado = (from clientes in _dbContext.Clientes
                                 join zonas in _dbContext.ZonasGeograficas
                                 on clientes.IdZonaGeografica equals zonas.IdZonaGeografica
                                 join categorias in _dbContext.CategoriasClientes
                                 on clientes.IdCategoriaCliente equals categorias.IdCategoriaCliente
                                 select new ClienteDTO
                                 {
                                     IdCliente = clientes.IdCliente,
                                     Nombre = clientes.Nombre,
                                     TipoIdentificacion = clientes.TipoIdentificacion,
                                     Identificacion = clientes.Identificacion,
                                     Telefono = clientes.Telefono,
                                     Email = clientes.Email,
                                     Direccion = clientes.Direccion,
                                     IdZonaGeografica = clientes.IdZonaGeografica,
                                     NombreZonaGeografica = zonas.Nombre,
                                     IdCategoriaCliente = clientes.IdCategoriaCliente,
                                     NombreCategoriaCliente = categorias.Nombre,
                                     Estado = clientes.Estado,
                                 }).ToListAsync();

                return await resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener clientes y detalles: {ex.Message}");
            }
        }
    }
}
