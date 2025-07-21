using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.AspNetCore.Mvc;

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
    }
}
