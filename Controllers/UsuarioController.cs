using Microsoft.AspNetCore.Mvc;
using StockMasterfyAPI.Services;

namespace StockMasterfyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        // construtor com o serviço de usuario
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _usuarioService.RetornaUsuarios();

            return Ok(result);
        }
    }
}
