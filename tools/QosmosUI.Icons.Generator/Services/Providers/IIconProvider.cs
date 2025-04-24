// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Providers;

/// <summary>
/// Defines a provider for retrieving icon metadata.
/// </summary>
public interface IIconProvider
{
    /// <summary>
    /// Retrieves a collection of icon metadata.
    /// </summary>
    /// <returns>An enumerable collection of <see cref="IconMetadata"/> objects representing the icons.</returns>
    IEnumerable<IconMetadata> GetIcons();
}
