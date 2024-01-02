
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
            _db = new NpgsqlConnection(configuration.GetConnectionString("Employeedb"));
        }

        public async Task<List<T>> GetAll<T>(string command, object parms)
        {
            List<T> result = new List<T>();

            result = (await _db.QueryAsync<T>(command, parms)).ToList();

            return result;
        }
    }
}
