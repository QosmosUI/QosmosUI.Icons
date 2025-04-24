// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using QosmosUI.Icons.Docs.Models;

namespace QosmosUI.Icons.Docs.Services.Icons;

/// <summary>
/// Defines the contract for an icon service that provides access to icon manifest items.
/// </summary>
public interface IIconService
{
    /// <summary>
    /// Retrieves a collection of icon manifest items.
    /// </summary>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> containing <see cref="IconManifestItem"/> objects.
    /// </returns>
    IEnumerable<IconManifestItem> GetManifests();
}
