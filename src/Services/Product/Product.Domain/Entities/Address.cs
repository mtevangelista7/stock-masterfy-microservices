using Product.Domain.ValueObjects;

namespace Product.Domain.Entities;

public class Address : EntityBase
{
    public string Street { get; private set; }
    public string Number { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public CEP CEP { get; private set; }
}