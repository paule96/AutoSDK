﻿//HintName: G.Models.GetStreamKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStreamKeyResponse
    {
        /// <summary>
        /// A list that contains the channel’s stream key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetStreamKeyResponseDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamKeyResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the channel’s stream key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStreamKeyResponse(
            global::System.Collections.Generic.IList<global::G.GetStreamKeyResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamKeyResponse" /> class.
        /// </summary>
        public GetStreamKeyResponse()
        {
        }
    }
}