﻿//HintName: G.Models.ActionsSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set secrets for GitHub Actions.
    /// </summary>
    public sealed partial class ActionsSecret
    {
        /// <summary>
        /// The name of the secret.<br/>
        /// Example: SECRET_TOKEN
        /// </summary>
        /// <example>SECRET_TOKEN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSecret" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the secret.<br/>
        /// Example: SECRET_TOKEN
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsSecret(
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSecret" /> class.
        /// </summary>
        public ActionsSecret()
        {
        }
    }
}