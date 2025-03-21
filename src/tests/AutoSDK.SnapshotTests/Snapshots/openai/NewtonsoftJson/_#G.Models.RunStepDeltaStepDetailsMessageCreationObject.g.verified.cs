﻿//HintName: G.Models.RunStepDeltaStepDetailsMessageCreationObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the message creation by the run step.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsMessageCreationObject
    {
        /// <summary>
        /// Always `message_creation`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDeltaStepDetailsMessageCreationObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_creation")]
        public global::G.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? MessageCreation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsMessageCreationObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `message_creation`.
        /// </param>
        /// <param name="messageCreation"></param>
        public RunStepDeltaStepDetailsMessageCreationObject(
            global::G.RunStepDeltaStepDetailsMessageCreationObjectType type,
            global::G.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? messageCreation)
        {
            this.Type = type;
            this.MessageCreation = messageCreation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsMessageCreationObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsMessageCreationObject()
        {
        }
    }
}