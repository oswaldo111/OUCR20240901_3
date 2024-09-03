using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OUCR20240901_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        // GET: api/<NotaController>
       

        // GET api/<NotaController>/5
        static List<float> notas = new List<float>();
        // GET: api/<AlumnosController>

        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<float> Get()
        {
            return notas;
        }

      

        // POST api/<AlumnosController>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody]  float nota)
        {
            notas.Add(nota);
            return Ok();
        }

        // PUT api/<AlumnosController>/5
        
    }
}
