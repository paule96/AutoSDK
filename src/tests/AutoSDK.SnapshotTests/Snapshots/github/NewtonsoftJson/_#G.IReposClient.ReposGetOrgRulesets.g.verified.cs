﻿//HintName: G.IReposClient.ReposGetOrgRulesets.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get all organization repository rulesets<br/>
        /// Get all the repository rulesets for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="targets">
        /// Example: branch,tag,push
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RepositoryRuleset>> ReposGetOrgRulesetsAsync(
            string org,
            int? perPage = default,
            int? page = default,
            string? targets = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}