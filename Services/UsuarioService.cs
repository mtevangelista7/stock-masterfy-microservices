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

        public async Task<Usuario> RetornaUsuarioLogin(string login)
        {
            var result =
                await _dbService.RetornaPrimeiro<Usuario>(
                    "SELECT * FROM USUARIOS WHERE ds_login = @dslogin",
                    new { login });
            return result;
        }

        public async Task<string> RecuperaHashSenhaDoBanco(string login)
        {
            var result =
                await _dbService.RetornaPrimeiro<string>(
                    "SELECT DS_HASHSENHA FROM Usuarios WHERE DS_LOGIN = @ds_login",
                    new { login });
            return result;
        }

        public async Task<string> RecuperaSaltDoBanco(string login)
        {
            var result =
                await _dbService.RetornaPrimeiro<string>(
                    "SELECT DS_SALT FROM Usuarios WHERE DS_LOGIN = @ds_login",
                    new { login });
            return result;
        }
    }
}
