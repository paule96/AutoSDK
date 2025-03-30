﻿//HintName: G.Models.ChapterContentBlockExtendableNodeResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Not used. Make sure you anticipate new types in the future.
    /// </summary>
    public sealed partial class ChapterContentBlockExtendableNodeResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChapterContentBlockExtendableNodeResponseModelType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockExtendableNodeResponseModel" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ChapterContentBlockExtendableNodeResponseModel(
            global::G.ChapterContentBlockExtendableNodeResponseModelType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockExtendableNodeResponseModel" /> class.
        /// </summary>
        public ChapterContentBlockExtendableNodeResponseModel()
        {
        }
    }
}