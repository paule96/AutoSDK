﻿//HintName: G.Models.ChatContentDeltaEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentDeltaEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public global::G.ChatContentDeltaEventVariant2Delta? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        public ChatContentDeltaEventVariant2(
            int? index,
            global::G.ChatContentDeltaEventVariant2Delta? delta)
        {
            this.Index = index;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2" /> class.
        /// </summary>
        public ChatContentDeltaEventVariant2()
        {
        }
    }
}