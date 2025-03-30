﻿//HintName: G.Models.Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A general error response with an error code and message.
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// The messages describing why the error occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// The ID of the request that can be used to help Vectara support debug what went wrong.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="messages">
        /// The messages describing why the error occurred.
        /// </param>
        /// <param name="requestId">
        /// The ID of the request that can be used to help Vectara support debug what went wrong.
        /// </param>
        public Error(
            global::System.Collections.Generic.IList<string>? messages,
            string? requestId)
        {
            this.Messages = messages;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}