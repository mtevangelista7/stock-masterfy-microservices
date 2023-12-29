using System.ComponentModel.DataAnnotations.Schema;

namespace StockMasterfyAPI.Data
{

    [Table("Usuarios")]
    public record Usuario(int Id);
}
