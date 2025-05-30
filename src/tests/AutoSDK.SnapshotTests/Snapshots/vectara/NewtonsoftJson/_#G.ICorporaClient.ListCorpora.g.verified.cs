﻿//HintName: G.ICorporaClient.ListCorpora.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// List corpora<br/>
        /// List corpora in the account. The returned corpus objects contain less<br/>
        /// detail compared to those retrieved the direct corpus retrieval operation.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="filter"></param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCorporaResponse> ListCorporaAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? filter = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}