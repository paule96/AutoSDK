﻿//HintName: G.Models.RunStepDeltaStepDetailsToolCallsObject.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the tool call.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsObject
    {
        /// <summary>
        /// Always `tool_calls`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDeltaStepDetailsToolCallsObjectType Type { get; set; }

        /// <summary>
        /// An array of tool calls the run step was involved in. These can be associated with one of three types of tools: `code_interpreter`, `file_search`, or `function`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.RunStepDeltaStepDetailsToolCallsCodeObject, global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::G.RunStepDeltaStepDetailsToolCallsFunctionObject>>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `tool_calls`.
        /// </param>
        /// <param name="toolCalls">
        /// An array of tool calls the run step was involved in. These can be associated with one of three types of tools: `code_interpreter`, `file_search`, or `function`.
        /// </param>
        public RunStepDeltaStepDetailsToolCallsObject(
            global::G.RunStepDeltaStepDetailsToolCallsObjectType type,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.RunStepDeltaStepDetailsToolCallsCodeObject, global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::G.RunStepDeltaStepDetailsToolCallsFunctionObject>>? toolCalls)
        {
            this.Type = type;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsObject()
        {
        }
    }
}