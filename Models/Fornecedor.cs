using System.ComponentModel.DataAnnotations.Schema;

namespace StockMasterfyAPI.Models
{
    [Table("fornecedores")]
    public record Fornecedor
    (
        int CdFornecedor,
        string DsNome,
        string DsCNPJ,
        string DsTelefoneFixo,
        string DsCelular,
        string DsEmail,
        List<Endereco> Enderecos,
        List<Produto> Produtos
    )
    {
        public Fornecedor() : this(0, null, null, null, null, null, null, null) { }
    }
}
