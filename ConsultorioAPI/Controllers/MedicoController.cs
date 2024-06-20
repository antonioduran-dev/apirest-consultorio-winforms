using ConsultorioAPI.Services;
using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoService _medicoService;
        public MedicoController(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Medico>))]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medico>>> GetMedicos()
        {
            var response = await _medicoService.GetMedicos();
            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Medico))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Medico>> GetMedico(int id)
        {
            var response = await _medicoService.GetMedico(id);

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Medico))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{usuarioId}/usuario")]
        public async Task<ActionResult<Medico>> GetMedicoByUsuarioId(int usuarioId)
        {
            var response = await _medicoService.GetMedicoByUsuarioId(usuarioId);

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Medico))]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{medicoId}/citas")]
        public async Task<ActionResult<Medico>> GetCitasByMedicoId(int medicoId)
        {
            var response = await _medicoService.GetCitasByMedicoId(medicoId);

            //if (response == null || !response.Any())
            //    return NotFound();

            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Medico))]
        [HttpPost]
        public async Task<ActionResult<Medico>> PostMedico([FromBody]Medico model)
        {

            await _medicoService.AddMedico(model);
            return CreatedAtAction(nameof(GetMedico), new { id = model.MedicoId }, model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut]
        public async Task<IActionResult> PutMedico([FromBody]Medico model)
        {
            var response = await _medicoService.UpdateMedico(model);
            return response ? NoContent() : NotFound();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedico(int id)
        {
            var success = await _medicoService.DeleteMedico(id);

            return success ? NoContent() : NotFound();
        }
    }
}
