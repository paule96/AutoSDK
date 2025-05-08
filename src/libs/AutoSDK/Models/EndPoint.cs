using AutoSDK.Extensions;
using AutoSDK.Naming.Clients;
using AutoSDK.Serialization.Form;
using Microsoft.OpenApi.Models;
using System.Collections.Immutable;

namespace AutoSDK.Models;

public struct EndPoint(
    string Id,
    string Namespace,
    string ClassName,
    string BaseUrl,
    bool Stream,
    string Path,
    string RequestMediaType,
    EquatableArray<MethodParameter> Parameters,
    EndPointResponse SuccessResponse,
    EquatableArray<EndPointResponse> ErrorResponses,
    EquatableArray<Authorization> Authorizations,
    EquatableArray<MethodParameter> QueryParameters,
    OperationType HttpMethod,
    ContentType ContentType,
    string Summary,
    string BaseUrlSummary,
    Settings Settings,
    bool IsDeprecated,
    string ExperimentalStage,
    TypeData RequestType
) : IEquatable<EndPoint>
{
    public string MethodName => $"{NotAsyncMethodName}Async";
    public string NotAsyncMethodName => Id.ToPropertyName();
    public bool IsMultipartFormData => RequestMediaType == "multipart/form-data";

    public string FileNameWithoutExtension => $"{Namespace}.{ClassName}.{Id.ToPropertyName()}";

    public string InterfaceFileNameWithoutExtension => $"{Namespace}.I{ClassName}.{Id.ToPropertyName()}";

    public string Id { get; } = Id;
    public string Namespace { get; } = Namespace;
    public string ClassName { get; } = ClassName;
    public string BaseUrl { get; } = BaseUrl;
    public bool Stream { get; } = Stream;
    public string Path { get; } = Path;
    public string RequestMediaType { get; } = RequestMediaType;
    public EquatableArray<MethodParameter> Parameters { get; } = Parameters;
    public EndPointResponse SuccessResponse { get; } = SuccessResponse;
    public EquatableArray<EndPointResponse> ErrorResponses { get; } = ErrorResponses;
    public EquatableArray<Authorization> Authorizations { get; } = Authorizations;
    public EquatableArray<MethodParameter> QueryParameters { get; } = QueryParameters;
    public OperationType HttpMethod { get; } = HttpMethod;
    public ContentType ContentType { get; } = ContentType;
    public string Summary { get; } = Summary;
    public string BaseUrlSummary { get; } = BaseUrlSummary;
    public Settings Settings { get; } = Settings;
    public bool IsDeprecated { get; } = IsDeprecated;
    public string ExperimentalStage { get; } = ExperimentalStage;
    public TypeData RequestType { get; } = RequestType;

    public static EndPoint FromSchema(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var authorizations = operation.Operation.Security
            .SelectMany(x => x)
            .Select(x => Authorization.FromOpenApiSecurityScheme(x.Key, operation.Settings))
            .ToImmutableArray();
        if (authorizations.Length == 0)
        {
            authorizations = operation.GlobalSecurityRequirements
                .SelectMany(x => x)
                .Select(x => Authorization.FromOpenApiSecurityScheme(x.Key, operation.Settings))
                .ToImmutableArray();
        }

        var parameters = operation.Schemas
            .Where(x => x is { Hint: Hint.Parameter, ParameterData: not null })
            .Select(x => x.ParameterData!.Value)
            .ToList();

        // Ensure that parameters with the same name are unique
        var duplicateParameters = parameters
            .GroupBy(x => x.Name)
            .Where(x => x.Count() > 1)
            .Select(x => x.Key)
            .ToArray();
        foreach (var duplicateParameter in duplicateParameters)
        {
            var index = 1;
            for (var i = 0; i < parameters.Count; i++)
            {
                if (parameters[i].Name == duplicateParameter)
                {
                    parameters[i] = parameters[i] with
                    {
                        Name = $"{parameters[i].Name}{index++}",
                    };
                }
            }
        }

        var preparedPath = operation.OperationPath.PreparePath(parameters);
        var queryParameters = ParameterSerializer.SerializeQueryParameters(parameters);

        var requestMediaTypes =
            operation.Operation.RequestBody?.ResolveIfRequired().Content ??
            new Dictionary<string, OpenApiMediaType>();

        var requestContext = operation.Schemas.FirstOrDefault(x => x.Hint == Hint.Request);
        TypeData? requestType = requestContext?.TypeData;
        var requestMediaType = requestMediaTypes
            .Select(x => x.Key)
            .FirstOrDefault() ?? "application/json";
        if (requestType?.IsBase64 == true)
        {
            requestMediaType = "application/octet-stream";
        }

        var responses = (operation.Operation.Responses ?? [])
            .Select(x => EndPointResponse.FromResponse(x, operation))
            .ToArray();
        var contentType = responses
            .Any(x => x.MimeType.Contains("application/octet-stream"))
            ? ContentType.ByteArray
            : ContentType.String;

        foreach (var requestProperty in requestContext?.ResolvedReference?.ClassData?.Properties ??
                                        requestContext?.ClassData?.Properties ??
                                        [])
        {
            if (requestProperty.IsReadOnly)
            {
                continue;
            }

            parameters.Add(MethodParameter.Default with
            {
                Id = requestProperty.Id,
                Name = parameters.All(x => x.Name != requestProperty.Name)
                    ? requestProperty.Name
                    : $"request{requestProperty.Name.ToPropertyName()}",
                Type = requestProperty.Type with
                {
                    CSharpTypeNullability =
                        requestProperty.Type.IsNullable ||
                        (requestProperty.Type.CSharpTypeNullability && !requestProperty.IsRequired && !requestProperty.IsWriteOnly),
                },
                IsRequired = requestProperty.IsRequired || requestProperty.IsWriteOnly,
                IsMultiPartFormDataFilename = requestProperty.IsMultiPartFormDataFilename,
                DefaultValue = requestProperty.DefaultValue,
                IsDeprecated = requestProperty.IsDeprecated,
                Settings = requestProperty.Settings,
                Summary = requestProperty.Summary,
                ConverterType = requestProperty.ConverterType,
            });
        }

        var firstTag = (operation.Operation.Tags ?? []).FirstOrDefault();
        var endPoint = new EndPoint(
            Id: operation.MethodName,
            Namespace: operation.Settings.Namespace,
            ClassName: operation.Settings.GroupByTags && firstTag != null
                ? ClientNameGenerator.Generate(operation.Settings, firstTag)
                : operation.Settings.ClassName.Replace(".", string.Empty),
            BaseUrl: string.Empty,
            Stream: responses
                .Any(x => x.MimeType.Contains("application/x-ndjson")), // text/event-stream
            Path: preparedPath,
            RequestMediaType: requestMediaType,
            Parameters: parameters.ToImmutableArray(),
            SuccessResponse: responses.Any(x => x.Is2XX && !string.IsNullOrWhiteSpace(x.Type.CSharpTypeRaw))
                ? responses.First(x => x.Is2XX && !string.IsNullOrWhiteSpace(x.Type.CSharpTypeRaw))
                : responses.Any(x => x.Is2XX)
                    ? responses.First(x => x.Is2XX)
                    : responses.Any(x => x.IsDefault)
                        ? responses.First(x => x.IsDefault)
                        : EndPointResponse.Default,
            ErrorResponses: responses.Where(x => !x.Is2XX).ToImmutableArray(),
            QueryParameters: queryParameters.ToImmutableArray(),
            Authorizations: authorizations,
            HttpMethod: operation.OperationType,
            ContentType: contentType,
            Summary: operation.Operation.GetXmlDocumentationSummary(),
            BaseUrlSummary: string.Empty,
            Settings: operation.Settings,
            IsDeprecated: operation.Operation.Deprecated,
            ExperimentalStage: operation.Operation.GetExperimentalStage(),
            RequestType: requestType ?? TypeData.Default);

        return endPoint;
    }

    public override bool Equals(object obj)
    {
        if (obj is not EndPoint other)
        {
            return false;
        }

        return Id == other.Id &&
               Namespace == other.Namespace &&
               ClassName == other.ClassName &&
               BaseUrl == other.BaseUrl &&
               Stream == other.Stream &&
               Path == other.Path &&
               RequestMediaType == other.RequestMediaType &&
               Parameters.Equals(other.Parameters) &&
               SuccessResponse.Equals(other.SuccessResponse) &&
               ErrorResponses.Equals(other.ErrorResponses) &&
               Authorizations.Equals(other.Authorizations) &&
               QueryParameters.Equals(other.QueryParameters) &&
               HttpMethod == other.HttpMethod &&
               ContentType == other.ContentType &&
               Summary == other.Summary &&
               BaseUrlSummary == other.BaseUrlSummary &&
               Settings.Equals(other.Settings) &&
               IsDeprecated == other.IsDeprecated &&
               ExperimentalStage == other.ExperimentalStage &&
               RequestType.Equals(other.RequestType);
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
            hash = hash * 23 + Stream.GetHashCode();
            hash = hash * 23 + Path.GetHashCode();
            hash = hash * 23 + RequestMediaType.GetHashCode();
            hash = hash * 23 + Parameters.GetHashCode();
            hash = hash * 23 + SuccessResponse.GetHashCode();
            hash = hash * 23 + ErrorResponses.GetHashCode();
            hash = hash * 23 + Authorizations.GetHashCode();
            hash = hash * 23 + QueryParameters.GetHashCode();
            hash = hash * 23 + HttpMethod.GetHashCode();
            hash = hash * 23 + ContentType.GetHashCode();
            hash = hash * 23 + Summary.GetHashCode();
            hash = hash * 23 + BaseUrlSummary.GetHashCode();
            hash = hash * 23 + Settings.GetHashCode();
            hash = hash * 23 + IsDeprecated.GetHashCode();
            hash = hash * 23 + ExperimentalStage.GetHashCode();
            hash = hash * 23 + RequestType.GetHashCode();
            return hash;
        }
    }

    bool IEquatable<EndPoint>.Equals(EndPoint other)
    {
        return this.Equals(other);
    }

    public static bool operator ==(EndPoint left, EndPoint right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(EndPoint left, EndPoint right)
    {
        return !(left == right);
    }
}