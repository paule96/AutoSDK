﻿//HintName: G.Models.IssuesUpdateMilestoneRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesUpdateMilestoneRequest
    {
        /// <summary>
        /// The title of the milestone.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The state of the milestone. Either `open` or `closed`.<br/>
        /// Default Value: open
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.IssuesUpdateMilestoneRequestState? State { get; set; }

        /// <summary>
        /// A description of the milestone.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The milestone due date. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("due_on")]
        public global::System.DateTime? DueOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateMilestoneRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the milestone.
        /// </param>
        /// <param name="state">
        /// The state of the milestone. Either `open` or `closed`.<br/>
        /// Default Value: open
        /// </param>
        /// <param name="description">
        /// A description of the milestone.
        /// </param>
        /// <param name="dueOn">
        /// The milestone due date. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        public IssuesUpdateMilestoneRequest(
            string? title,
            global::G.IssuesUpdateMilestoneRequestState? state,
            string? description,
            global::System.DateTime? dueOn)
        {
            this.Title = title;
            this.State = state;
            this.Description = description;
            this.DueOn = dueOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateMilestoneRequest" /> class.
        /// </summary>
        public IssuesUpdateMilestoneRequest()
        {
        }
    }
}