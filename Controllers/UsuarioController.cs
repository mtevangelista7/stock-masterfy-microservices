using Microsoft.AspNetCore.Mvc;
using StockMasterfyAPI.Models;
using StockMasterfyAPI.Services;

namespace StockMasterfyAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        // construtor com o serviço de usuario
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _usuarioService.RetornaUsuarios();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> RetornaUsuarioLoginSenha([FromBody] Usuario usuario)
        {
            var result = await _usuarioService.RetornaUsuarioLoginSenha(usuario);

            return Ok(result);
        }
    }
}
