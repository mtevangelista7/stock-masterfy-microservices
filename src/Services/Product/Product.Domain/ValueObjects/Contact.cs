namespace Product.Domain.ValueObjects;

public class Contact : IEquatable<Contact>
{
    public string Name { get; }
    public DDD DDDCode { get; }
    public string Number { get; }

    public bool Equals(Contact? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name && DDDCode.Equals(other.DDDCode) && Number == other.Number;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Contact)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, DDDCode, Number);
    }
}