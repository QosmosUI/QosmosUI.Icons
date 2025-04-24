// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

namespace QosmosUI.Icons.Generator.Models;

/// <summary>
/// Represents a tree structure for an icon.
/// </summary>
public sealed class IconTree
{
    /// <summary>
    /// Gets or sets the tag name of the icon tree node (e.g., "svg", "path").
    /// </summary>
    public required string Tag { get; init; }

    /// <summary>
    /// Gets or sets the attributes of the icon tree node as key-value pairs.
    /// </summary>
    public required Dictionary<string, string> Attributes { get; init; }

    /// <summary>
    /// Gets or sets the child nodes of the icon tree.
    /// </summary>
    public required List<IconTree> Children { get; init; }
}
