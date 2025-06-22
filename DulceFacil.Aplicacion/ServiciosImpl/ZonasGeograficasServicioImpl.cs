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

        public ZonasGeograficasServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _zonasGeograficasRepositorio = new ZonasGeograficasRepositorioImpl(dulceFacilDBContext);
        }

        public async Task AddZonasGeograficasAsync(ZonasGeograficas zonaGeografica)
        {
            await _zonasGeograficasRepositorio.AddAsync(zonaGeografica);
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

        public async Task UpdateZonasGeograficasAsync(ZonasGeograficas zonaGeografica)
        {
            await _zonasGeograficasRepositorio.UpdateAsync(zonaGeografica);
        }
    }
}
