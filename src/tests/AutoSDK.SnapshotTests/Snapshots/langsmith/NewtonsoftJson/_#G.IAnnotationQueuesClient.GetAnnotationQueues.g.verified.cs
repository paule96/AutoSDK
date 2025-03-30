﻿//HintName: G.IAnnotationQueuesClient.GetAnnotationQueues.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get Annotation Queues
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AnnotationQueueSchemaWithSize>> GetAnnotationQueuesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? ids = default,
            string? name = default,
            string? nameContains = default,
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Guid? datasetId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}