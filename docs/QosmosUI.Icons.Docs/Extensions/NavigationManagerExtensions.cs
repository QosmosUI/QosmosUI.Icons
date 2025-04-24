// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;

namespace QosmosUI.Icons.Docs.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="NavigationManager"/> class.
/// </summary>
public static class NavigationManagerExtensions
{
    /// <summary>
    /// Determines whether the specified URI matches the current URI of the <see cref="NavigationManager"/>.
    /// </summary>
    /// <param name="navigationManager">The <see cref="NavigationManager"/> instance.</param>
    /// <param name="uri">The URI to compare with the current URI. Can be relative or absolute.</param>
    /// <returns>
    /// <c>true</c> if the specified URI matches the current URI; otherwise, <c>false</c>.
    /// </returns>
    /// <remarks>
    /// This method performs a case-insensitive comparison of the path and query components of the URIs.
    /// </remarks>
    public static bool IsMatch(this NavigationManager navigationManager, [StringSyntax(StringSyntaxAttribute.Uri)] string? uri)
    {
        if (string.IsNullOrEmpty(uri))
            return false;

        var uriPath = navigationManager.ToAbsoluteUri(uri).PathAndQuery;
        var currentPath = navigationManager.ToAbsoluteUri(navigationManager.Uri).PathAndQuery;

        return string.Equals(uriPath, currentPath, StringComparison.OrdinalIgnoreCase);
    }
}
