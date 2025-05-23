﻿//HintName: G.IImageClient.GenerativeUpscale.g.cs
#nullable enable

namespace G
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Generative Upscale
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProcessImageResponse> GenerativeUpscaleAsync(
            global::G.ProcessImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generative Upscale
        /// </summary>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProcessImageResponse> GenerativeUpscaleAsync(
            byte[] image,
            string imagename,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}