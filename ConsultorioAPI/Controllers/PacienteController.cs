using ConsultorioAPI.Services;
using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultorioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;
        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Paciente>))]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> GetPacientes()
        {
            var response = await _pacienteService.GetPacientes();
            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Paciente))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Paciente>> GetPaciente(int id)
        {
            var response = await _pacienteService.GetPaciente(id);

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Paciente))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult<Paciente>> PostEspecialidad(Paciente model)
        {
            await _pacienteService.AddPaciente(model);
            return CreatedAtAction(nameof(GetPaciente), new { id = model.PacienteId }, model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        public async Task<IActionResult> PutEspecialidad(Paciente model)
        {
            var response = await _pacienteService.UpdatePaciente(model);
            return response ? NoContent() : NotFound();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaciente(int id)
        {
            var success = await _pacienteService.DeletePaciente(id);
            if (!success)
                return NotFound();

            return NoContent();
        }
    }
}
