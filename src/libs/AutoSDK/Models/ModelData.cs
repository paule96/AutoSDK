using AutoSDK.Extensions;
using System.Collections.Immutable;

namespace AutoSDK.Models;

public struct ModelData(
    SchemaContext SchemaContext,
    string Id,
    ImmutableArray<ModelData> Parents,
    string Namespace,
    Settings Settings,
    ModelStyle Style,
    ImmutableArray<PropertyData> Properties,
    ImmutableArray<PropertyData> EnumValues,
    string Summary,
    bool IsDeprecated,
    string BaseClass,
    bool IsBaseClass,
    bool IsDerivedClass,
    string DiscriminatorPropertyName,
    EquatableArray<(string ClassName, string Discriminator)> DerivedTypes
) : IEquatable<ModelData>
{
    public static ModelData FromSchemaContext(
        SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        var parents = new List<ModelData>();
        var parent = context.Parent;
        while (parent != null)
        {
            if (parent.ClassData.HasValue)
            {
                parents.Add(parent.ClassData!.Value);
            }
            parent = parent.Parent;
        }

        parents.Reverse();

        return new ModelData(
            SchemaContext: context,
            Id: context.Id,
            Parents: parents.ToImmutableArray(),
            Namespace: context.Settings.Namespace,
            Style: context.Schema.IsEnum() ? ModelStyle.Enumeration : context.Settings.ModelStyle,
            Settings: context.Settings,
            Properties: context.IsDerivedClass
                ? context.DerivedClassContext.Children
                    .Where(x => x is { IsProperty: true, PropertyData: not null })
                    .SelectMany(x => x.ComputedProperties)
                    .ToImmutableArray()
                : !context.Schema.IsEnum()
                    ? context.Children
                        .Where(x => x is { IsProperty: true, PropertyData: not null })
                        .SelectMany(x => x.ComputedProperties)
                        .ToImmutableArray()
                    : [],
            EnumValues: context.Schema.IsEnum()
                ? context.ComputeEnum().Values.ToImmutableArray()
                : [],
            Summary: context.Schema.GetSummary(),
            IsDeprecated: context.Schema.Deprecated,
            BaseClass: context.IsDerivedClass
                ? context.BaseClassContext.Id
                : string.Empty,
            IsBaseClass: context.IsBaseClass,
            IsDerivedClass: context.IsDerivedClass,
            DiscriminatorPropertyName: context.Schema.Discriminator?.PropertyName ?? string.Empty,
            DerivedTypes: context.Schema.Discriminator?.Mapping?
                .Select(x => (ClassName: x.Value.Replace("#/components/schemas/", string.Empty), Discriminator: x.Key))
                .ToImmutableArray() ?? []
            );
    }

    public bool Equals(ModelData other)
    {
        return Id == other.Id &&
               Namespace == other.Namespace &&
               Settings.Equals(other.Settings) &&
               Style == other.Style &&
               IsDeprecated == other.IsDeprecated &&
               BaseClass == other.BaseClass &&
               IsBaseClass == other.IsBaseClass &&
               IsDerivedClass == other.IsDerivedClass &&
               DiscriminatorPropertyName == other.DiscriminatorPropertyName &&
               DerivedTypes.SequenceEqual(other.DerivedTypes);
    }

    public string ClassName => Id;// Settings.NamingConvention switch
    // {
    //     NamingConvention.ConcatNames => Parents.IsEmpty ? Name : $"{Parents.Last().ClassName}{Name}",
    //     
    //     _ => string.Empty,
    // };

    public string GlobalClassName => $"global::{Namespace}.{ClassName}";

    public string ExternalClassName => Settings.NamingConvention switch
    {
        NamingConvention.ConcatNames => ClassName,
        NamingConvention.InnerClasses => string.Join(".", Parents.Select(x => x.ClassName).Concat([ClassName])),
        _ => string.Empty,
    };

    public string FileNameWithoutExtension => $"{Namespace}.Models.{ExternalClassName}";

    public SchemaContext SchemaContext { get; set; } = SchemaContext;
    public string Id { get; } = Id;
    public ImmutableArray<ModelData> Parents { get; } = Parents;
    public string Namespace { get; } = Namespace;
    public Settings Settings { get; } = Settings;
    public ModelStyle Style { get; } = Style;
    public ImmutableArray<PropertyData> Properties { get; } = Properties;
    public ImmutableArray<PropertyData> EnumValues { get; } = EnumValues;
    public string Summary { get; } = Summary;
    public bool IsDeprecated { get; } = IsDeprecated;
    public string BaseClass { get; } = BaseClass;
    public bool IsBaseClass { get; } = IsBaseClass;
    public bool IsDerivedClass { get; } = IsDerivedClass;
    public string DiscriminatorPropertyName { get; } = DiscriminatorPropertyName;
    public EquatableArray<(string ClassName, string Discriminator)> DerivedTypes { get; } = DerivedTypes;
}