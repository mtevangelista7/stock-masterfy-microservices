
using StockMasterfyAPI.Models;

namespace StockMasterfyAPI.Services
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> RetornaUsuarios();
        Task<Usuario> RetornaUsuarioLogin(string login);
        Task<string> RecuperaHashSenhaDoBanco(string login);
        Task<string> RecuperaSaltDoBanco(string login);
    }
}
