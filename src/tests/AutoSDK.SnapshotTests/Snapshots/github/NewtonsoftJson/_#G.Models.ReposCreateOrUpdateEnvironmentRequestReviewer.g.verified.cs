﻿//HintName: G.Models.ReposCreateOrUpdateEnvironmentRequestReviewer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateOrUpdateEnvironmentRequestReviewer
    {
        /// <summary>
        /// The type of reviewer.<br/>
        /// Example: User
        /// </summary>
        /// <example>User</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DeploymentReviewerType? Type { get; set; }

        /// <summary>
        /// The id of the user or team who can review the deployment<br/>
        /// Example: 4532992
        /// </summary>
        /// <example>4532992</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrUpdateEnvironmentRequestReviewer" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of reviewer.<br/>
        /// Example: User
        /// </param>
        /// <param name="id">
        /// The id of the user or team who can review the deployment<br/>
        /// Example: 4532992
        /// </param>
        public ReposCreateOrUpdateEnvironmentRequestReviewer(
            global::G.DeploymentReviewerType? type,
            int? id)
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrUpdateEnvironmentRequestReviewer" /> class.
        /// </summary>
        public ReposCreateOrUpdateEnvironmentRequestReviewer()
        {
        }
    }
}