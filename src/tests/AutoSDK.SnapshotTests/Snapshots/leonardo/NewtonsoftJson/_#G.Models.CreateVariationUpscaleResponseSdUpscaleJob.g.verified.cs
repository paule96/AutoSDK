﻿//HintName: G.Models.CreateVariationUpscaleResponseSdUpscaleJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationUpscaleResponseSdUpscaleJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// API Credits Cost for Upscale Variation. Available for Production API Users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleResponseSdUpscaleJob" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apiCreditCost">
        /// API Credits Cost for Upscale Variation. Available for Production API Users.
        /// </param>
        public CreateVariationUpscaleResponseSdUpscaleJob(
            string? id,
            int? apiCreditCost)
        {
            this.Id = id;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleResponseSdUpscaleJob" /> class.
        /// </summary>
        public CreateVariationUpscaleResponseSdUpscaleJob()
        {
        }
    }
}