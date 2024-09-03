using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OUCR20240901_3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OUCR20240901_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MatriculaController : ControllerBase
    {
        // GET: api/<MatriculaController>
        static List<Matricula> matriculas= new List<Matricula>();
        // GET: api/<MatriculaController>
        [HttpGet]
        public IEnumerable<Matricula> Get()
        {
            return matriculas;
        }

        // GET api/<MatriculaController>/5
        [HttpGet("{id}")]
        public Matricula Get(int id)
        {
            var matricula = matriculas.FirstOrDefault(x => x.id == id);
            return matricula;
        }

        // POST api/<MatriculaController>
        [HttpPost]
        public IActionResult Post([FromBody] Matricula matricula)
        {
            matriculas.Add(matricula);
            return Ok();
        }

        // PUT api/<MatriculaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Matricula matricula)
        {
            var existingmatricula = matriculas.FirstOrDefault(y => y.id == id);
            if (existingmatricula != null)
            {
                existingmatricula.name = matricula.name;
                return Ok();
            }
            else return NotFound();
        }

     
    }
}
