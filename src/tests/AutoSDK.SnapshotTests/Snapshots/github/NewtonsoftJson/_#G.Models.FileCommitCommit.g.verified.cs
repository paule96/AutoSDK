﻿//HintName: G.Models.FileCommitCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileCommitCommit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::G.FileCommitCommitAuthor? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer")]
        public global::G.FileCommitCommitCommitter? Committer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree")]
        public global::G.FileCommitCommitTree? Tree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parents")]
        public global::System.Collections.Generic.IList<global::G.FileCommitCommitParent>? Parents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verification")]
        public global::G.FileCommitCommitVerification? Verification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommit" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="author"></param>
        /// <param name="committer"></param>
        /// <param name="message"></param>
        /// <param name="tree"></param>
        /// <param name="parents"></param>
        /// <param name="verification"></param>
        public FileCommitCommit(
            string? sha,
            string? nodeId,
            string? url,
            string? htmlUrl,
            global::G.FileCommitCommitAuthor? author,
            global::G.FileCommitCommitCommitter? committer,
            string? message,
            global::G.FileCommitCommitTree? tree,
            global::System.Collections.Generic.IList<global::G.FileCommitCommitParent>? parents,
            global::G.FileCommitCommitVerification? verification)
        {
            this.Sha = sha;
            this.NodeId = nodeId;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.Author = author;
            this.Committer = committer;
            this.Message = message;
            this.Tree = tree;
            this.Parents = parents;
            this.Verification = verification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommit" /> class.
        /// </summary>
        public FileCommitCommit()
        {
        }
    }
}