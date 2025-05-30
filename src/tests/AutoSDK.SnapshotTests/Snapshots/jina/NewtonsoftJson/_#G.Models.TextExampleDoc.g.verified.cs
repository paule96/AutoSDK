﻿//HintName: G.Models.TextExampleDoc.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Document containing a text field and a label
    /// </summary>
    public sealed partial class TextExampleDoc
    {
        /// <summary>
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: e10b550cf99e2e072e22420af5c6eb47
        /// </summary>
        /// <example>e10b550cf99e2e072e22420af5c6eb47</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The example text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The label of the text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<bool?, string> Label { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextExampleDoc" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: e10b550cf99e2e072e22420af5c6eb47
        /// </param>
        /// <param name="text">
        /// The example text
        /// </param>
        /// <param name="label">
        /// The label of the text
        /// </param>
        public TextExampleDoc(
            string text,
            global::G.AnyOf<bool?, string> label,
            string? id)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Label = label;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextExampleDoc" /> class.
        /// </summary>
        public TextExampleDoc()
        {
        }
    }
}