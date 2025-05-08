using AutoSDK.Extensions;
using Microsoft.OpenApi.Models;
using System.Collections.Immutable;

namespace AutoSDK.Models;

public struct Authorization(
    string FriendlyName,
    SecuritySchemeType Type,
    ParameterLocation In,
    EquatableArray<string> Parameters,
    string Name,
    string Scheme,
    Settings Settings,
    EquatableArray<OAuthFlow> Flows,
    string OpenIdConnectUrl
) : IEquatable<Authorization>
{
    public string MethodName => $"AuthorizeUsing{FriendlyName}";

    public string FriendlyName { get; } = FriendlyName;
    public SecuritySchemeType Type { get; } = Type;
    public ParameterLocation In { get; } = In;
    public EquatableArray<string> Parameters { get; } = Parameters;
    public string Name { get; } = Name;
    public string Scheme { get; } = Scheme;
    public Settings Settings { get; } = Settings;
    public EquatableArray<OAuthFlow> Flows { get; } = Flows;
    public string OpenIdConnectUrl { get; } = OpenIdConnectUrl;

    public static Authorization FromOpenApiSecurityScheme(
        OpenApiSecurityScheme scheme,
        Settings settings)
    {
        scheme = scheme ?? throw new ArgumentNullException(nameof(scheme));

        var friendlyName = (scheme.Type, scheme.Scheme?.ToUpperInvariant(), scheme.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => "Bearer",
            (SecuritySchemeType.Http, "BASIC", _) => "Basic",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => "ApiKeyInHeader",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Query) => "ApiKeyInQuery",
            (SecuritySchemeType.OAuth2, _, _) => "OAuth2",
            _ => scheme.Scheme?.ToPropertyName() ?? string.Empty,
        };
        string[] parameters = (scheme.Type, scheme.Scheme?.ToUpperInvariant(), scheme.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => ["apiKey"],
            (SecuritySchemeType.Http, "BASIC", _) => ["username", "password"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => ["apiKey"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Query) => ["apiKey"],
            _ => [],
        };

        return new Authorization(
            FriendlyName: friendlyName,
            Type: scheme.Type,
            In: (scheme.Type, scheme.Scheme?.ToUpperInvariant()) switch
            {
                (SecuritySchemeType.Http, "BEARER") => ParameterLocation.Header,
                (SecuritySchemeType.OAuth2, _) => ParameterLocation.Header,
                _ => scheme.In,
            },
            Parameters: parameters.ToImmutableArray().AsEquatableArray(),
            Name: scheme.Name ?? string.Empty,
            Scheme: scheme.Scheme ?? string.Empty,
            Settings: settings,
            Flows: new[]
                {
                    scheme.Flows?.Implicit != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.Implicit), scheme.Flows.Implicit!, settings)
                        : (OAuthFlow?)null,
                    scheme.Flows?.Password != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.Password), scheme.Flows.Password!, settings)
                        : null,
                    scheme.Flows?.ClientCredentials != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.ClientCredentials), scheme.Flows.ClientCredentials!, settings)
                        : null,
                    scheme.Flows?.AuthorizationCode != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.AuthorizationCode), scheme.Flows.AuthorizationCode!, settings)
                        : null,
                }
                .Where(x => x != null)
                .Select(x => x!.Value)
                .ToImmutableArray()
                .AsEquatableArray(),
            OpenIdConnectUrl: scheme.OpenIdConnectUrl?.ToString() ?? string.Empty);
    }

    public override bool Equals(object obj)
    {
        if (obj is not Authorization other)
        {
            return false;
        }

        return FriendlyName == other.FriendlyName &&
               Type == other.Type &&
               In == other.In &&
               Parameters.Equals(other.Parameters) &&
               Name == other.Name &&
               Scheme == other.Scheme &&
               Settings.Equals(other.Settings) &&
               Flows.Equals(other.Flows) &&
               OpenIdConnectUrl == other.OpenIdConnectUrl;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + FriendlyName.GetHashCode();
            hash = hash * 23 + Type.GetHashCode();
            hash = hash * 23 + In.GetHashCode();
            hash = hash * 23 + Parameters.GetHashCode();
            hash = hash * 23 + Name.GetHashCode();
            hash = hash * 23 + Scheme.GetHashCode();
            hash = hash * 23 + Settings.GetHashCode();
            hash = hash * 23 + Flows.GetHashCode();
            hash = hash * 23 + OpenIdConnectUrl.GetHashCode();
            return hash;
        }
    }

    bool IEquatable<Authorization>.Equals(Authorization other)
    {
        return this.Equals(other);
    }

    public static bool operator ==(Authorization left, Authorization right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Authorization left, Authorization right)
    {
        return !(left == right);
    }
}