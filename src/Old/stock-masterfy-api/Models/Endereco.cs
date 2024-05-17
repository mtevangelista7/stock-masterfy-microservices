using System.ComponentModel.DataAnnotations.Schema;

namespace StockMasterfyAPI.Models
{
    [Table("enderecos")]
    public record Endereco
        (
        int CdEndereco,
        string DsCidade,
        string DsEstado,
        string DsCep
        )
    {
    }
}
