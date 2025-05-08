using AutoSDK.Extensions;
using AutoSDK.Naming.Properties;
using AutoSDK.Serialization.Json;
using Microsoft.OpenApi.Models;
using System.Collections.Immutable;

namespace AutoSDK.Models;

public struct MethodParameter(
    string Id,
    string Name,
    string Value,
    string Delimiter,
    string Selector,
    TypeData Type,
    bool IsRequired,
    bool IsMultiPartFormDataFilename,
    ParameterLocation? Location,
    ParameterStyle? Style,
    bool Explode,
    Settings Settings,
    string? DefaultValue,
    bool IsDeprecated,
    string Summary,
    string ConverterType,
    ImmutableArray<PropertyData> Properties) : IEquatable<MethodParameter>
{
    public static MethodParameter Default => new(
        Id: string.Empty,
        Name: string.Empty,
        Value: string.Empty,
        Delimiter: string.Empty,
        Selector: string.Empty,
        Type: TypeData.Default,
        IsRequired: false,
        IsMultiPartFormDataFilename: false,
        Location: null,
        Style: null,
        Explode: false,
        DefaultValue: null,
        IsDeprecated: false,
        Settings: Settings.Default,
        Summary: string.Empty,
        ConverterType: string.Empty,
        Properties: []);

    public static MethodParameter FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var parameter = context.Parameter ?? throw new InvalidOperationException("Parameter or parameter data is required.");
        var parameterName = context.ParameterName ?? throw new InvalidOperationException("Property name or parameter name is required.");
        var type = context.TypeData;
        if (parameter.In == ParameterLocation.Query &&
            (context.IsClass || context.ResolvedReference?.IsClass == true) &&
            (context.ResolvedReference?.ClassData ?? context.ClassData)?.Properties.FirstOrDefault(x => x.Id == parameterName) is { } property &&
            property != default)
        {
            type = property.Type;
        }

        var name = parameterName.ToPropertyName();

        name = HandleWordSeparators(name);

        if (context.Parent != null)
        {
            name = name.FixPropertyName(context.Parent.Id);
        }

        name = CSharpPropertyNameGenerator.SanitizeName(name, context.Settings.ClsCompliantEnumPrefix, true);

        var isRequired =
            parameter.Required ||
            parameter.In == ParameterLocation.Path;
        // Special case for enums with a single value.
        // if (isRequired && type is { IsEnum: true, EnumValues.Length: 1 })
        // {
        //     isRequired = false;
        // }

        return new MethodParameter(
            Id: parameterName,
            Name: name,
            Value: string.Empty,
            Delimiter: string.Empty,
            Selector: string.Empty,
            Type: type,
            IsRequired: isRequired,
            IsMultiPartFormDataFilename: false,
            Location: parameter.In,
            Style: parameter.Style,
            Explode: parameter.Explode,
            Settings: context.Settings,
            IsDeprecated: context.Schema.Deprecated,
            DefaultValue: context.GetDefaultValue(),
            Summary: context.Schema.GetSummary(),
            ConverterType: type.ConverterType,
            Properties: context.ClassData?.Properties ?? []);
    }

    internal static string HandleWordSeparators(string name)
    {
        return name
            .ReplacePlusAndMinusOnStart()
            .UseWordSeparator('_', '+', '-', '.', '/', '(', '[', ']', ')');
    }

    public string ParameterName => Name
        .Replace(".", string.Empty)
        .ToParameterName()

        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/
        .ReplaceIfEquals("abstract", "@abstract")
        .ReplaceIfEquals("as", "@as")
        .ReplaceIfEquals("base", "@base")
        .ReplaceIfEquals("bool", "@bool")
        .ReplaceIfEquals("break", "@break")
        .ReplaceIfEquals("byte", "@byte")
        .ReplaceIfEquals("case", "@case")
        .ReplaceIfEquals("catch", "@catch")
        .ReplaceIfEquals("char", "@char")
        .ReplaceIfEquals("checked", "@checked")
        .ReplaceIfEquals("class", "@class")
        .ReplaceIfEquals("const", "@const")
        .ReplaceIfEquals("continue", "@continue")
        .ReplaceIfEquals("decimal", "@decimal")
        .ReplaceIfEquals("default", "@default")
        .ReplaceIfEquals("delegate", "@delegate")
        .ReplaceIfEquals("do", "@do")
        .ReplaceIfEquals("double", "@double")
        .ReplaceIfEquals("else", "@else")
        .ReplaceIfEquals("enum", "@enum")
        .ReplaceIfEquals("event", "@event")
        .ReplaceIfEquals("explicit", "@explicit")
        .ReplaceIfEquals("extern", "@extern")
        .ReplaceIfEquals("false", "@false")
        .ReplaceIfEquals("finally", "@finally")
        .ReplaceIfEquals("fixed", "@fixed")
        .ReplaceIfEquals("float", "@float")
        .ReplaceIfEquals("for", "@for")
        .ReplaceIfEquals("foreach", "@foreach")
        .ReplaceIfEquals("goto", "@goto")
        .ReplaceIfEquals("if", "@if")
        .ReplaceIfEquals("implicit", "@implicit")
        .ReplaceIfEquals("in", "@in")
        .ReplaceIfEquals("int", "@int")
        .ReplaceIfEquals("interface", "@interface")
        .ReplaceIfEquals("internal", "@internal")
        .ReplaceIfEquals("is", "@is")
        .ReplaceIfEquals("lock", "@lock")
        .ReplaceIfEquals("long", "@long")
        .ReplaceIfEquals("namespace", "@namespace")
        .ReplaceIfEquals("new", "@new")
        .ReplaceIfEquals("null", "@null")
        .ReplaceIfEquals("object", "@object")
        .ReplaceIfEquals("operator", "@operator")
        .ReplaceIfEquals("out", "@out")
        .ReplaceIfEquals("override", "@override")
        .ReplaceIfEquals("params", "@params")
        .ReplaceIfEquals("private", "@private")
        .ReplaceIfEquals("protected", "@protected")
        .ReplaceIfEquals("public", "@public")
        .ReplaceIfEquals("readonly", "@readonly")
        .ReplaceIfEquals("ref", "@ref")
        .ReplaceIfEquals("return", "@return")
        .ReplaceIfEquals("sbyte", "@sbyte")
        .ReplaceIfEquals("sealed", "@sealed")
        .ReplaceIfEquals("short", "@short")
        .ReplaceIfEquals("sizeof", "@sizeof")
        .ReplaceIfEquals("stackalloc", "@stackalloc")
        .ReplaceIfEquals("static", "@static")
        .ReplaceIfEquals("string", "@string")
        .ReplaceIfEquals("struct", "@struct")
        .ReplaceIfEquals("switch", "@switch")
        .ReplaceIfEquals("this", "@this")
        .ReplaceIfEquals("throw", "@throw")
        .ReplaceIfEquals("true", "@true")
        .ReplaceIfEquals("try", "@try")
        .ReplaceIfEquals("typeof", "@typeof")
        .ReplaceIfEquals("uint", "@uint")
        .ReplaceIfEquals("ulong", "@ulong")
        .ReplaceIfEquals("unchecked", "@unchecked")
        .ReplaceIfEquals("unsafe", "@unsafe")
        .ReplaceIfEquals("ushort", "@ushort")
        .ReplaceIfEquals("using", "@using")
        .ReplaceIfEquals("virtual", "@virtual")
        .ReplaceIfEquals("void", "@void")
        .ReplaceIfEquals("volatile", "@volatile")
        .ReplaceIfEquals("while", "@while");

    public string ArgumentName
    {
        get
        {
            if (Type.EnumValues.Length != 0 && Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
            {
                return ParameterName + "Value";
            }

            return ParameterName;
        }
    }

    public string ParameterDefaultValue =>
        DefaultValue == null || string.IsNullOrWhiteSpace(DefaultValue) || Type.IsAnyOfLike
        ? "default"
        : DefaultValue;

    public string Id { get; set; } = Id;
    public string Name { get; set; } = Name;
    public string Value { get; set; } = Value;
    public string Delimiter { get; set; } = Delimiter;
    public string Selector { get; set; } = Selector;
    public TypeData Type { get; set; } = Type;
    public bool IsRequired { get; set; } = IsRequired;
    public bool IsMultiPartFormDataFilename { get; set; } = IsMultiPartFormDataFilename;
    public ParameterLocation? Location { get; } = Location;
    public ParameterStyle? Style { get; } = Style;
    public bool Explode { get; set; } = Explode;
    public Settings Settings { get; set; } = Settings;
    public string? DefaultValue { get; set; } = DefaultValue;
    public bool IsDeprecated { get; set; } = IsDeprecated;
    public string Summary { get; set; } = Summary;
    public string ConverterType { get; set; } = ConverterType;
    public ImmutableArray<PropertyData> Properties { get; } = Properties;

    public override bool Equals(object obj)
    {
        if (obj is not MethodParameter other)
        {
            return false;
        }

        return Id == other.Id &&
               Name == other.Name &&
               Value == other.Value &&
               Delimiter == other.Delimiter &&
               Selector == other.Selector &&
               Type.Equals(other.Type) &&
               IsRequired == other.IsRequired &&
               IsMultiPartFormDataFilename == other.IsMultiPartFormDataFilename &&
               Location == other.Location &&
               Style == other.Style &&
               Explode == other.Explode &&
               Settings.Equals(other.Settings) &&
               DefaultValue == other.DefaultValue &&
               IsDeprecated == other.IsDeprecated &&
               Summary == other.Summary &&
               ConverterType == other.ConverterType &&
               Properties.SequenceEqual(other.Properties);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Id.GetHashCode();
            hash = hash * 23 + Name.GetHashCode();
            hash = hash * 23 + Value.GetHashCode();
            hash = hash * 23 + Delimiter.GetHashCode();
            hash = hash * 23 + Selector.GetHashCode();
            hash = hash * 23 + Type.GetHashCode();
            hash = hash * 23 + IsRequired.GetHashCode();
            hash = hash * 23 + IsMultiPartFormDataFilename.GetHashCode();
            hash = hash * 23 + Location.GetHashCode();
            hash = hash * 23 + Style.GetHashCode();
            hash = hash * 23 + Explode.GetHashCode();
            hash = hash * 23 + Settings.GetHashCode();
            hash = hash * 23 + (DefaultValue?.GetHashCode() ?? 0);
            hash = hash * 23 + IsDeprecated.GetHashCode();
            hash = hash * 23 + Summary.GetHashCode();
            hash = hash * 23 + ConverterType.GetHashCode();
            foreach (var property in Properties)
            {
                hash = hash * 23 + property.GetHashCode();
            }
            return hash;
        }
    }

    bool IEquatable<MethodParameter>.Equals(MethodParameter other)
    {
        return this.Equals(other);
    }

    public static bool operator ==(MethodParameter left, MethodParameter right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(MethodParameter left, MethodParameter right)
    {
        return !(left == right);
    }
}