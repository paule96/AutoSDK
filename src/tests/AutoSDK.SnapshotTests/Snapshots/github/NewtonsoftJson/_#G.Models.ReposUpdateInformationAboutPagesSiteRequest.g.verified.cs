﻿//HintName: G.Models.ReposUpdateInformationAboutPagesSiteRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateInformationAboutPagesSiteRequest
    {
        /// <summary>
        /// Specify a custom domain for the repository. Sending a `null` value will remove the custom domain. For more about custom domains, see "[Using a custom domain with GitHub Pages](https://docs.github.com/pages/configuring-a-custom-domain-for-your-github-pages-site)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cname")]
        public string? Cname { get; set; }

        /// <summary>
        /// Specify whether HTTPS should be enforced for the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("https_enforced")]
        public bool? HttpsEnforced { get; set; }

        /// <summary>
        /// The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("build_type")]
        public global::G.ReposUpdateInformationAboutPagesSiteRequestBuildType? BuildType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.AnyOf<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum?, global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2>? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInformationAboutPagesSiteRequest" /> class.
        /// </summary>
        /// <param name="cname">
        /// Specify a custom domain for the repository. Sending a `null` value will remove the custom domain. For more about custom domains, see "[Using a custom domain with GitHub Pages](https://docs.github.com/pages/configuring-a-custom-domain-for-your-github-pages-site)."
        /// </param>
        /// <param name="httpsEnforced">
        /// Specify whether HTTPS should be enforced for the repository.
        /// </param>
        /// <param name="buildType">
        /// The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.
        /// </param>
        /// <param name="source"></param>
        public ReposUpdateInformationAboutPagesSiteRequest(
            string? cname,
            bool? httpsEnforced,
            global::G.ReposUpdateInformationAboutPagesSiteRequestBuildType? buildType,
            global::G.AnyOf<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum?, global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2>? source)
        {
            this.Cname = cname;
            this.HttpsEnforced = httpsEnforced;
            this.BuildType = buildType;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInformationAboutPagesSiteRequest" /> class.
        /// </summary>
        public ReposUpdateInformationAboutPagesSiteRequest()
        {
        }
    }
}