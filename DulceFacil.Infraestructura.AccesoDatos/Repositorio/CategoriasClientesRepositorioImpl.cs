using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Dominio.Modelos.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class CategoriasClientesRepositorioImpl : RepositorioImpl<CategoriasClientes>, ICategoriasClientesRepositorio
    {
        private readonly DulceFacilDBContext _dbContext;

        public CategoriasClientesRepositorioImpl(DulceFacilDBContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<List<CategoriasClientes>> BuscarPorNombres(string nombres)
        {
            try
            {
                var resultado = (from catClientes in _dbContext.CategoriasClientes
                                 where catClientes.Estado.Contains(nombres)
                                 select catClientes
                                 ).ToListAsync();

                return await resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener categorias: {ex.Message}");
            }
        }
    }
}
