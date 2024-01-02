using Dapper;
using Dapper.Contrib.Extensions;
using Npgsql;
using StockMasterfyAPI.Data;
using System.Data;

namespace StockMasterfyAPI.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IDbService _dbService;

        public UsuarioService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<List<Usuario>> RetornaUsuario()
        {
            var result =
                await _dbService.GetAll<Usuario>("", "");
            return result;
        }
    }
}
