﻿//HintName: G.Models.ConnectorsDataSources.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorsDataSources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_sources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DataSourceMetadata> DataSources { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsDataSources" /> class.
        /// </summary>
        /// <param name="dataSources"></param>
        public ConnectorsDataSources(
            global::System.Collections.Generic.IList<global::G.DataSourceMetadata> dataSources)
        {
            this.DataSources = dataSources ?? throw new global::System.ArgumentNullException(nameof(dataSources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsDataSources" /> class.
        /// </summary>
        public ConnectorsDataSources()
        {
        }
    }
}