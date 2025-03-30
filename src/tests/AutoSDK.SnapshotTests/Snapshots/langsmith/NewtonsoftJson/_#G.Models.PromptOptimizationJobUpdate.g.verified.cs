﻿//HintName: G.Models.PromptOptimizationJobUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationJobUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.EPromptOptimizationJobStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.PromptOptimizationResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobUpdate" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="result"></param>
        public PromptOptimizationJobUpdate(
            global::G.EPromptOptimizationJobStatus? status,
            global::G.PromptOptimizationResult? result)
        {
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobUpdate" /> class.
        /// </summary>
        public PromptOptimizationJobUpdate()
        {
        }
    }
}