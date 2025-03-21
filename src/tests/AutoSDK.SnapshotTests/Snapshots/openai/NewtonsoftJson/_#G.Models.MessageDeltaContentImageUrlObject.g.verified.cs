﻿//HintName: G.Models.MessageDeltaContentImageUrlObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// References an image URL in the content of a message.
    /// </summary>
    public sealed partial class MessageDeltaContentImageUrlObject
    {
        /// <summary>
        /// The index of the content part in the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Always `image_url`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageDeltaContentImageUrlObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public global::G.MessageDeltaContentImageUrlObjectImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the content part in the message.
        /// </param>
        /// <param name="type">
        /// Always `image_url`.
        /// </param>
        /// <param name="imageUrl"></param>
        public MessageDeltaContentImageUrlObject(
            int index,
            global::G.MessageDeltaContentImageUrlObjectType type,
            global::G.MessageDeltaContentImageUrlObjectImageUrl? imageUrl)
        {
            this.Index = index;
            this.Type = type;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObject" /> class.
        /// </summary>
        public MessageDeltaContentImageUrlObject()
        {
        }
    }
}