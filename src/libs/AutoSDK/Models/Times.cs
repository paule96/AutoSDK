namespace AutoSDK.Models;

public struct Times(
    TimeSpan TraversalTree,
    TimeSpan Naming,
    TimeSpan ResolveReferences,
    TimeSpan Filtering,
    TimeSpan ComputeData,
    TimeSpan ComputeDataClasses,
    TimeSpan Total
)
{
    public TimeSpan TraversalTree { get; } = TraversalTree;
    public TimeSpan Naming { get; } = Naming;
    public TimeSpan ResolveReferences { get; } = ResolveReferences;
    public TimeSpan Filtering { get; } = Filtering;
    public TimeSpan ComputeData { get; } = ComputeData;
    public TimeSpan ComputeDataClasses { get; } = ComputeDataClasses;
    public TimeSpan Total { get; } = Total;

    public override bool Equals(object obj)
    {
        if (obj is not Times other)
        {
            return false;
        }

        return TraversalTree.Equals(other.TraversalTree) &&
               Naming.Equals(other.Naming) &&
               ResolveReferences.Equals(other.ResolveReferences) &&
               Filtering.Equals(other.Filtering) &&
               ComputeData.Equals(other.ComputeData) &&
               ComputeDataClasses.Equals(other.ComputeDataClasses) &&
               Total.Equals(other.Total);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + TraversalTree.GetHashCode();
            hash = hash * 23 + Naming.GetHashCode();
            hash = hash * 23 + ResolveReferences.GetHashCode();
            hash = hash * 23 + Filtering.GetHashCode();
            hash = hash * 23 + ComputeData.GetHashCode();
            hash = hash * 23 + ComputeDataClasses.GetHashCode();
            hash = hash * 23 + Total.GetHashCode();
            return hash;
        }
    }

    public static bool operator ==(Times left, Times right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Times left, Times right)
    {
        return !(left == right);
    }
}
