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
    public class PuntosVentaServicioImpl : IPuntosVentaServicio
    {
        private IPuntosVentaRepositorio _puntosVentaRepositorio;

        public PuntosVentaServicioImpl(DulceFacilDBContext dulceFacilDBContext)
        {
            _puntosVentaRepositorio = new PuntosVentaRepositorioImpl(dulceFacilDBContext);
        }

        public async Task AddPuntosVentaAsync(PuntosVenta puntoVenta)
        {
            await _puntosVentaRepositorio.AddAsync(puntoVenta);
        }

        public async Task DeletePuntosVentaAsync(int id)
        {
            await _puntosVentaRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<PuntosVenta>> GetAllPuntosVentaAsync()
        {
            return await _puntosVentaRepositorio.GetAllAsync();
        }

        public async Task<PuntosVenta> GetPuntosVentaByIdAsync(int id)
        {
            return await _puntosVentaRepositorio.GetByIdAsync(id);
        }

        public async Task UpdatePuntosVentaAsync(PuntosVenta puntoVenta)
        {
            await _puntosVentaRepositorio.UpdateAsync(puntoVenta);
        }
    }
}
