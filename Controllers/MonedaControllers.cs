using Microsoft.AspNetCore.Mvc;
using webAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaControllers : ControllerBase
    {
        //readonly: atributo como una constante, no cambia mas, la referencia 
        private static readonly List<Moneda> lst = new List<Moneda>();

        //otra opcion: singleton
       
        // GET: api/Moneda
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(lst);
        }

        // GET api/<Moneda>/Dolar
        [HttpGet("{nombre}")]
        public IActionResult Get(string nombre)
        {
            foreach(Moneda x in lst)
            {
                if(x.Nombre.Equals(nombre))
                {
                    return Ok(x);
                }
            }
            return NotFound("Moneda no registrada");
        }

        // POST api/<Moneda>
        [HttpPost]
        public IActionResult Post([FromBody] Moneda value)
        {

            if(value == null || string.IsNullOrEmpty(value.Nombre))            
            return BadRequest("Error objeto moneda incorrecto"); //me devuelve un objeto 400, esta spidiendo cualquier cosa, de la clase base
           
            lst.Add(value);
            return Ok(value);
        }

        // PUT api/<Moneda>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Moneda>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
