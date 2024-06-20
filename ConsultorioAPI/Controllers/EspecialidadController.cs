using ConsultorioAPI.Services;
using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultorioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadController : ControllerBase
    {
        private readonly IEspecialidadService _especialidadService;
        public EspecialidadController(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Especialidad>))]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Especialidad>>> GetEspecialidades()
        {
            var response = await _especialidadService.GetEspecialidades();
            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Especialidad))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Especialidad>> GetEspecialidad(int id)
        {
            var response = await _especialidadService.GetEspecialidad(id);

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Especialidad))]
        [HttpPost]
        public async Task<ActionResult<Especialidad>> PostEspecialidad([FromBody]Especialidad model)
        {
            await _especialidadService.AddEspecialidad(model);
            return CreatedAtAction(nameof(GetEspecialidad), new { id = model.EspecialidadId }, model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut]
        public async Task<IActionResult> PutEspecialidad([FromBody]Especialidad model)
        {
            var response = await _especialidadService.UpdateEspecialidad(model);

            return response ? NoContent() : NotFound();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaciente(int id)
        {
            var success = await _especialidadService.DeleteEspecialidad(id);
            if (!success)
                return NotFound();

            return NoContent();
        }
    }
}
