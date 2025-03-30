﻿//HintName: G.Models.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDeleteExistingInvitationV1WorkspaceInvitesDelete
    {
        /// <summary>
        /// The email of the customer<br/>
        /// Example: john.doe@testmail.com
        /// </summary>
        /// <example>john.doe@testmail.com</example>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteExistingInvitationV1WorkspaceInvitesDelete" /> class.
        /// </summary>
        /// <param name="email">
        /// The email of the customer<br/>
        /// Example: john.doe@testmail.com
        /// </param>
        public BodyDeleteExistingInvitationV1WorkspaceInvitesDelete(
            string email)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteExistingInvitationV1WorkspaceInvitesDelete" /> class.
        /// </summary>
        public BodyDeleteExistingInvitationV1WorkspaceInvitesDelete()
        {
        }
    }
}