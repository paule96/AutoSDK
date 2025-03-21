﻿//HintName: G.Models.FineTuningJobCheckpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `fine_tuning.job.checkpoint` object represents a model checkpoint for a fine-tuning job that is ready to use.
    /// </summary>
    public sealed partial class FineTuningJobCheckpoint
    {
        /// <summary>
        /// The checkpoint identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the checkpoint was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the fine-tuned checkpoint model that is created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fine_tuned_model_checkpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string FineTunedModelCheckpoint { get; set; } = default!;

        /// <summary>
        /// The step number that the checkpoint was created at.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int StepNumber { get; set; } = default!;

        /// <summary>
        /// Metrics at the step number during the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuningJobCheckpointMetrics Metrics { get; set; } = default!;

        /// <summary>
        /// The name of the fine-tuning job that this checkpoint was created from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fine_tuning_job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FineTuningJobId { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "fine_tuning.job.checkpoint".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.FineTuningJobCheckpointObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobCheckpoint" /> class.
        /// </summary>
        /// <param name="id">
        /// The checkpoint identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the checkpoint was created.
        /// </param>
        /// <param name="fineTunedModelCheckpoint">
        /// The name of the fine-tuned checkpoint model that is created.
        /// </param>
        /// <param name="stepNumber">
        /// The step number that the checkpoint was created at.
        /// </param>
        /// <param name="metrics">
        /// Metrics at the step number during the fine-tuning job.
        /// </param>
        /// <param name="fineTuningJobId">
        /// The name of the fine-tuning job that this checkpoint was created from.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "fine_tuning.job.checkpoint".
        /// </param>
        public FineTuningJobCheckpoint(
            string id,
            global::System.DateTimeOffset createdAt,
            string fineTunedModelCheckpoint,
            int stepNumber,
            global::G.FineTuningJobCheckpointMetrics metrics,
            string fineTuningJobId,
            global::G.FineTuningJobCheckpointObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.FineTunedModelCheckpoint = fineTunedModelCheckpoint ?? throw new global::System.ArgumentNullException(nameof(fineTunedModelCheckpoint));
            this.StepNumber = stepNumber;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.FineTuningJobId = fineTuningJobId ?? throw new global::System.ArgumentNullException(nameof(fineTuningJobId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobCheckpoint" /> class.
        /// </summary>
        public FineTuningJobCheckpoint()
        {
        }
    }
}