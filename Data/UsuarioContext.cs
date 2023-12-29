using System.Data;

namespace StockMasterfyAPI.Data
{
    public class UsuarioContext
    {
        public delegate Task<IDbConnection> GetConnection();
    }
}
