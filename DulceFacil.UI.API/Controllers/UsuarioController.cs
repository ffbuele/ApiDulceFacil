using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DulceFacil.UI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuariosServicio _usuariosServicio;

        public UsuarioController(IUsuariosServicio usuariosServicio)
        {
            _usuariosServicio = usuariosServicio;
        }

        // listas roles
        [HttpGet("GetUsuarios")]
        public async Task<IEnumerable<UsuarioDTO>> GetUsuarios()
        {
            return await _usuariosServicio.GetUsuariosRoles();
        }

        [HttpPost("CrearUsuario")]
        public async Task<IActionResult> CrearUsuario([FromBody] Usuarios nuevoUsuario)
        {
            try
            {
                await _usuariosServicio.AddUsuariosAsync(nuevoUsuario);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpPut("ActualizarUsuario")]
        public async Task<IActionResult> ActualizarUsuario([FromBody] UsuarioDTO dto)
        {
            try
            {
                var actualizado = await _usuariosServicio.UpdateUsuariosAsync(dto);
                if (!actualizado)
                    return NotFound("Usuario no encontrado");

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpDelete("EliminarUsuario/{idUsuario}")]
        public async Task<IActionResult> EliminarUsuario(int idUsuario)
        {
            try
            {
                await _usuariosServicio.DeleteUsuariosAsync(idUsuario);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }

        [HttpGet("BuscarPorNombre")]
        public async Task<IActionResult> UsuarioPorNombres([FromQuery] string nombres)
        {
            try
            {
                var usuarios = await _usuariosServicio.UsuariosPorNombres(nombres);
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno");
            }
        }
    }
}
