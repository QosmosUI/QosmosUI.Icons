// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

namespace QosmosUI.Icons.Generator.Models;

/// <summary>
/// Delegate that defines a method to generate a name pattern for an icon.
/// </summary>
/// <param name="filePath">The file path of the icon.</param>
/// <param name="fileName">The file name of the icon.</param>
/// <returns>A string representing the generated name pattern.</returns>
public delegate string NamePatternDelegate(string filePath, string fileName);

/// <summary>
/// Represents a set of icons with associated metadata and configuration.
/// </summary>
public sealed class IconSet
{
    /// <summary>
    /// Gets or sets the name of the icon set.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Gets or sets the glob pattern used to match icon files.
    /// </summary>
    public required string GlobPattern { get; init; }

    /// <summary>
    /// Gets or sets the delegate used to generate name patterns for icons.
    /// </summary>
    public required NamePatternDelegate NamePattern { get; init; }

    /// <summary>
    /// Gets or sets a value indicating whether SVGO optimization is enabled.
    /// </summary>
    public bool Svgo { get; init; }

    /// <summary>
    /// Gets or sets a value indicating whether the icon set supports multiple colors.
    /// </summary>
    public bool MultiColor { get; init; }

    /// <summary>
    /// Gets or sets the patterns used to exclude certain icon files from processing.
    /// </summary>
    public string[]? ExcludePatterns { get; init; }
}
