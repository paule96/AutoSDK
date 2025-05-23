﻿//HintName: G.Models.EnvironmentProtectionRuleVariant2Reviewer.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentProtectionRuleVariant2Reviewer
    {
        /// <summary>
        /// The type of reviewer.<br/>
        /// Example: User
        /// </summary>
        /// <example>User</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DeploymentReviewerType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewer")]
        public global::G.AnyOf<global::G.SimpleUser, global::G.Team>? Reviewer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentProtectionRuleVariant2Reviewer" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of reviewer.<br/>
        /// Example: User
        /// </param>
        /// <param name="reviewer"></param>
        public EnvironmentProtectionRuleVariant2Reviewer(
            global::G.DeploymentReviewerType? type,
            global::G.AnyOf<global::G.SimpleUser, global::G.Team>? reviewer)
        {
            this.Type = type;
            this.Reviewer = reviewer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentProtectionRuleVariant2Reviewer" /> class.
        /// </summary>
        public EnvironmentProtectionRuleVariant2Reviewer()
        {
        }
    }
}