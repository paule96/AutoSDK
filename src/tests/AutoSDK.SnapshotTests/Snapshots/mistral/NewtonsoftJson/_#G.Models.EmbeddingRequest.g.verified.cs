﻿//HintName: G.Models.EmbeddingRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingRequest
    {
        /// <summary>
        /// Text to embed.<br/>
        /// Example: Embed this sentence.
        /// </summary>
        /// <example>Embed this sentence.</example>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; } = default!;

        /// <summary>
        /// ID of the model to use.<br/>
        /// Example: mistral-embed
        /// </summary>
        /// <example>mistral-embed</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text to embed.<br/>
        /// Example: Embed this sentence.
        /// </param>
        /// <param name="model">
        /// ID of the model to use.<br/>
        /// Example: mistral-embed
        /// </param>
        public EmbeddingRequest(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            string model)
        {
            this.Input = input;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        public EmbeddingRequest()
        {
        }
    }
}