﻿//HintName: G.IExportClient.GetExportJobURI.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// GetExportJobURI<br/>
        /// GetExportJobURI
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportJobURIAsync(
            global::G.GetExportJobURIRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetExportJobURI<br/>
        /// GetExportJobURI
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportJobURIAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}