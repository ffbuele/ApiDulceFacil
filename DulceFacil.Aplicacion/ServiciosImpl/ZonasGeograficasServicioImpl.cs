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
    public class ZonasGeograficasServicioImpl : IZonasGeograficasServicio
    {
        private IZonasGeograficasRepositorio _zonasGeograficasRepositorio;
        private readonly DulceFacilDBContext _dbContext;

        public ZonasGeograficasServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _dbContext = dulceFacilDBContext;
            _zonasGeograficasRepositorio = new ZonasGeograficasRepositorioImpl(_dbContext);
        }

        public async Task AddZonasGeograficasAsync(ZonasGeograficas zonaGeografica)
        {
            await _zonasGeograficasRepositorio.AddAsync(zonaGeografica);
        }

        public async Task<IEnumerable<ZonasGeograficas>> ZonasPorNombres(string nombres)
        {
            return await _zonasGeograficasRepositorio.ZonasPorNombres(nombres);
        }

        public async Task DeleteZonasGeograficasAsync(int id)
        {
            await _zonasGeograficasRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<ZonasGeograficas>> GetAllZonasGeograficasAsync()
        {
            return await _zonasGeograficasRepositorio.GetAllAsync();
        }

        public async Task<ZonasGeograficas> GetZonasGeograficasByIdAsync(int id)
        {
            return await _zonasGeograficasRepositorio.GetByIdAsync(id);
        }

        public async Task<bool> UpdateZonasGeograficasAsync(ZonasGeograficas zonaGeografica)
        {
            var data = await _zonasGeograficasRepositorio.GetByIdAsync(zonaGeografica.IdZonaGeografica);
            if (data == null)
                return false;

            data.Nombre = zonaGeografica.Nombre;
            data.Descripcion = zonaGeografica.Descripcion;
            data.Coordenadas = zonaGeografica.Coordenadas;
            data.Estado = zonaGeografica.Estado;
            data.FechaModificacion = DateTime.UtcNow;

            await _zonasGeograficasRepositorio.UpdateAsync(data);
            return true;
        }
    }
}
