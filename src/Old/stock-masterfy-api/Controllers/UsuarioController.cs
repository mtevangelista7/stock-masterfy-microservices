using Microsoft.AspNetCore.Mvc;
using StockMasterfyAPI.Models;
using StockMasterfyAPI.Services;
using BCrypt.Net;

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
            if (await LoginValido(usuario.Dslogin, usuario.Dssenha))
            {
                Usuario usuarioAux = await _usuarioService.RetornaUsuarioLogin(usuario.Dslogin);
                return Ok(usuarioAux);
            }

            return Unauthorized();
        }

        private async Task<bool> LoginValido(string login, string senhaDoUsuario)
        {
            // Obter hash da senha e salt do banco de dados usando o login
            string hashSenhaArmazenado = await _usuarioService.RecuperaHashSenhaDoBanco(login);

            bool senhaCorreta = !string.IsNullOrEmpty(hashSenhaArmazenado) &&
                                BCrypt.Net.BCrypt.Verify(senhaDoUsuario, hashSenhaArmazenado);

            return senhaCorreta;
        }

        [HttpPost("insere")]
        public async Task<IActionResult> InsereUsuario([FromBody] Usuario usuario)
        {
            bool bUsuarioInserido = await _usuarioService.InsereUsuario(usuario);

            return Ok(bUsuarioInserido);
        }
    }
}
