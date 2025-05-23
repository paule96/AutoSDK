﻿//HintName: G.Models.FeedbackDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feedback key with number of improvements and regressions.
    /// </summary>
    public sealed partial class FeedbackDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("improved_examples", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ImprovedExamples { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regressed_examples", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> RegressedExamples { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackDelta" /> class.
        /// </summary>
        /// <param name="improvedExamples"></param>
        /// <param name="regressedExamples"></param>
        public FeedbackDelta(
            global::System.Collections.Generic.IList<global::System.Guid> improvedExamples,
            global::System.Collections.Generic.IList<global::System.Guid> regressedExamples)
        {
            this.ImprovedExamples = improvedExamples ?? throw new global::System.ArgumentNullException(nameof(improvedExamples));
            this.RegressedExamples = regressedExamples ?? throw new global::System.ArgumentNullException(nameof(regressedExamples));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackDelta" /> class.
        /// </summary>
        public FeedbackDelta()
        {
        }
    }
}