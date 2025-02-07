﻿//HintName: G.Models.ToolMessageV2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A message from the system.
    /// </summary>
    public sealed partial class ToolMessageV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolMessageV2RoleJsonConverter))]
        public global::G.ToolMessageV2Role Role { get; set; }

        /// <summary>
        /// The id of the associated tool call that has provided the given content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// A single or list of outputs from a tool. The content should formatted as a JSON object string, or a list of tool content blocks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ToolContent>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ToolContent>> ToolContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageV2" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="toolCallId">
        /// The id of the associated tool call that has provided the given content
        /// </param>
        /// <param name="toolContent">
        /// A single or list of outputs from a tool. The content should formatted as a JSON object string, or a list of tool content blocks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolMessageV2(
            string toolCallId,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ToolContent>> toolContent,
            global::G.ToolMessageV2Role role)
        {
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolContent = toolContent;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageV2" /> class.
        /// </summary>
        public ToolMessageV2()
        {
        }
    }
}