﻿//HintName: G.Models.MessageDeltaContentImageFileObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// References an image [File](/docs/api-reference/files) in the content of a message.
    /// </summary>
    public sealed partial class MessageDeltaContentImageFileObject
    {
        /// <summary>
        /// The index of the content part in the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Always `image_file`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageDeltaContentImageFileObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_file")]
        public global::G.MessageDeltaContentImageFileObjectImageFile? ImageFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageFileObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the content part in the message.
        /// </param>
        /// <param name="type">
        /// Always `image_file`.
        /// </param>
        /// <param name="imageFile"></param>
        public MessageDeltaContentImageFileObject(
            int index,
            global::G.MessageDeltaContentImageFileObjectType type,
            global::G.MessageDeltaContentImageFileObjectImageFile? imageFile)
        {
            this.Index = index;
            this.Type = type;
            this.ImageFile = imageFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageFileObject" /> class.
        /// </summary>
        public MessageDeltaContentImageFileObject()
        {
        }
    }
}