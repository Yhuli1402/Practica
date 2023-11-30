using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Context;
using WebApplication2.ModelsMusica;

namespace WebApplication2.ControllersMusica
{
    [ApiController]
    [Route("[controller]")]
    public class MusicaController : ControllerBase
    {
        private readonly ILogger<MusicaController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;

        public MusicaController(
            ILogger<MusicaController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        // CREATE: Crear materia
        [HttpPost(Name = "PostMusica")]
        public IActionResult Post([FromBody] Musica musica)
        {
            _aplicacionContexto.Musica.Add(musica);
            _aplicacionContexto.SaveChanges();
            return Ok(musica);
        }

        // READ: Obtener lista de materias
        [HttpGet(Name = "GetMusica")]
        public IEnumerable<Musica> Get()
        {
            return _aplicacionContexto.Musica.ToList();
        }

        // UPDATE: Modificar materia
        [HttpPut(Name = "PutMusica")]
        public IActionResult Put([FromBody] Musica musica)
        {
            _aplicacionContexto.Musica.Update(musica);
            _aplicacionContexto.SaveChanges();
            return Ok(musica);
        }

        // DELETE: Eliminar materia
        [HttpDelete(Name = "DeleteMusica")]
        public IActionResult Delete(int musicaId)
        {
            var musica = _aplicacionContexto.Musica
                .FirstOrDefault(x => x.IdMusica == musicaId);

            if (musica != null)
            {
                _aplicacionContexto.Musica.Remove(musica);
                _aplicacionContexto.SaveChanges();
                return Ok(musicaId);
            }
            else
            {
                return NotFound($"Musica con Id {musicaId} no encontrada.");
            }
        }
    }
}
