﻿//HintName: G.Models.AuditLogCheckpointPermissionDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogCheckpointPermissionDeleted
    {
        /// <summary>
        /// The ID of the checkpoint permission.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCheckpointPermissionDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the checkpoint permission.
        /// </param>
        public AuditLogCheckpointPermissionDeleted(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCheckpointPermissionDeleted" /> class.
        /// </summary>
        public AuditLogCheckpointPermissionDeleted()
        {
        }
    }
}