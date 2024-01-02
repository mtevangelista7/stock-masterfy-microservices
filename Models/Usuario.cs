using System.ComponentModel.DataAnnotations.Schema;

namespace StockMasterfyAPI.Data
{

    [Table("usuarios")]
    public record Usuario(int id, string nome, string login, string senha);
}