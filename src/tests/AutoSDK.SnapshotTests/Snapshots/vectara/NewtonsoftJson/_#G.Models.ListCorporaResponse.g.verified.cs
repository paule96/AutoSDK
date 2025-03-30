﻿//HintName: G.Models.ListCorporaResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of corpora within a customer account.
    /// </summary>
    public sealed partial class ListCorporaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corpora")]
        public global::System.Collections.Generic.IList<global::G.Corpus>? Corpora { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCorporaResponse" /> class.
        /// </summary>
        /// <param name="corpora"></param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
        public ListCorporaResponse(
            global::System.Collections.Generic.IList<global::G.Corpus>? corpora,
            global::G.ListMetadata? metadata)
        {
            this.Corpora = corpora;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCorporaResponse" /> class.
        /// </summary>
        public ListCorporaResponse()
        {
        }
    }
}