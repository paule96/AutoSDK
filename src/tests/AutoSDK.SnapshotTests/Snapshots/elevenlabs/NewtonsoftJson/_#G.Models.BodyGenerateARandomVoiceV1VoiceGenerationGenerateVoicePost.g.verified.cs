﻿//HintName: G.Models.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost
    {
        /// <summary>
        /// Category code corresponding to the gender of the generated voice. Possible values: female, male.<br/>
        /// Example: female
        /// </summary>
        /// <example>female</example>
        [global::Newtonsoft.Json.JsonProperty("gender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender Gender { get; set; } = default!;

        /// <summary>
        /// Category code corresponding to the accent of the generated voice. Possible values: british, american, african, australian, indian.<br/>
        /// Example: british
        /// </summary>
        /// <example>british</example>
        [global::Newtonsoft.Json.JsonProperty("accent", Required = global::Newtonsoft.Json.Required.Always)]
        public string Accent { get; set; } = default!;

        /// <summary>
        /// Category code corresponding to the age of the generated voice. Possible values: young, middle_aged, old.<br/>
        /// Example: young
        /// </summary>
        /// <example>young</example>
        [global::Newtonsoft.Json.JsonProperty("age", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge Age { get; set; } = default!;

        /// <summary>
        /// The strength of the accent of the generated voice. Has to be between 0.3 and 2.0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent_strength", Required = global::Newtonsoft.Json.Required.Always)]
        public double AccentStrength { get; set; } = default!;

        /// <summary>
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </summary>
        /// <example>Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost" /> class.
        /// </summary>
        /// <param name="gender">
        /// Category code corresponding to the gender of the generated voice. Possible values: female, male.<br/>
        /// Example: female
        /// </param>
        /// <param name="accent">
        /// Category code corresponding to the accent of the generated voice. Possible values: british, american, african, australian, indian.<br/>
        /// Example: british
        /// </param>
        /// <param name="age">
        /// Category code corresponding to the age of the generated voice. Possible values: young, middle_aged, old.<br/>
        /// Example: young
        /// </param>
        /// <param name="accentStrength">
        /// The strength of the accent of the generated voice. Has to be between 0.3 and 2.0.
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </param>
        public BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost(
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender gender,
            string accent,
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge age,
            double accentStrength,
            string text)
        {
            this.Gender = gender;
            this.Accent = accent ?? throw new global::System.ArgumentNullException(nameof(accent));
            this.Age = age;
            this.AccentStrength = accentStrength;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost" /> class.
        /// </summary>
        public BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost()
        {
        }
    }
}