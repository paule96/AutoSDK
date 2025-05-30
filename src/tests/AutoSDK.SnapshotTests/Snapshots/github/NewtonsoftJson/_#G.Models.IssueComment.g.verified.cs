﻿//HintName: G.Models.IssueComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comments provide a way for people to collaborate on an issue.
    /// </summary>
    public sealed partial class IssueComment
    {
        /// <summary>
        /// Unique identifier of the issue comment<br/>
        /// Example: 42L
        /// </summary>
        /// <example>42L</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// URL for the issue comment<br/>
        /// Example: https://api.github.com/repositories/42/issues/comments/1
        /// </summary>
        /// <example>https://api.github.com/repositories/42/issues/comments/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Contents of the issue comment<br/>
        /// Example: What version of Safari were you using when you observed this bug?
        /// </summary>
        /// <example>What version of Safari were you using when you observed this bug?</example>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueUrl { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueComment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the issue comment<br/>
        /// Example: 42L
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="url">
        /// URL for the issue comment<br/>
        /// Example: https://api.github.com/repositories/42/issues/comments/1
        /// </param>
        /// <param name="body">
        /// Contents of the issue comment<br/>
        /// Example: What version of Safari were you using when you observed this bug?
        /// </param>
        /// <param name="bodyText"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="issueUrl"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="reactions"></param>
        public IssueComment(
            long id,
            string nodeId,
            string url,
            string htmlUrl,
            global::G.NullableSimpleUser? user,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string issueUrl,
            global::G.AuthorAssociation authorAssociation,
            string? body,
            string? bodyText,
            string? bodyHtml,
            global::G.NullableIntegration? performedViaGithubApp,
            global::G.ReactionRollup? reactions)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IssueUrl = issueUrl ?? throw new global::System.ArgumentNullException(nameof(issueUrl));
            this.AuthorAssociation = authorAssociation;
            this.Body = body;
            this.BodyText = bodyText;
            this.BodyHtml = bodyHtml;
            this.PerformedViaGithubApp = performedViaGithubApp;
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueComment" /> class.
        /// </summary>
        public IssueComment()
        {
        }
    }
}