﻿//HintName: G.Models.BodyUpdatePronunciationDictionariesV1ProjectsProjectIdUpdatePronunciationDictionariesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdatePronunciationDictionariesV1ProjectsProjectIdUpdatePronunciationDictionariesPost
    {
        /// <summary>
        /// A list of pronunciation dictionary locators (pronunciation_dictionary_id, version_id) encoded as a list of JSON strings for pronunciation dictionaries to be applied to the text. A list of json encoded strings is required as adding projects may occur through formData as opposed to jsonBody. To specify multiple dictionaries use multiple --form lines in your curl, such as --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"Vmd4Zor6fplcA7WrINey\",\"version_id\":\"hRPaxjlTdR7wFMhV4w0b\"}"' --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"JzWtcGQMJ6bnlWwyMo7e\",\"version_id\":\"lbmwxiLu4q6txYxgdZqn\"}"'. Note that multiple dictionaries are not currently supported by our UI which will only show the first.<br/>
        /// Example: [{"pronunciation_dictionary_id": "test", "version_id": "id2"}]
        /// </summary>
        /// <example>[{"pronunciation_dictionary_id": "test", "version_id": "id2"}]</example>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary_locators", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorDBModel> PronunciationDictionaryLocators { get; set; } = default!;

        /// <summary>
        /// This will automatically mark text in this project for reconversion when the new dictionary applies or the old one no longer does.<br/>
        /// Default Value: true<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("invalidate_affected_text")]
        public bool? InvalidateAffectedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePronunciationDictionariesV1ProjectsProjectIdUpdatePronunciationDictionariesPost" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (pronunciation_dictionary_id, version_id) encoded as a list of JSON strings for pronunciation dictionaries to be applied to the text. A list of json encoded strings is required as adding projects may occur through formData as opposed to jsonBody. To specify multiple dictionaries use multiple --form lines in your curl, such as --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"Vmd4Zor6fplcA7WrINey\",\"version_id\":\"hRPaxjlTdR7wFMhV4w0b\"}"' --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"JzWtcGQMJ6bnlWwyMo7e\",\"version_id\":\"lbmwxiLu4q6txYxgdZqn\"}"'. Note that multiple dictionaries are not currently supported by our UI which will only show the first.<br/>
        /// Example: [{"pronunciation_dictionary_id": "test", "version_id": "id2"}]
        /// </param>
        /// <param name="invalidateAffectedText">
        /// This will automatically mark text in this project for reconversion when the new dictionary applies or the old one no longer does.<br/>
        /// Default Value: true<br/>
        /// Example: false
        /// </param>
        public BodyUpdatePronunciationDictionariesV1ProjectsProjectIdUpdatePronunciationDictionariesPost(
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorDBModel> pronunciationDictionaryLocators,
            bool? invalidateAffectedText)
        {
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryLocators));
            this.InvalidateAffectedText = invalidateAffectedText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePronunciationDictionariesV1ProjectsProjectIdUpdatePronunciationDictionariesPost" /> class.
        /// </summary>
        public BodyUpdatePronunciationDictionariesV1ProjectsProjectIdUpdatePronunciationDictionariesPost()
        {
        }
    }
}