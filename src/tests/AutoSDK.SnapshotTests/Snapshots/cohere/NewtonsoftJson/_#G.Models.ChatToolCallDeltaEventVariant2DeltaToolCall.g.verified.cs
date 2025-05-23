﻿//HintName: G.Models.ChatToolCallDeltaEventVariant2DeltaToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventVariant2DeltaToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ChatToolCallDeltaEventVariant2DeltaToolCallFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2DeltaToolCall" /> class.
        /// </summary>
        /// <param name="function"></param>
        public ChatToolCallDeltaEventVariant2DeltaToolCall(
            global::G.ChatToolCallDeltaEventVariant2DeltaToolCallFunction? function)
        {
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2DeltaToolCall" /> class.
        /// </summary>
        public ChatToolCallDeltaEventVariant2DeltaToolCall()
        {
        }
    }
}