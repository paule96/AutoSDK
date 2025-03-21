﻿//HintName: G.Models.ErrorEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when an [error](/docs/guides/error-codes#api-errors) occurs. This can happen due to an internal server error or a timeout.
    /// </summary>
    public sealed partial class ErrorEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.ErrorEventEvent Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Error Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data"></param>
        public ErrorEvent(
            global::G.Error data,
            global::G.ErrorEventEvent @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        public ErrorEvent()
        {
        }
    }
}