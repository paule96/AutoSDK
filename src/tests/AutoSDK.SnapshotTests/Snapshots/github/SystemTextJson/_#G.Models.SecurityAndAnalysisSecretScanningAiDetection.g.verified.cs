﻿//HintName: G.Models.SecurityAndAnalysisSecretScanningAiDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityAndAnalysisSecretScanningAiDetection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SecurityAndAnalysisSecretScanningAiDetectionStatusJsonConverter))]
        public global::G.SecurityAndAnalysisSecretScanningAiDetectionStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningAiDetection" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityAndAnalysisSecretScanningAiDetection(
            global::G.SecurityAndAnalysisSecretScanningAiDetectionStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningAiDetection" /> class.
        /// </summary>
        public SecurityAndAnalysisSecretScanningAiDetection()
        {
        }
    }
}