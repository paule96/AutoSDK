﻿//HintName: G.IExamplesClient.UpdateExample.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::G.ExampleUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="attachmentsOperations"></param>
        /// <param name="metadata"></param>
        /// <param name="split"></param>
        /// <param name="overwrite">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::System.Guid? datasetId = default,
            object? inputs = default,
            object? outputs = default,
            global::G.AttachmentsOperations? attachmentsOperations = default,
            object? metadata = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? split = default,
            bool? overwrite = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}