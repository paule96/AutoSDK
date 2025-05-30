﻿//HintName: G.Models.GetGenerationByIdResponseGenerationsByPkGenerationElementLora.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Element used for the generation.
    /// </summary>
    public sealed partial class GetGenerationByIdResponseGenerationsByPkGenerationElementLora
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("akUUID")]
        public global::G.Lora? AkUUID { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("baseModel")]
        public global::G.SdVersions? BaseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.Lora? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.Lora? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urlImage")]
        public global::G.Lora? UrlImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightDefault")]
        public global::G.Lora? WeightDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMax")]
        public global::G.Lora? WeightMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMin")]
        public global::G.Lora? WeightMin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGenerationElementLora" /> class.
        /// </summary>
        /// <param name="akUUID"></param>
        /// <param name="baseModel">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="urlImage"></param>
        /// <param name="weightDefault"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightMin"></param>
        public GetGenerationByIdResponseGenerationsByPkGenerationElementLora(
            global::G.Lora? akUUID,
            global::G.SdVersions? baseModel,
            global::G.Lora? description,
            global::G.Lora? name,
            global::G.Lora? urlImage,
            global::G.Lora? weightDefault,
            global::G.Lora? weightMax,
            global::G.Lora? weightMin)
        {
            this.AkUUID = akUUID;
            this.BaseModel = baseModel;
            this.Description = description;
            this.Name = name;
            this.UrlImage = urlImage;
            this.WeightDefault = weightDefault;
            this.WeightMax = weightMax;
            this.WeightMin = weightMin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGenerationElementLora" /> class.
        /// </summary>
        public GetGenerationByIdResponseGenerationsByPkGenerationElementLora()
        {
        }
    }
}