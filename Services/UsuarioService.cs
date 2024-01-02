using Dapper;
using Dapper.Contrib.Extensions;
using Npgsql;
using StockMasterfyAPI.Models;
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

        public async Task<List<Usuario>> RetornaUsuarios()
        {
            var resultado =
                await _dbService.RetornaTodos<Usuario>(" SELECT * FROM USUARIOS ", new { });
            return resultado;
        }
    }
}
