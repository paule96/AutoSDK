using AutoSDK.Extensions;
using Microsoft.OpenApi.Models;

namespace AutoSDK.Models;

public struct EndPointResponse(
    string StatusCode,
    string Description,
    string MimeType,
    ContentType ContentType,
    TypeData Type
) : IEquatable<EndPointResponse>
{
    public bool Is1XX => StatusCode.StartsWith("1", StringComparison.OrdinalIgnoreCase);
    public bool Is2XX => StatusCode.StartsWith("2", StringComparison.OrdinalIgnoreCase);
    public bool Is3XX => StatusCode.StartsWith("3", StringComparison.OrdinalIgnoreCase);
    public bool Is4XX => StatusCode.StartsWith("4", StringComparison.OrdinalIgnoreCase);
    public bool Is5XX => StatusCode.StartsWith("5", StringComparison.OrdinalIgnoreCase);
    public bool IsDefault => StatusCode == "default";
    public bool IsPattern => StatusCode.Contains("XX");
    public int Min => int.TryParse(StatusCode.Replace("XX", "00"), out var code) ? code : 0;
    public int Max => int.TryParse(StatusCode.Replace("XX", "99"), out var code) ? code : 0;

    public static EndPointResponse Default => new(
        StatusCode: "200",
        Description: string.Empty,
        MimeType: string.Empty,
        ContentType: ContentType.String,
        Type: TypeData.Default);

    public string StatusCode { get; set; } = StatusCode;
    public string Description { get; } = Description;
    public string MimeType { get; } = MimeType;
    public ContentType ContentType { get; } = ContentType;
    public TypeData Type { get; } = Type;

    public static EndPointResponse FromResponse(KeyValuePair<string, OpenApiResponse> responseWithStatusCode, OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var responses = responseWithStatusCode.Value?.ResolveIfRequired().Content?
            .Select(x => (
                StatusCode: responseWithStatusCode.Key,
                Response: responseWithStatusCode.Value,
                MimeType: x.Key,
                MediaType: x.Value))
            .ToArray() ?? [];
        if (responses.Length == 0)
        {
            return Default with
            {
                StatusCode = responseWithStatusCode.Key,
            };
        }

        var response = responses.First();

        var contentType = response.MimeType.Contains("application/octet-stream")
            ? ContentType.ByteArray
            : ContentType.String;
        var responseContext = operation.Schemas.FirstOrDefault(x => x.Hint == Hint.Response && x.ResponseStatusCode == response.StatusCode);
        TypeData? responseType = contentType switch
        {
            ContentType.ByteArray => TypeData.Default with
            {
                CSharpTypeRaw = "byte[]",
            },
            _ => responseContext?.TypeData,
        };
        if (responseType?.CSharpTypeWithoutNullability == "object")
        {
            contentType = ContentType.String;
            responseType = TypeData.Default with
            {
                CSharpTypeRaw = "string",
                IsNullable = true,
            };
        }

        var endPoint = new EndPointResponse(
            StatusCode: responseWithStatusCode.Key,
            Description: response.Response.Description,
            MimeType: response.MimeType,
            ContentType: contentType,
            Type: responseType ?? TypeData.Default);

        return endPoint;
    }

    public override bool Equals(object obj)
    {
        if (obj is not EndPointResponse other)
        {
            return false;
        }

        return StatusCode == other.StatusCode &&
               Description == other.Description &&
               MimeType == other.MimeType &&
               ContentType == other.ContentType &&
               Type.Equals(other.Type);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + StatusCode.GetHashCode();
            hash = hash * 23 + Description.GetHashCode();
            hash = hash * 23 + MimeType.GetHashCode();
            hash = hash * 23 + ContentType.GetHashCode();
            hash = hash * 23 + Type.GetHashCode();
            return hash;
        }
    }

    bool IEquatable<EndPointResponse>.Equals(EndPointResponse other)
    {
        return this.Equals(other);
    }

    public static bool operator ==(EndPointResponse left, EndPointResponse right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(EndPointResponse left, EndPointResponse right)
    {
        return !(left == right);
    }
}