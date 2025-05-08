using AutoSDK.Extensions;
using AutoSDK.Naming.AnyOfs;
using AutoSDK.Naming.Properties;
using AutoSDK.Serialization.Json;
using System.Collections.Immutable;

namespace AutoSDK.Models;

public struct AnyOfData(
    string SubType,
    int Count,
    TypeData? DiscriminatorType,
    string? DiscriminatorPropertyName,
    bool IsTrimming,
    string Namespace,
    string Name,
    string Summary,
    EquatableArray<PropertyData> Properties,
    Settings Settings
) : IEquatable<AnyOfData>
{
    public bool IsNamed => !string.IsNullOrWhiteSpace(Name);

    public string SubType { get; } = SubType;
    public int Count { get; } = Count;
    public TypeData? DiscriminatorType { get; } = DiscriminatorType;
    public string? DiscriminatorPropertyName { get; } = DiscriminatorPropertyName;
    public bool IsTrimming { get; } = IsTrimming;
    public string Namespace { get; } = Namespace;
    public string Name { get; } = Name;
    public string Summary { get; } = Summary;
    public EquatableArray<PropertyData> Properties { get; } = Properties;
    public Settings Settings { get; } = Settings;

    public static AnyOfData FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        var children = context.Children
            .Where(x => x.Hint == (context.IsAnyOf
                ? Hint.AnyOf
                : context.IsOneOf
                    ? Hint.OneOf
                    : Hint.AllOf))
            .ToList();
        var className = context.Id.ToClassName();
        TypeData? discriminatorType = null;
        string? discriminatorPropertyName = null;

        if (context.Schema.Discriminator != null &&
            context.Schema.Discriminator.Mapping.Count != 0)
        {
            discriminatorType = context.Children.FirstOrDefault(x => x.Hint == Hint.Discriminator)?.TypeData;
            discriminatorPropertyName = context.Schema.Discriminator.PropertyName.ToPropertyName()
                .ToCSharpName(context.Settings, context.Parent);
        }

        var count = context.IsAnyOf
            ? context.Schema.AnyOf.Count
            : context.IsOneOf
                ? context.Schema.OneOf.Count
                : context.Schema.AllOf.Count;
        var properties = context.IsNamedAnyOfLike
            ? children.Select((x, i) => PropertyData.Default with
            {
                Type = x.TypeData,
                Name = SmartNamedAnyOfNames.ComputePropertyName(children, className, i),
                Summary = x.Schema.GetSummary(),
                DiscriminatorValue = context.Schema.Discriminator?.Mapping?
                    .FirstOrDefault(y =>
                        y.Value.Contains(x.Id) ||
                        (x.Schema.Properties.ContainsKey(context.Schema.Discriminator.PropertyName) &&
                         x.Schema.Properties[context.Schema.Discriminator.PropertyName].Enum.Count == 1 &&
                         x.Schema.Properties[context.Schema.Discriminator.PropertyName].Enum.FirstOrDefault()
                             ?.GetString() == y.Key))
                    .Key?.ToEnumValue(string.Empty, context.Settings).Name ?? string.Empty,
            }).ToImmutableArray().AsEquatableArray()
            : Enumerable
                .Range(1, count)
                .Select(i => PropertyData.Default with
                {
                    Name = $"Value{i}",
                    Type = TypeData.Default with
                    {
                        CSharpTypeRaw = $"T{i}",
                    },
                })
                .ToImmutableArray().AsEquatableArray();
        if (context.IsNamedAnyOfLike &&
            !properties.IsEmpty &&
            properties.All(x => !string.IsNullOrWhiteSpace(x.DiscriminatorValue)))
        {
            properties = properties
                .Select(x => x with
                {
                    Name = x.DiscriminatorValue,
                })
                .ToImmutableArray().AsEquatableArray();
        }

        return new AnyOfData(
            SubType: context.IsAnyOf
                ? "AnyOf"
                : context.IsOneOf
                    ? "OneOf"
                    : "AllOf",
            Count: count,
            DiscriminatorType: discriminatorType,
            DiscriminatorPropertyName: discriminatorPropertyName,
            IsTrimming:
                context.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson &&
                (!string.IsNullOrWhiteSpace(context.Settings.JsonSerializerContext) ||
                 context.Settings.GenerateJsonSerializerContextTypes),
            Namespace: context.Settings.Namespace,
            Name: context.IsNamedAnyOfLike
                ? context.Id
                : string.Empty,
            Summary: context.IsNamedAnyOfLike
                ? context.Schema.GetSummary()
                : string.Empty,
            Properties: properties,
            Settings: context.Settings);
    }

    public override bool Equals(object obj)
    {
        if (obj is not AnyOfData other)
        {
            return false;
        }

        return SubType == other.SubType &&
               Count == other.Count &&
               DiscriminatorType.Equals(other.DiscriminatorType) &&
               DiscriminatorPropertyName == other.DiscriminatorPropertyName &&
               IsTrimming == other.IsTrimming &&
               Namespace == other.Namespace &&
               Name == other.Name &&
               Summary == other.Summary &&
               Properties.Equals(other.Properties) &&
               Settings.Equals(other.Settings);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (SubType?.GetHashCode() ?? 0);
            hash = hash * 23 + Count.GetHashCode();
            hash = hash * 23 + (DiscriminatorType?.GetHashCode() ?? 0);
            hash = hash * 23 + (DiscriminatorPropertyName?.GetHashCode() ?? 0);
            hash = hash * 23 + IsTrimming.GetHashCode();
            hash = hash * 23 + (Namespace?.GetHashCode() ?? 0);
            hash = hash * 23 + (Name?.GetHashCode() ?? 0);
            hash = hash * 23 + (Summary?.GetHashCode() ?? 0);
            hash = hash * 23 + Properties.GetHashCode();
            hash = hash * 23 + Settings.GetHashCode();
            return hash;
        }
    }

    bool IEquatable<AnyOfData>.Equals(AnyOfData other)
    {
        return this.Equals(other);
    }

    public static bool operator ==(AnyOfData left, AnyOfData right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(AnyOfData left, AnyOfData right)
    {
        return !(left == right);
    }
}