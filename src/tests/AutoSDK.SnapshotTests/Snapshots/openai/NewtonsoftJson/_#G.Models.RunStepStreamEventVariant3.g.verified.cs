﻿//HintName: G.Models.RunStepStreamEventVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when parts of a [run step](/docs/api-reference/run-steps/step-object) are being streamed.
    /// </summary>
    public sealed partial class RunStepStreamEventVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.RunStepStreamEventVariant3Event Event { get; set; }

        /// <summary>
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDeltaObject Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant3" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </param>
        public RunStepStreamEventVariant3(
            global::G.RunStepDeltaObject data,
            global::G.RunStepStreamEventVariant3Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant3" /> class.
        /// </summary>
        public RunStepStreamEventVariant3()
        {
        }
    }
}