using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SantaRamona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // POST api/<PersonaController>
        [HttpPost]
        public Persona Post(Persona persona)
        {
            persona.edad = persona.edad + 5;
            return persona;
        }

    }
}
