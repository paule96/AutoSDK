﻿//HintName: G.Models.ChatCompletionUserMessageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionUserMessageParamRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        public ChatCompletionUserMessageParam(
            string content,
            string? name,
            global::G.ChatCompletionUserMessageParamRole role)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Name = name;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParam" /> class.
        /// </summary>
        public ChatCompletionUserMessageParam()
        {
        }
    }
}