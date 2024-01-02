using System.ComponentModel.DataAnnotations.Schema;

namespace StockMasterfyAPI.Models
{

    [Table("usuarios")]
    public record Usuario(int Id, string Dsnome, string Dslogin, string Dssenha);
}