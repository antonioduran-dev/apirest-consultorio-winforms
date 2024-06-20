using ConsultorioAPI.Services;
using DB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultorioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Usuario>))]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            var response = await _usuarioService.Get();
            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Usuario))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var response = await _usuarioService.Get(id);

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Usuario))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("username")]
        public async Task<ActionResult<Usuario>> GetUsuarioByUsername([FromQuery]string username)
        {
            var response = await _usuarioService.GetByUsername(username);

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Usuario))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario model)
        {
            var response = await _usuarioService.Add(model);
            return CreatedAtAction(nameof(GetUsuario), new { id = model.UsuarioId }, model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        public async Task<IActionResult> PutUsuario(Usuario model)
        {
            var response = await _usuarioService.Update(model);
            return response ? NoContent() : NotFound();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var success = await _usuarioService.Delete(id);
            if (!success)
                return NotFound();

            return NoContent();
        }
    }
}
