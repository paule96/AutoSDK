﻿//HintName: G.Models.TrainingTestMasterTagApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingTestMasterTagApp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trainingTestIDL")]
        public global::System.Guid? TrainingTestIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdOn")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trainingTagIDL")]
        public global::System.Guid? TrainingTagIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectIDL")]
        public global::System.Guid? ProjectIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trainingTestExcerptId")]
        public global::System.Guid? TrainingTestExcerptId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTestMasterTagApp" /> class.
        /// </summary>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="trainingTestIDL"></param>
        /// <param name="createdOn"></param>
        /// <param name="trainingTagIDL"></param>
        /// <param name="weight"></param>
        /// <param name="projectIDL"></param>
        /// <param name="trainingTestExcerptId"></param>
        public TrainingTestMasterTagApp(
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? trainingTestIDL,
            global::System.DateTime? createdOn,
            global::System.Guid? trainingTagIDL,
            double? weight,
            global::System.Guid? projectIDL,
            global::System.Guid? trainingTestExcerptId)
        {
            this.ProjectIdKey = projectIdKey;
            this.ProjectId = projectId;
            this.Id = id;
            this.TrainingTestIDL = trainingTestIDL;
            this.CreatedOn = createdOn;
            this.TrainingTagIDL = trainingTagIDL;
            this.Weight = weight;
            this.ProjectIDL = projectIDL;
            this.TrainingTestExcerptId = trainingTestExcerptId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTestMasterTagApp" /> class.
        /// </summary>
        public TrainingTestMasterTagApp()
        {
        }
    }
}