﻿//HintName: G.Models.VoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SampleResponseModel> Samples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceResponseModelCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceResponseModelCategory Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuningResponseModel FineTuning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_for_tiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvailableForTiers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceSettingsResponseModel Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceSharingResponseModel Sharing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_quality_base_model_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> HighQualityBaseModelIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceResponseModelSafetyControlJsonConverter))]
        public global::G.VoiceResponseModelSafetyControl? SafetyControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_verification")]
        public global::G.VoiceVerificationResponseModel? VoiceVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_on_resource")]
        public string? PermissionOnResource { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_legacy")]
        public bool? IsLegacy { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_mixed")]
        public bool? IsMixed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="name"></param>
        /// <param name="samples"></param>
        /// <param name="category"></param>
        /// <param name="fineTuning"></param>
        /// <param name="labels"></param>
        /// <param name="description"></param>
        /// <param name="previewUrl"></param>
        /// <param name="availableForTiers"></param>
        /// <param name="settings"></param>
        /// <param name="sharing"></param>
        /// <param name="highQualityBaseModelIds"></param>
        /// <param name="safetyControl"></param>
        /// <param name="voiceVerification"></param>
        /// <param name="permissionOnResource"></param>
        /// <param name="isLegacy">
        /// Default Value: false
        /// </param>
        /// <param name="isMixed">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceResponseModel(
            string voiceId,
            string name,
            global::System.Collections.Generic.IList<global::G.SampleResponseModel> samples,
            global::G.VoiceResponseModelCategory category,
            global::G.FineTuningResponseModel fineTuning,
            global::System.Collections.Generic.Dictionary<string, string> labels,
            string description,
            string previewUrl,
            global::System.Collections.Generic.IList<string> availableForTiers,
            global::G.VoiceSettingsResponseModel settings,
            global::G.VoiceSharingResponseModel sharing,
            global::System.Collections.Generic.IList<string> highQualityBaseModelIds,
            global::G.VoiceResponseModelSafetyControl? safetyControl,
            global::G.VoiceVerificationResponseModel? voiceVerification,
            string? permissionOnResource,
            bool? isLegacy,
            bool? isMixed)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Samples = samples ?? throw new global::System.ArgumentNullException(nameof(samples));
            this.Category = category;
            this.FineTuning = fineTuning ?? throw new global::System.ArgumentNullException(nameof(fineTuning));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PreviewUrl = previewUrl ?? throw new global::System.ArgumentNullException(nameof(previewUrl));
            this.AvailableForTiers = availableForTiers ?? throw new global::System.ArgumentNullException(nameof(availableForTiers));
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.Sharing = sharing ?? throw new global::System.ArgumentNullException(nameof(sharing));
            this.HighQualityBaseModelIds = highQualityBaseModelIds ?? throw new global::System.ArgumentNullException(nameof(highQualityBaseModelIds));
            this.SafetyControl = safetyControl;
            this.VoiceVerification = voiceVerification;
            this.PermissionOnResource = permissionOnResource;
            this.IsLegacy = isLegacy;
            this.IsMixed = isMixed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResponseModel" /> class.
        /// </summary>
        public VoiceResponseModel()
        {
        }
    }
}