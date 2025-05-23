﻿//HintName: G.Models.ObjectsGetResponseVariant3Result.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results for this specific Object.
    /// </summary>
    public sealed partial class ObjectsGetResponseVariant3Result
    {
        /// <summary>
        /// Default Value: SUCCESS
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ObjectsGetResponseVariant3ResultStatus? Status { get; set; }

        /// <summary>
        /// An error response given by Weaviate end-points.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::G.ErrorResponse? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsGetResponseVariant3Result" /> class.
        /// </summary>
        /// <param name="status">
        /// Default Value: SUCCESS
        /// </param>
        /// <param name="errors">
        /// An error response given by Weaviate end-points.
        /// </param>
        public ObjectsGetResponseVariant3Result(
            global::G.ObjectsGetResponseVariant3ResultStatus? status,
            global::G.ErrorResponse? errors)
        {
            this.Status = status;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsGetResponseVariant3Result" /> class.
        /// </summary>
        public ObjectsGetResponseVariant3Result()
        {
        }
    }
}