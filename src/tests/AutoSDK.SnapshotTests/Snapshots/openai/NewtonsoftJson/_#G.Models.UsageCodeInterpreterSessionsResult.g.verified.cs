﻿//HintName: G.Models.UsageCodeInterpreterSessionsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aggregated code interpreter sessions usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageCodeInterpreterSessionsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.UsageCodeInterpreterSessionsResultObject Object { get; set; }

        /// <summary>
        /// The number of code interpreter sessions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_sessions")]
        public int? NumSessions { get; set; }

        /// <summary>
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCodeInterpreterSessionsResult" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="numSessions">
        /// The number of code interpreter sessions.
        /// </param>
        /// <param name="projectId">
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </param>
        public UsageCodeInterpreterSessionsResult(
            global::G.UsageCodeInterpreterSessionsResultObject @object,
            int? numSessions,
            string? projectId)
        {
            this.Object = @object;
            this.NumSessions = numSessions;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCodeInterpreterSessionsResult" /> class.
        /// </summary>
        public UsageCodeInterpreterSessionsResult()
        {
        }
    }
}