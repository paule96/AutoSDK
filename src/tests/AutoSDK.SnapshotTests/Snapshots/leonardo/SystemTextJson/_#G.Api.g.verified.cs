﻿//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Leonardo.Ai API OpenAPI specification.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Leonardo.Ai API server
        /// </summary>
        public const string DefaultBaseUrl = "https://cloud.leonardo.ai/api/rest/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.SdVersionsJsonConverter(),
                    new global::G.JsonConverters.SdVersionsNullableJsonConverter(),
                    new global::G.JsonConverters.StrengthJsonConverter(),
                    new global::G.JsonConverters.StrengthNullableJsonConverter(),
                    new global::G.JsonConverters.JobStatusJsonConverter(),
                    new global::G.JsonConverters.JobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.MODELASSETTEXTURETYPESJsonConverter(),
                    new global::G.JsonConverters.MODELASSETTEXTURETYPESNullableJsonConverter(),
                    new global::G.JsonConverters.CustomModelTypeJsonConverter(),
                    new global::G.JsonConverters.CustomModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SdGenerationSchedulersJsonConverter(),
                    new global::G.JsonConverters.SdGenerationSchedulersNullableJsonConverter(),
                    new global::G.JsonConverters.VARIATIONTYPEJsonConverter(),
                    new global::G.JsonConverters.VARIATIONTYPENullableJsonConverter(),
                    new global::G.JsonConverters.ControlnetInputInitImageTypeJsonConverter(),
                    new global::G.JsonConverters.ControlnetInputInitImageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ControlnetInputStrengthTypeJsonConverter(),
                    new global::G.JsonConverters.ControlnetInputStrengthTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SdGenerationStyleJsonConverter(),
                    new global::G.JsonConverters.SdGenerationStyleNullableJsonConverter(),
                    new global::G.JsonConverters.LcmGenerationStyleJsonConverter(),
                    new global::G.JsonConverters.LcmGenerationStyleNullableJsonConverter(),
                    new global::G.JsonConverters.UniversalUpscalerStyleJsonConverter(),
                    new global::G.JsonConverters.UniversalUpscalerStyleNullableJsonConverter(),
                    new global::G.JsonConverters.ControlnetTypeJsonConverter(),
                    new global::G.JsonConverters.ControlnetTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PricingCalculatorServicesJsonConverter(),
                    new global::G.JsonConverters.PricingCalculatorServicesNullableJsonConverter(),
                    new global::G.JsonConverters.CanvasRequestTypeJsonConverter(),
                    new global::G.JsonConverters.CanvasRequestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateGenerationRequestTransparencyJsonConverter(),
                    new global::G.JsonConverters.CreateGenerationRequestTransparencyNullableJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public DatasetClient Dataset => new DatasetClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ElementsClient Elements => new ElementsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImageClient Image => new ImageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InitImagesClient InitImages => new InitImagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MotionClient Motion => new MotionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PricingCalculatorClient PricingCalculator => new PricingCalculatorClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt => new PromptClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RealtimeCanvasClient RealtimeCanvas => new RealtimeCanvasClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextureClient Texture => new TextureClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VariationClient Variation => new VariationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public x3DModelAssetsClient x3DModelAssets => new x3DModelAssetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}