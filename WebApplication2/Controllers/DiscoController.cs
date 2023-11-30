using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.ModelsDisco;

namespace WebApplication2.ControllersDisco
{
    [ApiController]
    [Route("[controller]")]
    public class DiscoController : ControllerBase
    {
    
        private readonly ILogger<DiscoController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public DiscoController(
            ILogger<DiscoController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [HttpPost(Name = "PostDisco")]
        public IActionResult Post(
            [FromBody] Disco disco)
        {
            _aplicacionContexto.Disco.Add(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco);
        }
        //READ: Obtener lista de estudiantes
        [HttpGet(Name = "GetDisco")]
        public IEnumerable<Disco> Get()
        {
            return _aplicacionContexto.Disco.ToList();
        }

        //Update: Modificar estudiantes
        [HttpPut(Name = "PutDisco")]
        public IActionResult Put([FromBody] Disco disco)
        {
            _aplicacionContexto.Disco.Update(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco );
        }

        //Delete: Eliminar estudiantes
        [HttpDelete(Name = "DeleteDisco")]
        public IActionResult Delete(int DiscoId)
        {
            _aplicacionContexto.Disco.Remove(
                _aplicacionContexto.Disco.ToList()
                .Where(x => x.IdDisco == DiscoId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges ();
            return Ok(DiscoId);
        }
    }
}