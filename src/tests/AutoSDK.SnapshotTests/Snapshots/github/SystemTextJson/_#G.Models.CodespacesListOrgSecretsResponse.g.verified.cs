﻿//HintName: G.Models.CodespacesListOrgSecretsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesListOrgSecretsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CodespacesOrgSecret> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListOrgSecretsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesListOrgSecretsResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.CodespacesOrgSecret> secrets)
        {
            this.TotalCount = totalCount;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListOrgSecretsResponse" /> class.
        /// </summary>
        public CodespacesListOrgSecretsResponse()
        {
        }
    }
}