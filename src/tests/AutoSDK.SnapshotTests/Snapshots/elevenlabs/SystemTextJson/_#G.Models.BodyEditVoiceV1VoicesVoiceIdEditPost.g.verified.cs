﻿//HintName: G.Models.BodyEditVoiceV1VoicesVoiceIdEditPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditVoiceV1VoicesVoiceIdEditPost
    {
        /// <summary>
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.<br/>
        /// Example: John Smith
        /// </summary>
        /// <example>John Smith</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Audio files to add to the voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<byte[]>? Files { get; set; }

        /// <summary>
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_background_noise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// A description of the voice.<br/>
        /// Example: An old American male voice with a slight hoarseness in his throat. Perfect for news.
        /// </summary>
        /// <example>An old American male voice with a slight hoarseness in his throat. Perfect for news.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Serialized labels dictionary for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public string? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditVoiceV1VoicesVoiceIdEditPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.<br/>
        /// Example: John Smith
        /// </param>
        /// <param name="files">
        /// Audio files to add to the voice
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="description">
        /// A description of the voice.<br/>
        /// Example: An old American male voice with a slight hoarseness in his throat. Perfect for news.
        /// </param>
        /// <param name="labels">
        /// Serialized labels dictionary for the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyEditVoiceV1VoicesVoiceIdEditPost(
            string name,
            global::System.Collections.Generic.IList<byte[]>? files,
            bool? removeBackgroundNoise,
            string? description,
            string? labels)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Files = files;
            this.RemoveBackgroundNoise = removeBackgroundNoise;
            this.Description = description;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditVoiceV1VoicesVoiceIdEditPost" /> class.
        /// </summary>
        public BodyEditVoiceV1VoicesVoiceIdEditPost()
        {
        }
    }
}