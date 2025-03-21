﻿//HintName: G.Models.RunObjectRequiredAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details on the action required to continue the run. Will be `null` if no action is required.
    /// </summary>
    public sealed partial class RunObjectRequiredAction
    {
        /// <summary>
        /// For now, this is always `submit_tool_outputs`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunObjectRequiredActionType Type { get; set; }

        /// <summary>
        /// Details on the tool outputs needed for this run to continue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("submit_tool_outputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObjectRequiredActionSubmitToolOutputs SubmitToolOutputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectRequiredAction" /> class.
        /// </summary>
        /// <param name="type">
        /// For now, this is always `submit_tool_outputs`.
        /// </param>
        /// <param name="submitToolOutputs">
        /// Details on the tool outputs needed for this run to continue.
        /// </param>
        public RunObjectRequiredAction(
            global::G.RunObjectRequiredActionSubmitToolOutputs submitToolOutputs,
            global::G.RunObjectRequiredActionType type)
        {
            this.SubmitToolOutputs = submitToolOutputs ?? throw new global::System.ArgumentNullException(nameof(submitToolOutputs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectRequiredAction" /> class.
        /// </summary>
        public RunObjectRequiredAction()
        {
        }
    }
}