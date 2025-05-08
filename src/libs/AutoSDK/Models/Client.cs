using System.Collections.Immutable;

namespace AutoSDK.Models;

public struct Client(
    string Id,
    string Namespace,
    string ClassName,
    string BaseUrl,
    ImmutableArray<PropertyData> Clients,
    string Summary,
    string BaseUrlSummary,
    Settings Settings,
    ImmutableArray<string> Converters
) : IEquatable<Client>
{
    public string FileNameWithoutExtension => $"{Namespace}.{ClassName}";

    public string InterfaceFileNameWithoutExtension => $"{Namespace}.I{ClassName}";

    public string Id { get; } = Id;
    public string Namespace { get; } = Namespace;
    public string ClassName { get; } = ClassName;
    public string BaseUrl { get; } = BaseUrl;
    public ImmutableArray<PropertyData> Clients { get; } = Clients;
    public string Summary { get; } = Summary;
    public string BaseUrlSummary { get; } = BaseUrlSummary;
    public Settings Settings { get; } = Settings;
    public ImmutableArray<string> Converters { get; } = Converters;

    public override bool Equals(object obj)
    {
        if (obj is not Client other)
        {
            return false;
        }

        return Id == other.Id &&
               Namespace == other.Namespace &&
               ClassName == other.ClassName &&
               BaseUrl == other.BaseUrl &&
               Clients.SequenceEqual(other.Clients) &&
               Summary == other.Summary &&
               BaseUrlSummary == other.BaseUrlSummary &&
               Settings.Equals(other.Settings) &&
               Converters.SequenceEqual(other.Converters);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Id.GetHashCode();
            hash = hash * 23 + Namespace.GetHashCode();
            hash = hash * 23 + ClassName.GetHashCode();
            hash = hash * 23 + BaseUrl.GetHashCode();
            hash = hash * 23 + Clients.GetHashCode();
            hash = hash * 23 + Summary.GetHashCode();
            hash = hash * 23 + BaseUrlSummary.GetHashCode();
            hash = hash * 23 + Settings.GetHashCode();
            hash = hash * 23 + Converters.GetHashCode();
            return hash;
        }
    }

    bool IEquatable<Client>.Equals(Client other)
    {
        return this.Equals(other);
    }

    public static bool operator ==(Client left, Client right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Client left, Client right)
    {
        return !(left == right);
    }
}