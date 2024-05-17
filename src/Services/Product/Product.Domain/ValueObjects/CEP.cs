﻿namespace Product.Domain.ValueObjects;

public class CEP : IEquatable<CEP>
{
    public string Code { get; set; }

    public bool Equals(CEP? other)
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
        return Equals((CEP)obj);
    }

    public override int GetHashCode()
    {
        return Code.GetHashCode();
    }
}