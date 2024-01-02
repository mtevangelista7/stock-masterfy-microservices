namespace StockMasterfyAPI.Services
{
    public interface IDbService
    {
        Task<List<T>> GetAll<T>(string command, object parms);
    }
}
