﻿//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuitePullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCheckSuiteRerequestedCheckSuitePullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCheckSuiteRerequestedCheckSuitePullRequestBase Base { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCheckSuiteRerequestedCheckSuitePullRequestHead Head { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRerequestedCheckSuitePullRequest" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="head"></param>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="url"></param>
        public WebhookCheckSuiteRerequestedCheckSuitePullRequest(
            global::G.WebhookCheckSuiteRerequestedCheckSuitePullRequestBase @base,
            global::G.WebhookCheckSuiteRerequestedCheckSuitePullRequestHead head,
            int id,
            int number,
            string url)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Head = head ?? throw new global::System.ArgumentNullException(nameof(head));
            this.Id = id;
            this.Number = number;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRerequestedCheckSuitePullRequest" /> class.
        /// </summary>
        public WebhookCheckSuiteRerequestedCheckSuitePullRequest()
        {
        }
    }
}