﻿//HintName: G.Models.ReposCreateAttestationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateAttestationResponse
    {
        /// <summary>
        /// The ID of the attestation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateAttestationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the attestation.
        /// </param>
        public ReposCreateAttestationResponse(
            int? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateAttestationResponse" /> class.
        /// </summary>
        public ReposCreateAttestationResponse()
        {
        }
    }
}