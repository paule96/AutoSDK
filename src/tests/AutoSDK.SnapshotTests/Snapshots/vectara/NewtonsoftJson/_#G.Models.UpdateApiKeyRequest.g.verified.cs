﻿//HintName: G.Models.UpdateApiKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an existing API key's properties or permissions.
    /// </summary>
    public sealed partial class UpdateApiKeyRequest
    {
        /// <summary>
        /// Indicates whether to disable or enable an API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Indicates whether to disable or enable an API key.
        /// </param>
        public UpdateApiKeyRequest(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyRequest" /> class.
        /// </summary>
        public UpdateApiKeyRequest()
        {
        }
    }
}