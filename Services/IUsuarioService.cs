using StockMasterfyAPI.Data;

namespace StockMasterfyAPI.Services
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> RetornaUsuario();
    }
}
