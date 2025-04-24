// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Git;

/// <summary>
/// Defines a service for interacting with Git repositories.
/// </summary>
public interface IRepository
{
    /// <summary>
    /// Clones a Git repository based on the provided icon metadata.
    /// </summary>
    /// <param name="metadata">The metadata of the icon used to determine the repository to clone.</param>
    void Clone(IconMetadata metadata);
}
