﻿//HintName: G.Models.BanUserBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BanUserBody
    {
        /// <summary>
        /// Identifies the user and type of ban.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BanUserBodyData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserBody" /> class.
        /// </summary>
        /// <param name="data">
        /// Identifies the user and type of ban.
        /// </param>
        public BanUserBody(
            global::G.BanUserBodyData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserBody" /> class.
        /// </summary>
        public BanUserBody()
        {
        }
    }
}