﻿//HintName: G.Models.IdentityCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentityCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_identity_id")]
        public global::System.Guid? OrgIdentityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreate" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="orgIdentityId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        public IdentityCreate(
            global::System.Guid? userId,
            global::System.Guid? orgIdentityId,
            bool? readOnly,
            global::System.Guid? roleId)
        {
            this.UserId = userId;
            this.OrgIdentityId = orgIdentityId;
            this.ReadOnly = readOnly;
            this.RoleId = roleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreate" /> class.
        /// </summary>
        public IdentityCreate()
        {
        }
    }
}