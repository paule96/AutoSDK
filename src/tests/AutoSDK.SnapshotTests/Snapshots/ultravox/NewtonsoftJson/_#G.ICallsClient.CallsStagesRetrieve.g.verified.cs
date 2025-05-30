﻿//HintName: G.ICallsClient.CallsStagesRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callStageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallStage> CallsStagesRetrieveAsync(
            global::System.Guid callId,
            global::System.Guid callStageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}