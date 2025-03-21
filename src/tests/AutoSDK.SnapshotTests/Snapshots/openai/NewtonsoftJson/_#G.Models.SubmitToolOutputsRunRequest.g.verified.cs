﻿//HintName: G.Models.SubmitToolOutputsRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitToolOutputsRunRequest
    {
        /// <summary>
        /// A list of tools for which the outputs are being submitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_outputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SubmitToolOutputsRunRequestToolOutput> ToolOutputs { get; set; } = default!;

        /// <summary>
        /// If `true`, returns a stream of events that happen during the Run as server-sent events, terminating when the Run enters a terminal state with a `data: [DONE]` message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequest" /> class.
        /// </summary>
        /// <param name="toolOutputs">
        /// A list of tools for which the outputs are being submitted.
        /// </param>
        /// <param name="stream">
        /// If `true`, returns a stream of events that happen during the Run as server-sent events, terminating when the Run enters a terminal state with a `data: [DONE]` message.
        /// </param>
        public SubmitToolOutputsRunRequest(
            global::System.Collections.Generic.IList<global::G.SubmitToolOutputsRunRequestToolOutput> toolOutputs,
            bool? stream)
        {
            this.ToolOutputs = toolOutputs ?? throw new global::System.ArgumentNullException(nameof(toolOutputs));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequest" /> class.
        /// </summary>
        public SubmitToolOutputsRunRequest()
        {
        }
    }
}