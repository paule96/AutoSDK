﻿//HintName: G.Models.WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public object? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest")]
        public object? Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadataTag? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata" /> class.
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="manifest"></param>
        /// <param name="tag"></param>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata(
            object? labels,
            object? manifest,
            global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadataTag? tag)
        {
            this.Labels = labels;
            this.Manifest = manifest;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata" /> class.
        /// </summary>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata()
        {
        }
    }
}