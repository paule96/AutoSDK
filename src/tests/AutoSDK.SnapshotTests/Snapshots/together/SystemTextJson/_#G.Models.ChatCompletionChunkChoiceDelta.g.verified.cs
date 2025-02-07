﻿//HintName: G.Models.ChatCompletionChunkChoiceDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChunkChoiceDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ChatCompletionChunkChoiceDeltaFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionChunkChoiceDeltaRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        public int? TokenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolChoice2>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoiceDelta" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="tokenId"></param>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunkChoiceDelta(
            global::G.ChatCompletionChunkChoiceDeltaRole role,
            string? content,
            int? tokenId,
            global::System.Collections.Generic.IList<global::G.ToolChoice2>? toolCalls)
        {
            this.Role = role;
            this.Content = content;
            this.TokenId = tokenId;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoiceDelta" /> class.
        /// </summary>
        public ChatCompletionChunkChoiceDelta()
        {
        }
    }
}