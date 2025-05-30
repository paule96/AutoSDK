﻿//HintName: G.Models.PipelineScaling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineScaling
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("desired", Required = global::Newtonsoft.Json.Required.Always)]
        public int Desired { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current", Required = global::Newtonsoft.Json.Required.Always)]
        public int Current { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineScaling" /> class.
        /// </summary>
        /// <param name="desired"></param>
        /// <param name="current"></param>
        public PipelineScaling(
            int desired,
            int current)
        {
            this.Desired = desired;
            this.Current = current;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineScaling" /> class.
        /// </summary>
        public PipelineScaling()
        {
        }
    }
}