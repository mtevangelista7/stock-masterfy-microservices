namespace Product.Domain.Entities;

public class Product : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int QuantityStock { get; set; }
    public Category Category { get; set; }
    public Supplier Supplier { get; set; }
}