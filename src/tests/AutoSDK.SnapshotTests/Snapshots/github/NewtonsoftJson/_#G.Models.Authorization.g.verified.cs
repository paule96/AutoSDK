﻿//HintName: G.Models.Authorization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authorization for an OAuth app, GitHub App, or a Personal Access Token.
    /// </summary>
    public sealed partial class Authorization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// A list of scopes that this authorization is in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scopes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_last_eight", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TokenLastEight { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hashed_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HashedToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorizationApp App { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Note { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? NoteUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fingerprint", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Fingerprint { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation")]
        public global::G.NullableScopedInstallation? Installation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="scopes">
        /// A list of scopes that this authorization is in.
        /// </param>
        /// <param name="token"></param>
        /// <param name="tokenLastEight"></param>
        /// <param name="hashedToken"></param>
        /// <param name="app"></param>
        /// <param name="note"></param>
        /// <param name="noteUrl"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="fingerprint"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="installation"></param>
        /// <param name="expiresAt"></param>
        public Authorization(
            long id,
            string url,
            global::System.Collections.Generic.IList<string>? scopes,
            string token,
            string? tokenLastEight,
            string? hashedToken,
            global::G.AuthorizationApp app,
            string? note,
            string? noteUrl,
            global::System.DateTime updatedAt,
            global::System.DateTime createdAt,
            string? fingerprint,
            global::System.DateTime? expiresAt,
            global::G.NullableSimpleUser? user,
            global::G.NullableScopedInstallation? installation)
        {
            this.Id = id;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.TokenLastEight = tokenLastEight ?? throw new global::System.ArgumentNullException(nameof(tokenLastEight));
            this.HashedToken = hashedToken ?? throw new global::System.ArgumentNullException(nameof(hashedToken));
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
            this.NoteUrl = noteUrl ?? throw new global::System.ArgumentNullException(nameof(noteUrl));
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Fingerprint = fingerprint ?? throw new global::System.ArgumentNullException(nameof(fingerprint));
            this.ExpiresAt = expiresAt;
            this.User = user;
            this.Installation = installation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization" /> class.
        /// </summary>
        public Authorization()
        {
        }
    }
}