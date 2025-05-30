﻿//HintName: G.Models.DeleteEvalResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteEvalResponse
    {
        /// <summary>
        /// Example: eval.deleted
        /// </summary>
        /// <example>eval.deleted</example>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Example: eval_abc123
        /// </summary>
        /// <example>eval_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("eval_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvalId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEvalResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: eval.deleted
        /// </param>
        /// <param name="deleted">
        /// Example: true
        /// </param>
        /// <param name="evalId">
        /// Example: eval_abc123
        /// </param>
        public DeleteEvalResponse(
            string @object,
            bool deleted,
            string evalId)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Deleted = deleted;
            this.EvalId = evalId ?? throw new global::System.ArgumentNullException(nameof(evalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEvalResponse" /> class.
        /// </summary>
        public DeleteEvalResponse()
        {
        }
    }
}