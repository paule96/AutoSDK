﻿//HintName: G.IModelsClient.ListRunningModels.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List models that are running.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProcessResponse> ListRunningModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}