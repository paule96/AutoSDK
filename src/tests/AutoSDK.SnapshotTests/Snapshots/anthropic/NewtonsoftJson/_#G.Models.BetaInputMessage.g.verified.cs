﻿//HintName: G.Models.BetaInputMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BetaInputMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.BetaInputContentBlock>> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        public BetaInputMessage(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.BetaInputContentBlock>> content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputMessage" /> class.
        /// </summary>
        public BetaInputMessage()
        {
        }
    }
}