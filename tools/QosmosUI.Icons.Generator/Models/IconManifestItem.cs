// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

namespace QosmosUI.Icons.Generator.Models;

/// <summary>
/// Represents an item in the icon manifest.
/// </summary>
public sealed class IconManifestItem
{
    /// <summary>
    /// Gets the unique identifier for the icon set.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Gets the name of the icon set.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Gets the name of the project associated with the icon set.
    /// </summary>
    public required string ProjectName { get; init; }

    /// <summary>
    /// Gets the URL of the project associated with the icon set.
    /// </summary>
    public required string ProjectUrl { get; init; }

    /// <summary>
    /// Gets the URL of the license under which the icon set is distributed.
    /// </summary>
    public required string LicenseUrl { get; init; }

    /// <summary>
    /// Gets the name or type of the license under which the icon set is distributed.
    /// </summary>
    public required string License { get; init; }

    /// <summary>
    /// Gets the total number of icons in the icon set.
    /// </summary>
    public required int IconsCount { get; init; }
}
