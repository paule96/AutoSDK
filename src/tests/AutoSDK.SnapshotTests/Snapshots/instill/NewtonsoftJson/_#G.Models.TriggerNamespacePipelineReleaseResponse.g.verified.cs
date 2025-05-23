﻿//HintName: G.Models.TriggerNamespacePipelineReleaseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerNamespacePipelineReleaseResponse contains the pipeline execution results,<br/>
    /// i.e., the multiple model inference outputs.
    /// </summary>
    public sealed partial class TriggerNamespacePipelineReleaseResponse
    {
        /// <summary>
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Traces of the pipeline inference.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.TriggerMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        /// <param name="outputs">
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="metadata">
        /// Traces of the pipeline inference.<br/>
        /// Included only in responses
        /// </param>
        public TriggerNamespacePipelineReleaseResponse(
            global::System.Collections.Generic.IList<object>? outputs,
            global::G.TriggerMetadata? metadata)
        {
            this.Outputs = outputs;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        public TriggerNamespacePipelineReleaseResponse()
        {
        }
    }
}