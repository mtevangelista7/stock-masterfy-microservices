using System.ComponentModel.DataAnnotations.Schema;

namespace StockMasterfyAPI.Models
{

    [Table("usuarios")]
    public record Usuario(int id, string nome, string login, string senha);
}