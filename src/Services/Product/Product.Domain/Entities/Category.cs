namespace Product.Domain.Entities;

public class Category : EntityBase
{
    public string Name { get; set; }
    public string Descriptiopn { get; set; }
    public List<Product> Products { get; set; }
}