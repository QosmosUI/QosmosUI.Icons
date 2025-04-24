// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Processors;

/// <summary>
/// Defines a service for processing SVG files into icon trees.
/// </summary>
public interface ISvgProcessor
{
    /// <summary>
    /// Processes an SVG file and converts it into an icon tree representation.
    /// </summary>
    /// <param name="source">The source SVG content as a string.</param>
    /// <param name="multiColor">A boolean indicating whether the SVG contains multiple colors.</param>
    /// <param name="svgo">A boolean indicating whether to optimize the SVG using SVGO.</param>
    /// <returns>An <see cref="IconTree"/> object representing the processed SVG.</returns>
    IconTree ProcessSvg(string source, bool multiColor, bool svgo);
}
