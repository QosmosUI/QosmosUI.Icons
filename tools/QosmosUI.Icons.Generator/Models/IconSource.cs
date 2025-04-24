// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

namespace QosmosUI.Icons.Generator.Models;

/// <summary>
/// Represents the source of an icon.
/// </summary>
public sealed class IconSource
{
    /// <summary>
    /// Gets or sets the Git repository URL of the icon source.
    /// </summary>
    public required string Git { get; init; }

    /// <summary>
    /// Gets or sets the branch name in the Git repository.
    /// </summary>
    public required string Branch { get; init; }

    /// <summary>
    /// Gets or sets the commit hash in the Git repository.
    /// </summary>
    public required string Hash { get; init; }

    /// <summary>
    /// Gets or sets the file path of the icon within the repository.
    /// </summary>
    public required string Path { get; init; }
}
