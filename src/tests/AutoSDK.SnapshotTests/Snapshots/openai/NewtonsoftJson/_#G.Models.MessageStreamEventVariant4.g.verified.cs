﻿//HintName: G.Models.MessageStreamEventVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [message](/docs/api-reference/messages/object) is completed.
    /// </summary>
    public sealed partial class MessageStreamEventVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.MessageStreamEventVariant4Event Event { get; set; }

        /// <summary>
        /// Represents a message within a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageObject Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant4" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a message within a [thread](/docs/api-reference/threads).
        /// </param>
        public MessageStreamEventVariant4(
            global::G.MessageObject data,
            global::G.MessageStreamEventVariant4Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant4" /> class.
        /// </summary>
        public MessageStreamEventVariant4()
        {
        }
    }
}