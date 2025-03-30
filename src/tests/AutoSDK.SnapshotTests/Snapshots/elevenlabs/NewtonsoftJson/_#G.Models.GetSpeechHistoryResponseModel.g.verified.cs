﻿//HintName: G.Models.GetSpeechHistoryResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpeechHistoryResponseModel
    {
        /// <summary>
        /// A list of speech history items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("history", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SpeechHistoryItemResponseModel> History { get; set; } = default!;

        /// <summary>
        /// The ID of the last history item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_history_item_id")]
        public string? LastHistoryItemId { get; set; }

        /// <summary>
        /// Whether there are more history items to fetch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpeechHistoryResponseModel" /> class.
        /// </summary>
        /// <param name="history">
        /// A list of speech history items.
        /// </param>
        /// <param name="lastHistoryItemId">
        /// The ID of the last history item.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more history items to fetch.
        /// </param>
        public GetSpeechHistoryResponseModel(
            global::System.Collections.Generic.IList<global::G.SpeechHistoryItemResponseModel> history,
            bool hasMore,
            string? lastHistoryItemId)
        {
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
            this.HasMore = hasMore;
            this.LastHistoryItemId = lastHistoryItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpeechHistoryResponseModel" /> class.
        /// </summary>
        public GetSpeechHistoryResponseModel()
        {
        }
    }
}