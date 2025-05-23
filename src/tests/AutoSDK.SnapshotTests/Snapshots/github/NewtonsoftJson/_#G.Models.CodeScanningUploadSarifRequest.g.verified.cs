﻿//HintName: G.Models.CodeScanningUploadSarifRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningUploadSarifRequest
    {
        /// <summary>
        /// The SHA of the commit to which the analysis you are uploading relates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitSha { get; set; } = default!;

        /// <summary>
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`,<br/>
        /// `refs/tags/&lt;tag&gt;`, `refs/pull/&lt;number&gt;/merge`, or `refs/pull/&lt;number&gt;/head`.<br/>
        /// Example: refs/heads/main
        /// </summary>
        /// <example>refs/heads/main</example>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// A Base64 string representing the SARIF file to upload. You must first compress your SARIF file using [`gzip`](http://www.gnu.org/software/gzip/manual/gzip.html) and then translate the contents of the file into a Base64 encoding string. For more information, see "[SARIF support for code scanning](https://docs.github.com/code-security/secure-coding/sarif-support-for-code-scanning)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sarif", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sarif { get; set; } = default!;

        /// <summary>
        /// The base directory used in the analysis, as it appears in the SARIF file.<br/>
        /// This property is used to convert file paths from absolute to relative, so that alerts can be mapped to their correct location in the repository.<br/>
        /// Example: file:///github/workspace/
        /// </summary>
        /// <example>file:///github/workspace/</example>
        [global::Newtonsoft.Json.JsonProperty("checkout_uri")]
        public string? CheckoutUri { get; set; }

        /// <summary>
        /// The time that the analysis run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The name of the tool used to generate the code scanning analysis. If this parameter is not used, the tool name defaults to "API". If the uploaded SARIF contains a tool GUID, this will be available for filtering using the `tool_guid` parameter of operations such as `GET /repos/{owner}/{repo}/code-scanning/alerts`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// Whether the SARIF file will be validated according to the code scanning specifications.<br/>
        /// This parameter is intended to help integrators ensure that the uploaded SARIF files are correctly rendered by code scanning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validate")]
        public bool? Validate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningUploadSarifRequest" /> class.
        /// </summary>
        /// <param name="commitSha">
        /// The SHA of the commit to which the analysis you are uploading relates.
        /// </param>
        /// <param name="ref">
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`,<br/>
        /// `refs/tags/&lt;tag&gt;`, `refs/pull/&lt;number&gt;/merge`, or `refs/pull/&lt;number&gt;/head`.<br/>
        /// Example: refs/heads/main
        /// </param>
        /// <param name="sarif">
        /// A Base64 string representing the SARIF file to upload. You must first compress your SARIF file using [`gzip`](http://www.gnu.org/software/gzip/manual/gzip.html) and then translate the contents of the file into a Base64 encoding string. For more information, see "[SARIF support for code scanning](https://docs.github.com/code-security/secure-coding/sarif-support-for-code-scanning)."
        /// </param>
        /// <param name="checkoutUri">
        /// The base directory used in the analysis, as it appears in the SARIF file.<br/>
        /// This property is used to convert file paths from absolute to relative, so that alerts can be mapped to their correct location in the repository.<br/>
        /// Example: file:///github/workspace/
        /// </param>
        /// <param name="startedAt">
        /// The time that the analysis run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="toolName">
        /// The name of the tool used to generate the code scanning analysis. If this parameter is not used, the tool name defaults to "API". If the uploaded SARIF contains a tool GUID, this will be available for filtering using the `tool_guid` parameter of operations such as `GET /repos/{owner}/{repo}/code-scanning/alerts`.
        /// </param>
        /// <param name="validate">
        /// Whether the SARIF file will be validated according to the code scanning specifications.<br/>
        /// This parameter is intended to help integrators ensure that the uploaded SARIF files are correctly rendered by code scanning.
        /// </param>
        public CodeScanningUploadSarifRequest(
            string commitSha,
            string @ref,
            string sarif,
            string? checkoutUri,
            global::System.DateTime? startedAt,
            string? toolName,
            bool? validate)
        {
            this.CommitSha = commitSha ?? throw new global::System.ArgumentNullException(nameof(commitSha));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Sarif = sarif ?? throw new global::System.ArgumentNullException(nameof(sarif));
            this.CheckoutUri = checkoutUri;
            this.StartedAt = startedAt;
            this.ToolName = toolName;
            this.Validate = validate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningUploadSarifRequest" /> class.
        /// </summary>
        public CodeScanningUploadSarifRequest()
        {
        }
    }
}