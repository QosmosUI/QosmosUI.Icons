// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Renderers;

/// <summary>
/// Defines the contract for generating components for icons.
/// </summary>
public interface IComponentRenderer
{
    /// <summary>
    /// Generates a component based on the provided icon metadata.
    /// </summary>
    /// <param name="metadata">The metadata of the icon.</param>
    /// <param name="set">The icon set to which the icon belongs.</param>
    /// <param name="name">The name of the component to be generated.</param>
    /// <param name="tree">The tree structure representing the icon's SVG or graphical data.</param>
    /// <returns>A string containing the generated component code.</returns>
    string GenerateComponent(IconMetadata metadata, IconSet set, string name, IconTree tree);
}
