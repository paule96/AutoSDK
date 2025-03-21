﻿//HintName: G.Models.MessageDeltaContentTextAnnotationsFileCitationObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files.
    /// </summary>
    public sealed partial class MessageDeltaContentTextAnnotationsFileCitationObject
    {
        /// <summary>
        /// The index of the annotation in the text content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Always `file_citation`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageDeltaContentTextAnnotationsFileCitationObjectType Type { get; set; }

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_citation")]
        public global::G.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? FileCitation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFileCitationObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the annotation in the text content part.
        /// </param>
        /// <param name="type">
        /// Always `file_citation`.
        /// </param>
        /// <param name="text">
        /// The text in the message content that needs to be replaced.
        /// </param>
        /// <param name="fileCitation"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        public MessageDeltaContentTextAnnotationsFileCitationObject(
            int index,
            global::G.MessageDeltaContentTextAnnotationsFileCitationObjectType type,
            string? text,
            global::G.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? fileCitation,
            int? startIndex,
            int? endIndex)
        {
            this.Index = index;
            this.Type = type;
            this.Text = text;
            this.FileCitation = fileCitation;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFileCitationObject" /> class.
        /// </summary>
        public MessageDeltaContentTextAnnotationsFileCitationObject()
        {
        }
    }
}