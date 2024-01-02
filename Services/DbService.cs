
using Dapper;
using Npgsql;
using System.Data;

namespace StockMasterfyAPI.Services
{
    public class DbService : IDbService
    {
        private readonly IDbConnection _db;

        public DbService(IConfiguration configuration)
        {
            _db = new NpgsqlConnection(configuration.GetConnectionString("PostgreSQLConnection"));
        }

        public async Task<List<T>> RetornaTodos<T>(string querySQL, object parametros)
        {
            List<T> result = new List<T>();

            result = (await _db.QueryAsync<T>(querySQL, parametros)).ToList();

            return result;
        }

        public async Task<T> RetornaPrimeiro<T>(string querySQL, object parametros)
        {
            var result = await _db.QueryFirstOrDefaultAsync<T>(querySQL, parametros);

            return result;
        }
    }
}
