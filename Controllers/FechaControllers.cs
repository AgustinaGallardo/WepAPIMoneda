using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FechaControllers : ControllerBase
    {//IActionResult == interfaz, objeto que representa el obje http junto con lo datos de la respuesta
      [HttpGet()]
        
        public IActionResult Get()
        {
            return Ok(new FechaControllers());
        }

    }
}
