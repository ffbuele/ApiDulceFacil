using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DulceFacil.UI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private IRolesServicio _rolesServicio;

        public RolesController(IRolesServicio rolesServicio)
        {
            _rolesServicio = rolesServicio;
        }

        // listas roles
        [HttpGet("GetRoles")]
        public async Task<IEnumerable<Roles>> GetRoles()
        {
            return await _rolesServicio.GetAllRolesAsync();
        }
    }
}
