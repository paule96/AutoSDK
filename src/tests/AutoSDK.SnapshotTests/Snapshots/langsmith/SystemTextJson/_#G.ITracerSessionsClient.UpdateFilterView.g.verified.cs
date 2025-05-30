﻿//HintName: G.ITracerSessionsClient.UpdateFilterView.g.cs
#nullable enable

namespace G
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FilterView> UpdateFilterViewAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,
            global::G.FilterViewUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="filterString"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FilterView> UpdateFilterViewAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,
            string? filterString = default,
            string? displayName = default,
            string? description = default,
            string? traceFilterString = default,
            string? treeFilterString = default,
            global::G.FilterViewType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}