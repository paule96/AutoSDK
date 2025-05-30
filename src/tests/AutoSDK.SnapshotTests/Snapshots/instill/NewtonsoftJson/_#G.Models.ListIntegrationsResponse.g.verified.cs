﻿//HintName: G.Models.ListIntegrationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListIntegrationsResponse contains a paginated list of integrations.
    /// </summary>
    public sealed partial class ListIntegrationsResponse
    {
        /// <summary>
        /// A list of integrations matching the request parameters.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integrations")]
        public global::System.Collections.Generic.IList<global::G.Integration>? Integrations { get; set; }

        /// <summary>
        /// Next page token.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of items.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListIntegrationsResponse" /> class.
        /// </summary>
        /// <param name="integrations">
        /// A list of integrations matching the request parameters.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of items.<br/>
        /// Included only in responses
        /// </param>
        public ListIntegrationsResponse(
            global::System.Collections.Generic.IList<global::G.Integration>? integrations,
            string? nextPageToken,
            int? totalSize)
        {
            this.Integrations = integrations;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListIntegrationsResponse" /> class.
        /// </summary>
        public ListIntegrationsResponse()
        {
        }
    }
}