﻿//HintName: G.Models.AuditLogProjectUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogProjectUpdated
    {
        /// <summary>
        /// The payload used to update the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes_requested")]
        public global::G.AuditLogProjectUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// The project ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectUpdated" /> class.
        /// </summary>
        /// <param name="changesRequested">
        /// The payload used to update the project.
        /// </param>
        /// <param name="id">
        /// The project ID.
        /// </param>
        public AuditLogProjectUpdated(
            global::G.AuditLogProjectUpdatedChangesRequested? changesRequested,
            string? id)
        {
            this.ChangesRequested = changesRequested;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectUpdated" /> class.
        /// </summary>
        public AuditLogProjectUpdated()
        {
        }
    }
}