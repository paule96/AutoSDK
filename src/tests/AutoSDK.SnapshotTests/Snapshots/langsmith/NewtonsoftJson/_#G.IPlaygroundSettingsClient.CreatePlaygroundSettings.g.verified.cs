﻿//HintName: G.IPlaygroundSettingsClient.CreatePlaygroundSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// Create Playground Settings<br/>
        /// Create playground settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PlaygroundSettingsResponse> CreatePlaygroundSettingsAsync(
            global::G.PlaygroundSettingsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Playground Settings<br/>
        /// Create playground settings.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="settings"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PlaygroundSettingsResponse> CreatePlaygroundSettingsAsync(
            object settings,
            string? name = default,
            string? description = default,
            global::G.PlaygroundSavedOptions? options = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}