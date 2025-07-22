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
    public class ZonasGeograficasRepositorioImpl : RepositorioImpl<ZonasGeograficas>, IZonasGeograficasRepositorio
    {
        private readonly DulceFacilDBContext _dbContext;

        public ZonasGeograficasRepositorioImpl(DulceFacilDBContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<List<ZonasGeograficas>> ZonasPorNombres(string nombres)
        {
            try
            {
                var resultado = (from zonas in _dbContext.ZonasGeograficas
                                 where zonas.Nombre.Contains(nombres)
                                 select zonas
                                ).ToListAsync();

                return await resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener zonas por nombres: {ex.Message}");
            }
        }
    }
}
