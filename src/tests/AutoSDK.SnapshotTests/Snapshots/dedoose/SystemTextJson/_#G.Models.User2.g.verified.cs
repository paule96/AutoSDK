﻿//HintName: G.Models.User2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class User2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passSalt")]
        public string? PassSalt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eulaStamp")]
        public global::System.DateTime? EulaStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminDisable")]
        public bool? AdminDisable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        public global::System.Guid? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastLogin")]
        public global::System.DateTime? LastLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changePass")]
        public bool? ChangePass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chagePassDate")]
        public global::System.DateTime? ChagePassDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isVerified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="passSalt"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="createStamp"></param>
        /// <param name="phone"></param>
        /// <param name="eulaStamp"></param>
        /// <param name="isActive"></param>
        /// <param name="adminDisable"></param>
        /// <param name="accountId"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="country"></param>
        /// <param name="zip"></param>
        /// <param name="lastLogin"></param>
        /// <param name="changePass"></param>
        /// <param name="chagePassDate"></param>
        /// <param name="isVerified"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public User2(
            global::System.Guid? id,
            string? username,
            string? passSalt,
            string? firstName,
            string? lastName,
            string? email,
            global::System.DateTime? createStamp,
            string? phone,
            global::System.DateTime? eulaStamp,
            bool? isActive,
            bool? adminDisable,
            global::System.Guid? accountId,
            string? address,
            string? city,
            string? state,
            string? country,
            string? zip,
            global::System.DateTime? lastLogin,
            bool? changePass,
            global::System.DateTime? chagePassDate,
            bool? isVerified)
        {
            this.Id = id;
            this.Username = username;
            this.PassSalt = passSalt;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.CreateStamp = createStamp;
            this.Phone = phone;
            this.EulaStamp = eulaStamp;
            this.IsActive = isActive;
            this.AdminDisable = adminDisable;
            this.AccountId = accountId;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Zip = zip;
            this.LastLogin = lastLogin;
            this.ChangePass = changePass;
            this.ChagePassDate = chagePassDate;
            this.IsVerified = isVerified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User2" /> class.
        /// </summary>
        public User2()
        {
        }
    }
}