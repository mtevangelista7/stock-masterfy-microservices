using Microsoft.AspNetCore.Mvc;
using StockMasterfyAPI.Services;

namespace StockMasterfyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService employeeService)
        {
            _usuarioService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _usuarioService.RetornaUsuario();

            return Ok(result);
        }
    }
}
