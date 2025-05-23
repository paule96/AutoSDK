﻿//HintName: G.Models.GetAllStreamTagsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetAllStreamTagsResponse
    {
        /// <summary>
        /// The list of stream tags that the broadcaster can apply to their channel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.StreamTag> Data { get; set; } = default!;

        /// <summary>
        /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.GetAllStreamTagsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllStreamTagsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of stream tags that the broadcaster can apply to their channel.
        /// </param>
        /// <param name="pagination">
        /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
        public GetAllStreamTagsResponse(
            global::System.Collections.Generic.IList<global::G.StreamTag> data,
            global::G.GetAllStreamTagsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllStreamTagsResponse" /> class.
        /// </summary>
        public GetAllStreamTagsResponse()
        {
        }
    }
}