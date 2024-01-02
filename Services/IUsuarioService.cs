
using StockMasterfyAPI.Models;

namespace StockMasterfyAPI.Services
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> RetornaUsuarios();
    }
}
