﻿//HintName: G.Models.DependentUnknownAgentToolIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model that represents an tool dependent on a knowledge base/tools<br/>
    /// to which the user has no direct access.
    /// </summary>
    public sealed partial class DependentUnknownAgentToolIdentifier
    {
        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DependentUnknownAgentToolIdentifierType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownAgentToolIdentifier" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: unknown
        /// </param>
        public DependentUnknownAgentToolIdentifier(
            global::G.DependentUnknownAgentToolIdentifierType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownAgentToolIdentifier" /> class.
        /// </summary>
        public DependentUnknownAgentToolIdentifier()
        {
        }
    }
}