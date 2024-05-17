namespace StockMasterfyAPI.Services
{
    public interface IDbService
    {
        Task<List<T>> RetornaTodos<T>(string querySQL, object parametros);
        Task<T> RetornaPrimeiro<T>(string querySQL, object parametros);
        Task<int> ExecutaComando(string querySQL, object parametros);
    }
}
