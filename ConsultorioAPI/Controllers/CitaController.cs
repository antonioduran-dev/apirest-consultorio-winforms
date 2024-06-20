using ConsultorioAPI.Services;
using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaService _citaService;
        public CitaController(ICitaService citaService)
        {
            _citaService = citaService;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Cita>))]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> GetCitas()
        {
            var response = await _citaService.GetCitas();
            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Cita))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Cita>> GetCita(int id)
        {
            var response = await _citaService.GetCita(id);

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Cita))]
        [HttpPost]
        public async Task<ActionResult<Cita>> PostMedico([FromBody]Cita model)
        {

            await _citaService.AddCita(model);
            return CreatedAtAction(nameof(GetCita), new { id = model.CitaId }, model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut]
        public async Task<IActionResult> PutCita([FromBody]Cita model)
        {
            var response = await _citaService.UpdateCita(model);
            return response ? NoContent() : NotFound();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedico(int id)
        {
            var success = await _citaService.DeleteCita(id);

            return success ? NoContent() : NotFound();
        }
    }
}
