﻿//HintName: G.Models.IssuesUpdateCommentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesUpdateCommentRequest
    {
        /// <summary>
        /// The contents of the comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateCommentRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The contents of the comment.
        /// </param>
        public IssuesUpdateCommentRequest(
            string body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateCommentRequest" /> class.
        /// </summary>
        public IssuesUpdateCommentRequest()
        {
        }
    }
}