﻿//HintName: G.Models.ChatCompletionNamedToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies a tool the model should use. Use to force the model to call a specific function.
    /// </summary>
    public sealed partial class ChatCompletionNamedToolChoice
    {
        /// <summary>
        /// The type of the tool. Currently, only `function` is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionNamedToolChoiceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionNamedToolChoiceFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionNamedToolChoice" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool. Currently, only `function` is supported.
        /// </param>
        /// <param name="function"></param>
        public ChatCompletionNamedToolChoice(
            global::G.ChatCompletionNamedToolChoiceFunction function,
            global::G.ChatCompletionNamedToolChoiceType type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionNamedToolChoice" /> class.
        /// </summary>
        public ChatCompletionNamedToolChoice()
        {
        }
    }
}