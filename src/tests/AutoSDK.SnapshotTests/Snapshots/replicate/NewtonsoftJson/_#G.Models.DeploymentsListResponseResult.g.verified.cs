﻿//HintName: G.Models.DeploymentsListResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsListResponseResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_release")]
        public global::G.DeploymentsListResponseResultCurrentRelease? CurrentRelease { get; set; }

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The owner of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsListResponseResult" /> class.
        /// </summary>
        /// <param name="currentRelease"></param>
        /// <param name="name">
        /// The name of the deployment.
        /// </param>
        /// <param name="owner">
        /// The owner of the deployment.
        /// </param>
        public DeploymentsListResponseResult(
            global::G.DeploymentsListResponseResultCurrentRelease? currentRelease,
            string? name,
            string? owner)
        {
            this.CurrentRelease = currentRelease;
            this.Name = name;
            this.Owner = owner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsListResponseResult" /> class.
        /// </summary>
        public DeploymentsListResponseResult()
        {
        }
    }
}