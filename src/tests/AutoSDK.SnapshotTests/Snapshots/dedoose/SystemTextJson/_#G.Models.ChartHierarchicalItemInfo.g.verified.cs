﻿//HintName: G.Models.ChartHierarchicalItemInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChartHierarchicalItemInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        public global::System.Collections.Generic.IList<global::G.ChartItemInfo>? Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartHierarchicalItemInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="children"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartHierarchicalItemInfo(
            string? title,
            global::System.Collections.Generic.IList<global::G.ChartItemInfo>? children)
        {
            this.Title = title;
            this.Children = children;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartHierarchicalItemInfo" /> class.
        /// </summary>
        public ChartHierarchicalItemInfo()
        {
        }
    }
}