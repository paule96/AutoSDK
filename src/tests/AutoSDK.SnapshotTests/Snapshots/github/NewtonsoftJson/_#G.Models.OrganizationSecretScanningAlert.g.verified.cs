﻿//HintName: G.Models.OrganizationSecretScanningAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationSecretScanningAlert
    {
        /// <summary>
        /// The security alert number.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number")]
        public int? Number { get; set; }

        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// The REST API URL of the code locations for this alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locations_url")]
        public string? LocationsUrl { get; set; }

        /// <summary>
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.SecretScanningAlertState? State { get; set; }

        /// <summary>
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolution")]
        public global::G.SecretScanningAlertResolution? Resolution { get; set; }

        /// <summary>
        /// The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolved_at")]
        public global::System.DateTime? ResolvedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolved_by")]
        public global::G.NullableSimpleUser? ResolvedBy { get; set; }

        /// <summary>
        /// The type of secret that secret scanning detected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_type")]
        public string? SecretType { get; set; }

        /// <summary>
        /// User-friendly name for the detected secret, matching the `secret_type`.<br/>
        /// For a list of built-in patterns, see "[Supported secret scanning patterns](https://docs.github.com/code-security/secret-scanning/introduction/supported-secret-scanning-patterns#supported-secrets)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_type_display_name")]
        public string? SecretTypeDisplayName { get; set; }

        /// <summary>
        /// The secret that was detected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.SimpleRepository? Repository { get; set; }

        /// <summary>
        /// Whether push protection was bypassed for the detected secret.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("push_protection_bypassed")]
        public bool? PushProtectionBypassed { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("push_protection_bypassed_by")]
        public global::G.NullableSimpleUser? PushProtectionBypassedBy { get; set; }

        /// <summary>
        /// The time that push protection was bypassed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("push_protection_bypassed_at")]
        public global::System.DateTime? PushProtectionBypassedAt { get; set; }

        /// <summary>
        /// The comment that was optionally added when this alert was closed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolution_comment")]
        public string? ResolutionComment { get; set; }

        /// <summary>
        /// The token status as of the latest validity check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validity")]
        public global::G.OrganizationSecretScanningAlertValidity? Validity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSecretScanningAlert" /> class.
        /// </summary>
        /// <param name="number">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="locationsUrl">
        /// The REST API URL of the code locations for this alert.
        /// </param>
        /// <param name="state">
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </param>
        /// <param name="resolution">
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </param>
        /// <param name="resolvedAt">
        /// The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="resolvedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="secretType">
        /// The type of secret that secret scanning detected.
        /// </param>
        /// <param name="secretTypeDisplayName">
        /// User-friendly name for the detected secret, matching the `secret_type`.<br/>
        /// For a list of built-in patterns, see "[Supported secret scanning patterns](https://docs.github.com/code-security/secret-scanning/introduction/supported-secret-scanning-patterns#supported-secrets)."
        /// </param>
        /// <param name="secret">
        /// The secret that was detected.
        /// </param>
        /// <param name="repository">
        /// A GitHub repository.
        /// </param>
        /// <param name="pushProtectionBypassed">
        /// Whether push protection was bypassed for the detected secret.
        /// </param>
        /// <param name="pushProtectionBypassedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="pushProtectionBypassedAt">
        /// The time that push protection was bypassed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="resolutionComment">
        /// The comment that was optionally added when this alert was closed
        /// </param>
        /// <param name="validity">
        /// The token status as of the latest validity check.
        /// </param>
        public OrganizationSecretScanningAlert(
            int? number,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? url,
            string? htmlUrl,
            string? locationsUrl,
            global::G.SecretScanningAlertState? state,
            global::G.SecretScanningAlertResolution? resolution,
            global::System.DateTime? resolvedAt,
            global::G.NullableSimpleUser? resolvedBy,
            string? secretType,
            string? secretTypeDisplayName,
            string? secret,
            global::G.SimpleRepository? repository,
            bool? pushProtectionBypassed,
            global::G.NullableSimpleUser? pushProtectionBypassedBy,
            global::System.DateTime? pushProtectionBypassedAt,
            string? resolutionComment,
            global::G.OrganizationSecretScanningAlertValidity? validity)
        {
            this.Number = number;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.LocationsUrl = locationsUrl;
            this.State = state;
            this.Resolution = resolution;
            this.ResolvedAt = resolvedAt;
            this.ResolvedBy = resolvedBy;
            this.SecretType = secretType;
            this.SecretTypeDisplayName = secretTypeDisplayName;
            this.Secret = secret;
            this.Repository = repository;
            this.PushProtectionBypassed = pushProtectionBypassed;
            this.PushProtectionBypassedBy = pushProtectionBypassedBy;
            this.PushProtectionBypassedAt = pushProtectionBypassedAt;
            this.ResolutionComment = resolutionComment;
            this.Validity = validity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSecretScanningAlert" /> class.
        /// </summary>
        public OrganizationSecretScanningAlert()
        {
        }
    }
}