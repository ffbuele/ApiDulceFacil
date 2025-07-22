using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DulceFacil.UI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaClienteController : ControllerBase
    {
        private ICategoriasClientesServicio _categoriasClientesServicio;

        public CategoriaClienteController(ICategoriasClientesServicio categoriasClientesServicio)
        {
            _categoriasClientesServicio = categoriasClientesServicio;
        }

        [HttpGet("GetCategoriasClientes")]
        public async Task<IEnumerable<CategoriasClientes>> GetCategoriasClientess()
        {
            return await _categoriasClientesServicio.GetAllCategoriasClientesAsync();
        }

        [HttpPost("CrearCategoriasClientes")]
        public async Task<IActionResult> CrearCategoriasClientes([FromBody] CategoriasClientes nuevoCategoriasClientes)
        {
            try
            {
                await _categoriasClientesServicio.AddCategoriasClientesAsync(nuevoCategoriasClientes);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpPut("ActualizarCategoriasClientes")]
        public async Task<IActionResult> ActualizarCategoriasClientes([FromBody] CategoriasClientes catCliente)
        {
            try
            {
                var actualizado = await _categoriasClientesServicio.UpdateCategoriasClientesAsync(catCliente);
                if (!actualizado)
                    return NotFound("CategoriasClientes no encontrado");

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpDelete("EliminarCategoriasClientes/{idCategoriasClientes}")]
        public async Task<IActionResult> EliminarCategoriasClientes(int idCategoriasClientes)
        {
            try
            {
                await _categoriasClientesServicio.DeleteCategoriasClientesAsync(idCategoriasClientes);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpGet("BuscarPorNombre")]
        public async Task<IActionResult> CategoriasClientesPorNombres([FromQuery] string nombres)
        {
            try
            {
                var CategoriasClientess = await _categoriasClientesServicio.BuscarPorNombres(nombres);
                return Ok(CategoriasClientess);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }
    }
}
