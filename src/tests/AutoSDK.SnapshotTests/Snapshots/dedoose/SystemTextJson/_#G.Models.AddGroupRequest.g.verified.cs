﻿//HintName: G.Models.AddGroupRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddGroupRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessListId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccessListId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddGroupRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="accessListId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddGroupRequest(
            global::System.Guid projectId,
            string title,
            global::System.Guid accessListId)
        {
            this.ProjectId = projectId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.AccessListId = accessListId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddGroupRequest" /> class.
        /// </summary>
        public AddGroupRequest()
        {
        }
    }
}