namespace AutoSDK.Models;

public struct Data(
    EquatableArray<ModelData> Classes,
    EquatableArray<ModelData> Enums,
    EquatableArray<EndPoint> Methods,
    EquatableArray<Client> Clients,
    EquatableArray<AnyOfData> AnyOfs,
    EquatableArray<TypeData> Types,
    EquatableArray<Authorization> Authorizations,
    Client Converters,
    IReadOnlyList<SchemaContext> Schemas,
    IReadOnlyList<SchemaContext> FilteredSchemas,
    Times Times) : IEquatable<Data>
{
    public EquatableArray<ModelData> Classes { get; } = Classes;
    public EquatableArray<ModelData> Enums { get; } = Enums;
    public EquatableArray<EndPoint> Methods { get; } = Methods;
    public EquatableArray<Client> Clients { get; } = Clients;
    public EquatableArray<AnyOfData> AnyOfs { get; } = AnyOfs;
    public EquatableArray<TypeData> Types { get; } = Types;
    public EquatableArray<Authorization> Authorizations { get; } = Authorizations;
    public Client Converters { get; } = Converters;
    public IReadOnlyList<SchemaContext> Schemas { get; } = Schemas;
    public IReadOnlyList<SchemaContext> FilteredSchemas { get; } = FilteredSchemas;
    public Times Times { get; } = Times;

    public override bool Equals(object? obj)
    {
        if (obj is not Data other)
        {
            return false;
        }

        return Classes.Equals(other.Classes) &&
               Enums.Equals(other.Enums) &&
               Methods.Equals(other.Methods) &&
               Clients.Equals(other.Clients) &&
               AnyOfs.Equals(other.AnyOfs) &&
               Types.Equals(other.Types) &&
               Authorizations.Equals(other.Authorizations) &&
               Converters.Equals(other.Converters) &&
               Schemas.SequenceEqual(other.Schemas) &&
               FilteredSchemas.SequenceEqual(other.FilteredSchemas) &&
               Times.Equals(other.Times);
    }

    public override int GetHashCode()
    {
        const int offset = unchecked((int)2166136261);
        const int prime = 16777619;

        int hash = offset;

        hash = (hash ^ Classes.GetHashCode()) * prime;
        hash = (hash ^ Enums.GetHashCode()) * prime;
        hash = (hash ^ Methods.GetHashCode()) * prime;
        hash = (hash ^ Clients.GetHashCode()) * prime;
        hash = (hash ^ AnyOfs.GetHashCode()) * prime;
        hash = (hash ^ Types.GetHashCode()) * prime;
        hash = (hash ^ Authorizations.GetHashCode()) * prime;
        hash = (hash ^ Converters.GetHashCode()) * prime;
        hash = (hash ^ Schemas.GetHashCode()) * prime;
        hash = (hash ^ FilteredSchemas.GetHashCode()) * prime;
        hash = (hash ^ Times.GetHashCode()) * prime;

        return hash;
    }

    bool IEquatable<Data>.Equals(Data other)
    {
        return this.Equals(other);
    }

    public static bool operator ==(Data left, Data right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Data left, Data right)
    {
        return !(left == right);
    }
}
