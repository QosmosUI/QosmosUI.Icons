// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Renderers;

/// <summary>
/// Defines an interface for generating project files for icon libraries.
/// </summary>
public interface ICsprojRenderer
{
    /// <summary>
    /// Generates a project file based on the provided icon metadata.
    /// </summary>
    /// <param name="metadata">The metadata of the icon, including its name and other properties.</param>
    /// <returns>A string containing the generated project file content.</returns>
    string GenerateProject(IconMetadata metadata);
}
