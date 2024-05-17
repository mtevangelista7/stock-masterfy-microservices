namespace Product.Domain.ValueObjects;

public class DDD : IEquatable<DDD>
{
    public string Code { get; }

    public bool Equals(DDD? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Code == other.Code;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((DDD)obj);
    }

    public override int GetHashCode()
    {
        return Code.GetHashCode();
    }
}