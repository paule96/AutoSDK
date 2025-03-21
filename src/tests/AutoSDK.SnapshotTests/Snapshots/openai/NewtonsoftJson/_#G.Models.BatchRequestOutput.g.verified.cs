﻿//HintName: G.Models.BatchRequestOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The per-line object of the batch output and error files
    /// </summary>
    public sealed partial class BatchRequestOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// A developer-provided per-request id that will be used to match outputs to inputs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.BatchRequestOutputResponse? Response { get; set; }

        /// <summary>
        /// For requests that failed with a non-HTTP error, this will contain more information on the cause of the failure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.BatchRequestOutputError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customId">
        /// A developer-provided per-request id that will be used to match outputs to inputs.
        /// </param>
        /// <param name="response"></param>
        /// <param name="error">
        /// For requests that failed with a non-HTTP error, this will contain more information on the cause of the failure.
        /// </param>
        public BatchRequestOutput(
            string? id,
            string? customId,
            global::G.BatchRequestOutputResponse? response,
            global::G.BatchRequestOutputError? error)
        {
            this.Id = id;
            this.CustomId = customId;
            this.Response = response;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutput" /> class.
        /// </summary>
        public BatchRequestOutput()
        {
        }
    }
}