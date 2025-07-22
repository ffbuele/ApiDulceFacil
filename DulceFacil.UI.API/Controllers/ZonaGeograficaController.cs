using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DulceFacil.UI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZonaGeograficaController : ControllerBase
    {
        private IZonasGeograficasServicio _zonasGeograficasServicio;

        public ZonaGeograficaController(IZonasGeograficasServicio zonasGeograficasServicio)
        {
            _zonasGeograficasServicio = zonasGeograficasServicio;
        }

        [HttpGet("GetZonasGeograficas")]
        public async Task<IEnumerable<ZonasGeograficas>> GetZonasGeograficas()
        {
            return await _zonasGeograficasServicio.GetAllZonasGeograficasAsync();
        }

        [HttpPost("CrearZonaGeografica")]
        public async Task<IActionResult> CrearZonaGeografica([FromBody] ZonasGeograficas nuevo)
        {
            try
            {
                await _zonasGeograficasServicio.AddZonasGeograficasAsync(nuevo);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpPut("ActualizarZonaGeografica")]
        public async Task<IActionResult> ActualizarZonaGeografica([FromBody] ZonasGeograficas zona)
        {
            try
            {
                var actualizado = await _zonasGeograficasServicio.UpdateZonasGeograficasAsync(zona);
                if (!actualizado)
                    return NotFound("Zona no encontrada");

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpDelete("EliminarZonaGeografica/{idZona}")]
        public async Task<IActionResult> EliminarZonaGeografica(int idZona)
        {
            try
            {
                await _zonasGeograficasServicio.DeleteZonasGeograficasAsync(idZona);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpGet("BuscarPorNombre")]
        public async Task<IActionResult> BuscarPorNombre([FromQuery] string nombres)
        {
            try
            {
                var data = await _zonasGeograficasServicio.ZonasPorNombres(nombres);
                return Ok(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }
    }
}
