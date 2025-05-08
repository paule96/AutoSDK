using AutoSDK.Naming.Methods;
using AutoSDK.Serialization.Json;
using System.Collections.Immutable;

namespace AutoSDK.Models;

public struct Settings(
    string TargetFramework,
    string Namespace,
    string ClassName,
    string ClsCompliantEnumPrefix,
    NamingConvention NamingConvention,
    JsonSerializerType JsonSerializerType,
    SdkFeatureUsage UseRequiredKeyword,
    SdkFeatureUsage UseExperimentalAttributes,
    SdkFeatureUsage UseSetsRequiredMembersAttributes,

    bool GenerateConstructors,
    bool GroupByTags,
    bool GenerateMethods,
    MethodNamingConvention MethodNamingConvention,
    MethodNamingConvention MethodNamingConventionFallback,
    bool GenerateMethodsAsHttpClientExtensions,
    bool GenerateMethodsUsingSystemNetHttpJson,
    ImmutableArray<string> IncludeOperationIds,
    ImmutableArray<string> ExcludeOperationIds,
    ImmutableArray<string> IncludeTags,
    ImmutableArray<string> ExcludeTags,
    bool ExcludeDeprecatedOperations,
    string JsonSerializerContext,
    bool GenerateJsonSerializerContextTypes,
    bool ComputeDiscriminators,
    bool AddMissingPathParameters,

    bool GenerateModels,
    bool GenerateModelValidationMethods,
    bool ValidateAnyOfs,
    ModelStyle ModelStyle,
    ImmutableArray<string> IncludeModels,
    ImmutableArray<string> ExcludeModels,

    bool IgnoreOpenApiErrors,
    bool IgnoreOpenApiWarnings,

    bool GeneratePolyfills,
    bool GenerateExceptions,

    bool GenerateSdk,
    bool FromCli)
{
    public static Settings Default => new(
        TargetFramework: "net8.0",
        Namespace: string.Empty,
        ClassName: string.Empty,
        ClsCompliantEnumPrefix: string.Empty,
        NamingConvention: default,
        JsonSerializerType: default,
        UseRequiredKeyword: default,
        UseExperimentalAttributes: default,
        UseSetsRequiredMembersAttributes: default,
        GenerateConstructors: false,
        GroupByTags: true,
        GenerateMethods: false,
        MethodNamingConvention: default,
        MethodNamingConventionFallback: MethodNamingConvention.MethodAndPath,
        GenerateMethodsAsHttpClientExtensions: false,
        GenerateMethodsUsingSystemNetHttpJson: false,
        IncludeOperationIds: ImmutableArray<string>.Empty,
        ExcludeOperationIds: ImmutableArray<string>.Empty,
        IncludeTags: ImmutableArray<string>.Empty,
        ExcludeTags: ImmutableArray<string>.Empty,
        ExcludeDeprecatedOperations: false,
        JsonSerializerContext: string.Empty,
        GenerateJsonSerializerContextTypes: false,
        ComputeDiscriminators: false,
        AddMissingPathParameters: true,
        GenerateModels: false,
        GenerateModelValidationMethods: false,
        ValidateAnyOfs: false,
        ModelStyle: default,
        IncludeModels: ImmutableArray<string>.Empty,
        ExcludeModels: ImmutableArray<string>.Empty,
        IgnoreOpenApiErrors: false,
        IgnoreOpenApiWarnings: true,
        GeneratePolyfills: true,
        GenerateExceptions: true,
        GenerateSdk: true,
        FromCli: false
    );

    public string TargetFramework { get; } = TargetFramework;
    public string Namespace { get; } = Namespace;
    public string ClassName { get; } = ClassName;
    public string ClsCompliantEnumPrefix { get; } = ClsCompliantEnumPrefix;
    public NamingConvention NamingConvention { get; } = NamingConvention;
    public JsonSerializerType JsonSerializerType { get; } = JsonSerializerType;
    public SdkFeatureUsage UseRequiredKeyword { get; } = UseRequiredKeyword;
    public SdkFeatureUsage UseExperimentalAttributes { get; } = UseExperimentalAttributes;
    public SdkFeatureUsage UseSetsRequiredMembersAttributes { get; } = UseSetsRequiredMembersAttributes;
    public bool GenerateConstructors { get; } = GenerateConstructors;
    public bool GroupByTags { get; set; } = GroupByTags;
    public bool GenerateMethods { get; } = GenerateMethods;
    public MethodNamingConvention MethodNamingConvention { get; } = MethodNamingConvention;
    public MethodNamingConvention MethodNamingConventionFallback { get; } = MethodNamingConventionFallback;
    public bool GenerateMethodsAsHttpClientExtensions { get; } = GenerateMethodsAsHttpClientExtensions;
    public bool GenerateMethodsUsingSystemNetHttpJson { get; } = GenerateMethodsUsingSystemNetHttpJson;
    public ImmutableArray<string> IncludeOperationIds { get; } = IncludeOperationIds;
    public ImmutableArray<string> ExcludeOperationIds { get; } = ExcludeOperationIds;
    public ImmutableArray<string> IncludeTags { get; } = IncludeTags;
    public ImmutableArray<string> ExcludeTags { get; } = ExcludeTags;
    public bool ExcludeDeprecatedOperations { get; } = ExcludeDeprecatedOperations;
    public string JsonSerializerContext { get; } = JsonSerializerContext;
    public bool GenerateJsonSerializerContextTypes { get; } = GenerateJsonSerializerContextTypes;
    public bool ComputeDiscriminators { get; } = ComputeDiscriminators;
    public bool AddMissingPathParameters { get; } = AddMissingPathParameters;
    public bool GenerateModels { get; } = GenerateModels;
    public bool GenerateModelValidationMethods { get; } = GenerateModelValidationMethods;
    public bool ValidateAnyOfs { get; } = ValidateAnyOfs;
    public ModelStyle ModelStyle { get; } = ModelStyle;
    public ImmutableArray<string> IncludeModels { get; } = IncludeModels;
    public ImmutableArray<string> ExcludeModels { get; } = ExcludeModels;
    public bool IgnoreOpenApiErrors { get; } = IgnoreOpenApiErrors;
    public bool IgnoreOpenApiWarnings { get; } = IgnoreOpenApiWarnings;
    public bool GeneratePolyfills { get; } = GeneratePolyfills;
    public bool GenerateExceptions { get; } = GenerateExceptions;
    public bool GenerateSdk { get; } = GenerateSdk;
    public bool FromCli { get; } = FromCli;

    public override bool Equals(object? obj)
    {
        if (obj is not Settings other)
        {
            return false;
        }

        return TargetFramework == other.TargetFramework &&
               Namespace == other.Namespace &&
               ClassName == other.ClassName &&
               ClsCompliantEnumPrefix == other.ClsCompliantEnumPrefix &&
               NamingConvention.Equals(other.NamingConvention) &&
               JsonSerializerType.Equals(other.JsonSerializerType) &&
               UseRequiredKeyword.Equals(other.UseRequiredKeyword) &&
               UseExperimentalAttributes.Equals(other.UseExperimentalAttributes) &&
               UseSetsRequiredMembersAttributes.Equals(other.UseSetsRequiredMembersAttributes) &&
               GenerateConstructors == other.GenerateConstructors &&
               GroupByTags == other.GroupByTags &&
               GenerateMethods == other.GenerateMethods &&
               MethodNamingConvention.Equals(other.MethodNamingConvention) &&
               MethodNamingConventionFallback.Equals(other.MethodNamingConventionFallback) &&
               GenerateMethodsAsHttpClientExtensions == other.GenerateMethodsAsHttpClientExtensions &&
               GenerateMethodsUsingSystemNetHttpJson == other.GenerateMethodsUsingSystemNetHttpJson &&
               IncludeOperationIds.SequenceEqual(other.IncludeOperationIds) &&
               ExcludeOperationIds.SequenceEqual(other.ExcludeOperationIds) &&
               IncludeTags.SequenceEqual(other.IncludeTags) &&
               ExcludeTags.SequenceEqual(other.ExcludeTags) &&
               ExcludeDeprecatedOperations == other.ExcludeDeprecatedOperations &&
               JsonSerializerContext == other.JsonSerializerContext &&
               GenerateJsonSerializerContextTypes == other.GenerateJsonSerializerContextTypes &&
               ComputeDiscriminators == other.ComputeDiscriminators &&
               AddMissingPathParameters == other.AddMissingPathParameters &&
               GenerateModels == other.GenerateModels &&
               GenerateModelValidationMethods == other.GenerateModelValidationMethods &&
               ValidateAnyOfs == other.ValidateAnyOfs &&
               ModelStyle.Equals(other.ModelStyle) &&
               IncludeModels.SequenceEqual(other.IncludeModels) &&
               ExcludeModels.SequenceEqual(other.ExcludeModels) &&
               IgnoreOpenApiErrors == other.IgnoreOpenApiErrors &&
               IgnoreOpenApiWarnings == other.IgnoreOpenApiWarnings &&
               GeneratePolyfills == other.GeneratePolyfills &&
               GenerateExceptions == other.GenerateExceptions &&
               GenerateSdk == other.GenerateSdk &&
               FromCli == other.FromCli;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (TargetFramework?.GetHashCode() ?? 0);
            hash = hash * 23 + (Namespace?.GetHashCode() ?? 0);
            hash = hash * 23 + (ClassName?.GetHashCode() ?? 0);
            hash = hash * 23 + (ClsCompliantEnumPrefix?.GetHashCode() ?? 0);
            hash = hash * 23 + NamingConvention.GetHashCode();
            hash = hash * 23 + JsonSerializerType.GetHashCode();
            hash = hash * 23 + UseRequiredKeyword.GetHashCode();
            hash = hash * 23 + UseExperimentalAttributes.GetHashCode();
            hash = hash * 23 + UseSetsRequiredMembersAttributes.GetHashCode();
            hash = hash * 23 + GenerateConstructors.GetHashCode();
            hash = hash * 23 + GroupByTags.GetHashCode();
            hash = hash * 23 + GenerateMethods.GetHashCode();
            hash = hash * 23 + MethodNamingConvention.GetHashCode();
            hash = hash * 23 + MethodNamingConventionFallback.GetHashCode();
            hash = hash * 23 + GenerateMethodsAsHttpClientExtensions.GetHashCode();
            hash = hash * 23 + GenerateMethodsUsingSystemNetHttpJson.GetHashCode();
            foreach (var id in IncludeOperationIds)
            {
                hash = hash * 23 + id.GetHashCode();
            }
            foreach (var id in ExcludeOperationIds)
            {
                hash = hash * 23 + id.GetHashCode();
            }
            foreach (var tag in IncludeTags)
            {
                hash = hash * 23 + tag.GetHashCode();
            }
            foreach (var tag in ExcludeTags)
            {
                hash = hash * 23 + tag.GetHashCode();
            }
            hash = hash * 23 + ExcludeDeprecatedOperations.GetHashCode();
            hash = hash * 23 + (JsonSerializerContext?.GetHashCode() ?? 0);
            hash = hash * 23 + GenerateJsonSerializerContextTypes.GetHashCode();
            hash = hash * 23 + ComputeDiscriminators.GetHashCode();
            hash = hash * 23 + AddMissingPathParameters.GetHashCode();
            hash = hash * 23 + GenerateModels.GetHashCode();
            hash = hash * 23 + GenerateModelValidationMethods.GetHashCode();
            hash = hash * 23 + ValidateAnyOfs.GetHashCode();
            hash = hash * 23 + ModelStyle.GetHashCode();
            foreach (var model in IncludeModels)
            {
                hash = hash * 23 + model.GetHashCode();
            }
            foreach (var model in ExcludeModels)
            {
                hash = hash * 23 + model.GetHashCode();
            }
            hash = hash * 23 + IgnoreOpenApiErrors.GetHashCode();
            hash = hash * 23 + IgnoreOpenApiWarnings.GetHashCode();
            hash = hash * 23 + GeneratePolyfills.GetHashCode();
            hash = hash * 23 + GenerateExceptions.GetHashCode();
            hash = hash * 23 + GenerateSdk.GetHashCode();
            hash = hash * 23 + FromCli.GetHashCode();
            return hash;
        }
    }

    public static bool operator ==(Settings left, Settings right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Settings left, Settings right)
    {
        return !(left == right);
    }
}