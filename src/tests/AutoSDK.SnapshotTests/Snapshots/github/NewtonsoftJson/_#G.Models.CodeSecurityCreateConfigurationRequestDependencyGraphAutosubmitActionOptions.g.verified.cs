﻿//HintName: G.Models.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feature options for Automatic dependency submission
    /// </summary>
    public sealed partial class CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions
    {
        /// <summary>
        /// Whether to use runners labeled with 'dependency-submission' or standard GitHub runners.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labeled_runners")]
        public bool? LabeledRunners { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions" /> class.
        /// </summary>
        /// <param name="labeledRunners">
        /// Whether to use runners labeled with 'dependency-submission' or standard GitHub runners.<br/>
        /// Default Value: false
        /// </param>
        public CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions(
            bool? labeledRunners)
        {
            this.LabeledRunners = labeledRunners;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions" /> class.
        /// </summary>
        public CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions()
        {
        }
    }
}