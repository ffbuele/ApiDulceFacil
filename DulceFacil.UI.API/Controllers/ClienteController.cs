using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DulceFacil.UI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClientesServicio _clientesServicio;

        public ClienteController(IClientesServicio clientesServicio)
        {
            _clientesServicio = clientesServicio;
        }

        [HttpGet("GetClientes")]
        public async Task<IEnumerable<ClienteDTO>> GetClientes()
        {
            return await _clientesServicio.GetAllClientesAsync();
        }

        [HttpPost("CrearCliente")]
        public async Task<IActionResult> CrearCliente([FromBody] ClienteDTO data)
        {
            try
            {
                await _clientesServicio.AddClientesAsync(data);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpPut("ActualizarCliente")]
        public async Task<IActionResult> ActualizarCliente([FromBody] ClienteDTO dto)
        {
            try
            {
                var actualizado = await _clientesServicio.UpdateClientesAsync(dto);
                if (!actualizado)
                    return NotFound("Cliente no encontrado");

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpDelete("EliminarCliente/{idCliente}")]
        public async Task<IActionResult> EliminarCliente(int idCliente)
        {
            try
            {
                await _clientesServicio.DeleteClientesAsync(idCliente);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpGet("BuscarPorNombre")]
        public async Task<IActionResult> ClientesPorNombres([FromQuery] string nombres)
        {
            try
            {
                var data = await _clientesServicio.BuscarPorNombres(nombres);
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
