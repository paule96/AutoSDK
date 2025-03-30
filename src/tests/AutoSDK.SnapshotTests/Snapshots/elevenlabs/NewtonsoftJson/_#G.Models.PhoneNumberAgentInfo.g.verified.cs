﻿//HintName: G.Models.PhoneNumberAgentInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberAgentInfo
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The name of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberAgentInfo" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="agentName">
        /// The name of the agent
        /// </param>
        public PhoneNumberAgentInfo(
            string agentId,
            string agentName)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberAgentInfo" /> class.
        /// </summary>
        public PhoneNumberAgentInfo()
        {
        }
    }
}