﻿//HintName: G.Models.ActionsReRunWorkflowRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsReRunWorkflowRequest
    {
        /// <summary>
        /// Whether to enable debug logging for the re-run.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_debug_logging")]
        public bool? EnableDebugLogging { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsReRunWorkflowRequest" /> class.
        /// </summary>
        /// <param name="enableDebugLogging">
        /// Whether to enable debug logging for the re-run.<br/>
        /// Default Value: false
        /// </param>
        public ActionsReRunWorkflowRequest(
            bool? enableDebugLogging)
        {
            this.EnableDebugLogging = enableDebugLogging;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsReRunWorkflowRequest" /> class.
        /// </summary>
        public ActionsReRunWorkflowRequest()
        {
        }
    }
}