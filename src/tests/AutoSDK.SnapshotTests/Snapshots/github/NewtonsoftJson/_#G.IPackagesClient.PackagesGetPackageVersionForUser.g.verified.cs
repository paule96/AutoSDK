﻿//HintName: G.IPackagesClient.PackagesGetPackageVersionForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Get a package version for a user<br/>
        /// Gets a specific package version for a public package owned by a specified user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="packageVersionId"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PackageVersion> PackagesGetPackageVersionForUserAsync(
            global::G.PackagesGetPackageVersionForUserPackageType packageType,
            string packageName,
            int packageVersionId,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}