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
                    "SELECT id, ds_nome, ds_login FROM USUARIOS WHERE DS_LOGIN = @DsLogin",
                    new { DSLOGIN = login });
            return result;
        }

        public async Task<string> RecuperaHashSenhaDoBanco(string login)
        {
            var result =
                await _dbService.RetornaPrimeiro<string>(
                    "SELECT DS_HASHSENHA FROM Usuarios WHERE DS_LOGIN = @DsLogin",
                    new { DsLogin = login });
            return result;
        }

        public async Task<bool> InsereUsuario(Usuario usuario)
        {
            // Gerar o hash da senha combinada com o salt
            string hashSenha = BCrypt.Net.BCrypt.HashPassword(usuario.Dssenha);

            var result =
                await _dbService.ExecutaComando(
                    "INSERT INTO usuarios (DS_NOME, DS_LOGIN, DS_HASHSENHA) VALUES (@Dsnome, @Dslogin, @hashSenha)",
                    new { usuario.Dsnome, usuario.Dslogin, hashSenha });
            return true;
        }
    }
}
