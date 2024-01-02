namespace StockMasterfyAPI.Services
{
    public interface IDbService
    {
        Task<List<T>> RetornaTodos<T>(string querySQL, object parametros);
    }
}
