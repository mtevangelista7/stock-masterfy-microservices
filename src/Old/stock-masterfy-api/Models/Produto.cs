using System.ComponentModel.DataAnnotations.Schema;

namespace StockMasterfyAPI.Models
{
    [Table("produtos")]
    public record Produto
        (
        int CdProduto,
        string DsNome,
        DateTime DtCadastro,
        List<Fornecedor> Fornecedores,
        Categoria Categoria,
        UnidadeMedida UnidadeMedida,
        double NrValorCusto,
        double NrValorVenda,
        int NrQuantidade
        )
    {
        public Produto() : this(0, "", DateTime.Now, null, null, null, 0, 0, 0) { }
    }
}
