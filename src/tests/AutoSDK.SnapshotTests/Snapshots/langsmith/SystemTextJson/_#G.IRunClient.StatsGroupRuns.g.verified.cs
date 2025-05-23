﻿//HintName: G.IRunClient.StatsGroupRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Stats Group Runs<br/>
        /// Get stats for the grouped runs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunGroupStats> StatsGroupRunsAsync(
            global::G.RunGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stats Group Runs<br/>
        /// Get stats for the grouped runs.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="groupBy"></param>
        /// <param name="filter"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunGroupStats> StatsGroupRunsAsync(
            global::System.Guid sessionId,
            global::G.RunGroupBy groupBy = default,
            string? filter = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? offset = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}