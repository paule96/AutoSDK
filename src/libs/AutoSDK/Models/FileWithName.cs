namespace AutoSDK.Models;

/// <summary>
/// 
/// </summary>
/// <param name="Name"></param>
/// <param name="Text"></param>
public struct FileWithName(
    string Name,
    string Text) : IEquatable<FileWithName>
{
    /// <summary>
    /// 
    /// </summary>
    public static FileWithName Empty => new(
        Name: string.Empty,
        Text: string.Empty);

    /// <summary>
    /// 
    /// </summary>
    public bool IsEmpty => string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Text);

    public string Name { get; } = Name;
    public string Text { get; } = Text;

    public override bool Equals(object? obj)
    {
        if (obj is FileWithName other)
        {
            return Name == other.Name && Text == other.Text;
        }
        return false;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (Name?.GetHashCode() ?? 0);
            hash = hash * 23 + (Text?.GetHashCode() ?? 0);
            return hash;
        }
    }

    bool IEquatable<FileWithName>.Equals(FileWithName other)
    {
        return this.Equals(other);
    }

    public static bool operator ==(FileWithName left, FileWithName right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(FileWithName left, FileWithName right)
    {
        return !(left == right);
    }
}
