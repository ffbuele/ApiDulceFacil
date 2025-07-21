using Microsoft.AspNetCore.Mvc;

namespace DulceFacil.UI.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string mensaje()
        {
            return "Hola Mundo";
        }
    }
}
