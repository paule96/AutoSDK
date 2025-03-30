﻿//HintName: G.Models.PlaygroundSettingsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundSettingsCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings", Required = global::Newtonsoft.Json.Required.Always)]
        public object Settings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.PlaygroundSavedOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsCreateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="settings"></param>
        /// <param name="options"></param>
        public PlaygroundSettingsCreateRequest(
            object settings,
            string? name,
            string? description,
            global::G.PlaygroundSavedOptions? options)
        {
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.Name = name;
            this.Description = description;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsCreateRequest" /> class.
        /// </summary>
        public PlaygroundSettingsCreateRequest()
        {
        }
    }
}