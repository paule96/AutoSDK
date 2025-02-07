﻿//HintName: G.Models.ScalingConfigPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tag type for marking schemas for patching.<br/>
    /// A Patchable schema is one used for updating other schemas.
    /// </summary>
    public sealed partial class ScalingConfigPatch
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScalingConfigTypeJsonConverter))]
        public global::G.ScalingConfigType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public object? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_nodes")]
        public int? MinimumNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_nodes")]
        public int? MaximumNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalingConfigPatch" /> class.
        /// </summary>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="args"></param>
        /// <param name="minimumNodes"></param>
        /// <param name="maximumNodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScalingConfigPatch(
            global::G.ScalingConfigType? type,
            object? args,
            int? minimumNodes,
            int? maximumNodes)
        {
            this.Type = type;
            this.Args = args;
            this.MinimumNodes = minimumNodes;
            this.MaximumNodes = maximumNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalingConfigPatch" /> class.
        /// </summary>
        public ScalingConfigPatch()
        {
        }
    }
}