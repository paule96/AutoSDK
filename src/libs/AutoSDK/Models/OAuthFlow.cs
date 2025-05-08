using Microsoft.OpenApi.Models;
using System.Collections.Immutable;

namespace AutoSDK.Models;

public struct OAuthFlow(
    string Type,
    string AuthorizationUrl,
    string TokenUrl,
    string RefreshUrl,
    EquatableArray<string> Scopes
) : IEquatable<OAuthFlow>
{
    public string Type { get; } = Type;
    public string AuthorizationUrl { get; } = AuthorizationUrl;
    public string TokenUrl { get; } = TokenUrl;
    public string RefreshUrl { get; } = RefreshUrl;
    public EquatableArray<string> Scopes { get; } = Scopes;

    public static OAuthFlow FromOpenApiSecurityScheme(
        string type,
        OpenApiOAuthFlow flow,
        Settings settings)
    {
        type = type ?? throw new ArgumentNullException(nameof(type));
        flow = flow ?? throw new ArgumentNullException(nameof(flow));

        return new OAuthFlow(
            Type: type,
            AuthorizationUrl: flow.AuthorizationUrl?.ToString() ?? string.Empty,
            TokenUrl: flow.TokenUrl?.ToString() ?? string.Empty,
            RefreshUrl: flow.RefreshUrl?.ToString() ?? string.Empty,
            Scopes: (flow.Scopes?.Select(x => x.Key).ToArray() ?? [])
                .ToImmutableArray()
                .AsEquatableArray());
    }

    public override bool Equals(object? obj)
    {
        if (obj is OAuthFlow other)
        {
            return Type == other.Type &&
                   AuthorizationUrl == other.AuthorizationUrl &&
                   TokenUrl == other.TokenUrl &&
                   RefreshUrl == other.RefreshUrl &&
                   Scopes.Equals(other.Scopes);
        }
        return false;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Type.GetHashCode();
            hash = hash * 23 + AuthorizationUrl.GetHashCode();
            hash = hash * 23 + TokenUrl.GetHashCode();
            hash = hash * 23 + RefreshUrl.GetHashCode();
            hash = hash * 23 + Scopes.GetHashCode();
            return hash;
        }
    }

    bool IEquatable<OAuthFlow>.Equals(OAuthFlow other)
    {
        return this.Equals(other);
    }

    public static bool operator ==(OAuthFlow left, OAuthFlow right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(OAuthFlow left, OAuthFlow right)
    {
        return !(left == right);
    }
}