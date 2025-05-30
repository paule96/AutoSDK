﻿//HintName: G.Models.DependabotAlertSecurityAdvisoryCvss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the advisory pertaining to the Common Vulnerability Scoring System.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryCvss
    {
        /// <summary>
        /// The overall CVSS score of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double Score { get; set; } = default!;

        /// <summary>
        /// The full CVSS vector string for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_string")]
        public string? VectorString { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisoryCvss" /> class.
        /// </summary>
        /// <param name="score">
        /// The overall CVSS score of the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="vectorString">
        /// The full CVSS vector string for the advisory.<br/>
        /// Included only in responses
        /// </param>
        public DependabotAlertSecurityAdvisoryCvss(
            string? vectorString,
            double score = default!)
        {
            this.Score = score;
            this.VectorString = vectorString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisoryCvss" /> class.
        /// </summary>
        public DependabotAlertSecurityAdvisoryCvss()
        {
        }
    }
}