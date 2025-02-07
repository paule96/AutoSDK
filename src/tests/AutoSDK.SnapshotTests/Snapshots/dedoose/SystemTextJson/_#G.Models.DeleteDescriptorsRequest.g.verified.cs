﻿//HintName: G.Models.DeleteDescriptorsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDescriptorsRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorsIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> DescriptorsIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDescriptorsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="descriptorsIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteDescriptorsRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> descriptorsIds)
        {
            this.ProjectId = projectId;
            this.DescriptorsIds = descriptorsIds ?? throw new global::System.ArgumentNullException(nameof(descriptorsIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDescriptorsRequest" /> class.
        /// </summary>
        public DeleteDescriptorsRequest()
        {
        }
    }
}