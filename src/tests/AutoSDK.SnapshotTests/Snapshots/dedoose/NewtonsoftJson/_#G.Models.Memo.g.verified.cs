﻿//HintName: G.Models.Memo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Memo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdUserId")]
        public global::System.Guid? CreatedUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastEditUserId")]
        public global::System.Guid? LastEditUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastEditStamp")]
        public global::System.DateTime? LastEditStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folderId")]
        public global::System.Guid? FolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataURI")]
        public string? DataURI { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Memo" /> class.
        /// </summary>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="createdUserId"></param>
        /// <param name="lastEditUserId"></param>
        /// <param name="createStamp"></param>
        /// <param name="lastEditStamp"></param>
        /// <param name="folderId"></param>
        /// <param name="dataURI"></param>
        public Memo(
            string? projectIdKey,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? title,
            global::System.Guid? createdUserId,
            global::System.Guid? lastEditUserId,
            global::System.DateTime? createStamp,
            global::System.DateTime? lastEditStamp,
            global::System.Guid? folderId,
            string? dataURI)
        {
            this.ProjectIdKey = projectIdKey;
            this.Id = id;
            this.ProjectId = projectId;
            this.Title = title;
            this.CreatedUserId = createdUserId;
            this.LastEditUserId = lastEditUserId;
            this.CreateStamp = createStamp;
            this.LastEditStamp = lastEditStamp;
            this.FolderId = folderId;
            this.DataURI = dataURI;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Memo" /> class.
        /// </summary>
        public Memo()
        {
        }
    }
}