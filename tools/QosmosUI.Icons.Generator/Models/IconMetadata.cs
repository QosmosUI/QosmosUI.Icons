// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

namespace QosmosUI.Icons.Generator.Models;

/// <summary>
/// Represents metadata for an icon.
/// </summary>
public sealed class IconMetadata
{
    /// <summary>
    /// Gets or sets the unique identifier for the icon.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Gets or sets the name of the icon.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Gets or sets the name of the project associated with the icon.
    /// </summary>
    public required string ProjectName { get; init; }

    /// <summary>
    /// Gets or sets the URL of the project associated with the icon.
    /// </summary>
    public required string ProjectUrl { get; init; }

    /// <summary>
    /// Gets or sets the URL of the license associated with the icon.
    /// </summary>
    public required string LicenseUrl { get; init; }

    /// <summary>
    /// Gets or sets the license type or name associated with the icon.
    /// </summary>
    public required string License { get; init; }

    /// <summary>
    /// Gets or sets the source information of the icon.
    /// </summary>
    public required IconSource Source { get; init; }

    /// <summary>
    /// Gets or sets the collection of icon sets associated with the icon.
    /// </summary>
    public required IEnumerable<IconSet> Sets { get; init; }
}
