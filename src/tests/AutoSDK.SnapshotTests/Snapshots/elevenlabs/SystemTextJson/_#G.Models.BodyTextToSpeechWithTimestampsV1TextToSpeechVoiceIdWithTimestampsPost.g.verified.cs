﻿//HintName: G.Models.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost
    {
        /// <summary>
        /// The text that will get converted into speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_monolingual_v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Language code (ISO 639-1) used to enforce a language for the model. Currently only Turbo v2.5 supports language enforcement. For other models, an error will be returned if language code is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Voice settings overriding stored setttings for the given voice. They are applied only on the given request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public global::G.VoiceSettingsResponseModel? VoiceSettings { get; set; }

        /// <summary>
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorDBModel>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The text that came before the text of the current request. Can be used to improve the flow of prosody when concatenating together multiple generations or to influence the prosody in the current generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_text")]
        public string? PreviousText { get; set; }

        /// <summary>
        /// The text that comes after the text of the current request. Can be used to improve the flow of prosody when concatenating together multiple generations or to influence the prosody in the current generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_text")]
        public string? NextText { get; set; }

        /// <summary>
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the flow of prosody when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both previous_text and previous_request_ids is send, previous_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_request_ids")]
        public global::System.Collections.Generic.IList<string>? PreviousRequestIds { get; set; }

        /// <summary>
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the flow of prosody when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both next_text and next_request_ids is send, next_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_request_ids")]
        public global::System.Collections.Generic.IList<string>? NextRequestIds { get; set; }

        /// <summary>
        /// If true, we won't use PVC version of the voice for the generation but the IVC version. This is a temporary workaround for higher latency in PVC versions.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_pvc_as_ivc")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UsePvcAsIvc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost" /> class.
        /// </summary>
        /// <param name="text">
        /// The text that will get converted into speech.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_monolingual_v1
        /// </param>
        /// <param name="languageCode">
        /// Language code (ISO 639-1) used to enforce a language for the model. Currently only Turbo v2.5 supports language enforcement. For other models, an error will be returned if language code is provided.
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings overriding stored setttings for the given voice. They are applied only on the given request.
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request<br/>
        /// Default Value: []
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed.
        /// </param>
        /// <param name="previousText">
        /// The text that came before the text of the current request. Can be used to improve the flow of prosody when concatenating together multiple generations or to influence the prosody in the current generation.
        /// </param>
        /// <param name="nextText">
        /// The text that comes after the text of the current request. Can be used to improve the flow of prosody when concatenating together multiple generations or to influence the prosody in the current generation.
        /// </param>
        /// <param name="previousRequestIds">
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the flow of prosody when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both previous_text and previous_request_ids is send, previous_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="nextRequestIds">
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the flow of prosody when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both next_text and next_request_ids is send, next_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost(
            string text,
            string? modelId,
            string? languageCode,
            global::G.VoiceSettingsResponseModel? voiceSettings,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorDBModel>? pronunciationDictionaryLocators,
            int? seed,
            string? previousText,
            string? nextText,
            global::System.Collections.Generic.IList<string>? previousRequestIds,
            global::System.Collections.Generic.IList<string>? nextRequestIds)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ModelId = modelId;
            this.LanguageCode = languageCode;
            this.VoiceSettings = voiceSettings;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
            this.Seed = seed;
            this.PreviousText = previousText;
            this.NextText = nextText;
            this.PreviousRequestIds = previousRequestIds;
            this.NextRequestIds = nextRequestIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost" /> class.
        /// </summary>
        public BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost()
        {
        }
    }
}