﻿//HintName: G.Models.Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about a Generative Language Model.
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Required. The resource name of the `Model`. Format: `models/{model}` with a `{model}` naming convention of: * "{base_model_id}-{version}" Examples: * `models/chat-bison-001`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The human-readable name of the model. E.g. "Chat Bison". The name can be up to 128 characters long and can consist of any UTF-8 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// A short description of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Required. The version number of the model. This represents the major version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Required. The name of the base model, pass this to the generation request. Examples: * `chat-bison`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("baseModelId")]
        public string? BaseModelId { get; set; }

        /// <summary>
        /// Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model. This value specifies default to be used by the backend while making the call to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// For Top-k sampling. Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// For Nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`. This value specifies default to be used by the backend while making the call to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Maximum number of input tokens allowed for this model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputTokenLimit")]
        public int? InputTokenLimit { get; set; }

        /// <summary>
        /// Maximum number of output tokens available for this model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputTokenLimit")]
        public int? OutputTokenLimit { get; set; }

        /// <summary>
        /// The model's supported generation methods. The method names are defined as Pascal case strings, such as `generateMessage` which correspond to API methods.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supportedGenerationMethods")]
        public global::System.Collections.Generic.IList<string>? SupportedGenerationMethods { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `Model`. Format: `models/{model}` with a `{model}` naming convention of: * "{base_model_id}-{version}" Examples: * `models/chat-bison-001`
        /// </param>
        /// <param name="displayName">
        /// The human-readable name of the model. E.g. "Chat Bison". The name can be up to 128 characters long and can consist of any UTF-8 characters.
        /// </param>
        /// <param name="description">
        /// A short description of the model.
        /// </param>
        /// <param name="version">
        /// Required. The version number of the model. This represents the major version
        /// </param>
        /// <param name="baseModelId">
        /// Required. The name of the base model, pass this to the generation request. Examples: * `chat-bison`
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model. This value specifies default to be used by the backend while making the call to the model.
        /// </param>
        /// <param name="topK">
        /// For Top-k sampling. Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model.
        /// </param>
        /// <param name="topP">
        /// For Nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`. This value specifies default to be used by the backend while making the call to the model.
        /// </param>
        /// <param name="inputTokenLimit">
        /// Maximum number of input tokens allowed for this model.
        /// </param>
        /// <param name="outputTokenLimit">
        /// Maximum number of output tokens available for this model.
        /// </param>
        /// <param name="supportedGenerationMethods">
        /// The model's supported generation methods. The method names are defined as Pascal case strings, such as `generateMessage` which correspond to API methods.
        /// </param>
        public Model(
            string? name,
            string? displayName,
            string? description,
            string? version,
            string? baseModelId,
            float? temperature,
            int? topK,
            float? topP,
            int? inputTokenLimit,
            int? outputTokenLimit,
            global::System.Collections.Generic.IList<string>? supportedGenerationMethods)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.Version = version;
            this.BaseModelId = baseModelId;
            this.Temperature = temperature;
            this.TopK = topK;
            this.TopP = topP;
            this.InputTokenLimit = inputTokenLimit;
            this.OutputTokenLimit = outputTokenLimit;
            this.SupportedGenerationMethods = supportedGenerationMethods;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}