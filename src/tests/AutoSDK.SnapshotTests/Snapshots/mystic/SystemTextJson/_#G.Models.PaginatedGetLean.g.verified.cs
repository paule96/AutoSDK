﻿//HintName: G.Models.PaginatedGetLean.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for a paginated set of a given resource.
    /// </summary>
    public sealed partial class PaginatedGetLean
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Skip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetLean> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedGetLean" /> class.
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="limit"></param>
        /// <param name="total"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedGetLean(
            int skip,
            int limit,
            int total,
            global::System.Collections.Generic.IList<global::G.GetLean> data)
        {
            this.Skip = skip;
            this.Limit = limit;
            this.Total = total;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedGetLean" /> class.
        /// </summary>
        public PaginatedGetLean()
        {
        }
    }
}