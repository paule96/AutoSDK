﻿//HintName: G.Models.ListFineTuningCheckpointPermissionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFineTuningCheckpointPermissionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FineTuningCheckpointPermission> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ListFineTuningCheckpointPermissionResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningCheckpointPermissionResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object"></param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
        /// <param name="hasMore"></param>
        public ListFineTuningCheckpointPermissionResponse(
            global::System.Collections.Generic.IList<global::G.FineTuningCheckpointPermission> data,
            bool hasMore,
            global::G.ListFineTuningCheckpointPermissionResponseObject @object,
            string? firstId,
            string? lastId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.Object = @object;
            this.FirstId = firstId;
            this.LastId = lastId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningCheckpointPermissionResponse" /> class.
        /// </summary>
        public ListFineTuningCheckpointPermissionResponse()
        {
        }
    }
}