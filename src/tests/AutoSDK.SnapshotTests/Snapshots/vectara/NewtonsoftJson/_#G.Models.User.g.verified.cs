﻿//HintName: G.Models.User.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A user account with associated profile information and permissions.
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// The Vectara ID for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The email address for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The username for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Indicates whether the user is enabled or disabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The description of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// When the user was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When a user property was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The role names of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// What actions a principal can take on the Vectara platform.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_policy")]
        public global::G.ApiPolicy? ApiPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">
        /// The Vectara ID for the user.
        /// </param>
        /// <param name="email">
        /// The email address for the user.
        /// </param>
        /// <param name="username">
        /// The username for the user.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the user is enabled or disabled.
        /// </param>
        /// <param name="description">
        /// The description of the user.
        /// </param>
        /// <param name="createdAt">
        /// When the user was created.
        /// </param>
        /// <param name="updatedAt">
        /// When a user property was last updated.
        /// </param>
        /// <param name="apiRoles">
        /// The role names of the user.
        /// </param>
        /// <param name="apiPolicy">
        /// What actions a principal can take on the Vectara platform.
        /// </param>
        public User(
            string? id,
            string? email,
            string? username,
            bool? enabled,
            string? description,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles,
            global::G.ApiPolicy? apiPolicy)
        {
            this.Id = id;
            this.Email = email;
            this.Username = username;
            this.Enabled = enabled;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ApiRoles = apiRoles;
            this.ApiPolicy = apiPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}