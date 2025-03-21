﻿//HintName: G.Models.DoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a stream ends.
    /// </summary>
    public sealed partial class DoneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.DoneEventData Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.DoneEventEvent Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DoneEvent" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="event"></param>
        public DoneEvent(
            global::G.DoneEventData data,
            global::G.DoneEventEvent @event)
        {
            this.Data = data;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoneEvent" /> class.
        /// </summary>
        public DoneEvent()
        {
        }
    }
}