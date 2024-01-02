using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using StockMasterfyAPI.Data;

public class UsuarioRepository
{
    private readonly Func<Task<IDbConnection>> _connectionGetter;

    public UsuarioRepository(Func<Task<IDbConnection>> connectionGetter)
    {
        _connectionGetter = connectionGetter;
    }

    public async Task<List<Usuario>> GetAll()
    {
        try
        {
            using var con = await _connectionGetter();
            string query = @"select id, name, customer, workedHours, flatRateAmount, hourlyRateAmount, startDate, endDate, active from project";

            var projects = await con.QueryAsync<Usuario>(query);
            return projects.ToList();
        }
        catch (Exception)
        {
            return new List<Usuario>();
        }
    }

    public async Task<Usuario> GetUsuarioByLoginSenha(string login, string senha)
    {
        using var con = await _connectionGetter();
        return await con.QueryFirstOrDefaultAsync<Usuario>(
            "SELECT * FROM Usuarios WHERE Login = @Login AND Senha = @Senha",
            new { Login = login, Senha = senha });
    }
}
