﻿//HintName: G.Models.InputFileContent.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A file input to the model.
    /// </summary>
    public sealed partial class InputFileContent
    {
        /// <summary>
        /// The type of the input item. Always `input_file`.<br/>
        /// Default Value: input_file
        /// </summary>
        /// <default>global::G.InputFileContentType.InputFile</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputFileContentType Type { get; set; } = global::G.InputFileContentType.InputFile;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public global::G.AnyOf<string, object>? FileId { get; set; }

        /// <summary>
        /// The name of the file to be sent to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The content of the file to be sent to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the input item. Always `input_file`.<br/>
        /// Default Value: input_file
        /// </param>
        /// <param name="fileId"></param>
        /// <param name="filename">
        /// The name of the file to be sent to the model.
        /// </param>
        /// <param name="fileData">
        /// The content of the file to be sent to the model.
        /// </param>
        public InputFileContent(
            global::G.AnyOf<string, object>? fileId,
            string? filename,
            string? fileData,
            global::G.InputFileContentType type = global::G.InputFileContentType.InputFile)
        {
            this.Type = type;
            this.FileId = fileId;
            this.Filename = filename;
            this.FileData = fileData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileContent" /> class.
        /// </summary>
        public InputFileContent()
        {
        }
    }
}