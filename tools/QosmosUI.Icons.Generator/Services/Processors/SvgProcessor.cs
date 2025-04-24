// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using System.Xml;
using Microsoft.Extensions.Logging;
using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Processors;

/// <summary>
/// Provides functionality for processing SVG files into icon tree representations.
/// </summary>
public sealed class SvgProcessor : ISvgProcessor
{
    private readonly ILogger<SvgProcessor> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="SvgProcessor"/> class.
    /// </summary>
    /// <param name="logger">The logger instance used for logging messages.</param>
    public SvgProcessor(ILogger<SvgProcessor> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Processes an SVG file and converts it into an icon tree representation.
    /// </summary>
    /// <param name="source">The source SVG content as a string.</param>
    /// <param name="multiColor">A boolean indicating whether the SVG contains multiple colors.</param>
    /// <param name="svgo">A boolean indicating whether to optimize the SVG using SVGO.</param>
    /// <returns>An <see cref="IconTree"/> object representing the processed SVG.</returns>
    public IconTree ProcessSvg(string source, bool multiColor, bool svgo)
    {
        _logger.LogDebug("Processing SVG: length={Length}, multiColor={MultiColor}, svgo={Svgo}", source.Length, multiColor, svgo);

        var document = new XmlDocument();

        try
        {
            document.LoadXml(source);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Invalid XML in SVG source: {Message}", e.Message);
            _logger.LogTrace("Problematic SVG: {SVG}", source[..Math.Min(source.Length, 500)]);
        }

        var svgElement = document.DocumentElement;

        if (svgElement?.Name is not "svg")
        {
            _logger.LogError("Invalid SVG: root element is not 'svg' but '{RootElement}'", svgElement?.Name);

            throw new Exception("Unexpected SVG format. Root element is not 'svg'.");
        }

        if (svgo)
        {
            _logger.LogDebug("Applying SVGO optimizations with multiColor={MultiColor}", multiColor);
            ApplySvgoOptimizations(svgElement, multiColor);
        }

        _logger.LogDebug("Converting SVG to IconTree");

        var iconTree = ConvertElementToIconTree(svgElement, multiColor);

        if (iconTree is null)
        {
            _logger.LogError("Failed to convert SVG to IconTree");
            throw new Exception("Failed to convert SVG element to IconTree.");
        }

        _logger.LogInformation("SVG processed successfully: {ChildCount} child elements", iconTree.Children.Count);

        return iconTree;
    }

    /// <summary>
    /// Applies SVGO optimizations to the SVG node.
    /// </summary>
    /// <param name="node">The root SVG node to optimize.</param>
    /// <param name="multiColor">A boolean indicating whether the SVG contains multiple colors.</param>
    private static void ApplySvgoOptimizations(XmlNode node, bool multiColor)
    {
        if (!multiColor)
            ConvertColors(node);

        ConvertStyleToAttributes(node);
        RemoveDimensions(node);
        RemoveStrokeFromNonSvgElements(node);
        RemoveDataAttributes(node);
    }

    /// <summary>
    /// Converts color attributes (e.g., fill, stroke) to "currentColor" if applicable.
    /// </summary>
    /// <param name="node">The XML node to process.</param>
    private static void ConvertColors(XmlNode node)
    {
        if (node.Attributes is { Count: > 0 } attributes)
        {
            foreach (XmlAttribute attribute in attributes)
            {
                if (attribute.Name is "fill" or "stroke" && attribute.Value is not "none" and not "currentColor")
                {
                    attribute.Value = "currentColor";
                }
            }
        }

        if (node.HasChildNodes)
        {
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.NodeType is XmlNodeType.Element)
                {
                    ConvertColors(childNode);
                }
            }
        }
    }

    /// <summary>
    /// Converts inline styles to individual attributes on the node.
    /// </summary>
    /// <param name="node">The XML node to process.</param>
    private static void ConvertStyleToAttributes(XmlNode node)
    {
        if (node.Attributes is { Count: > 0 } attributes)
        {
            if (attributes["style"] is { Value.Length: > 0 } styleAttribute)
            {
                foreach (var style in styleAttribute.Value.Split(';', StringSplitOptions.RemoveEmptyEntries))
                {
                    var parts = style.Split(':', StringSplitOptions.RemoveEmptyEntries);

                    var propertyName = parts[0].Trim();
                    var propertyValue = parts[1].Trim();

                    var newAttribute = node.OwnerDocument!.CreateAttribute(propertyName);
                    newAttribute.Value = propertyValue;
                    node.Attributes.SetNamedItem(newAttribute);
                }

                node.Attributes.Remove(styleAttribute);
            }
        }

        if (node.HasChildNodes)
        {
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.NodeType is XmlNodeType.Element)
                {
                    ConvertStyleToAttributes(childNode);
                }
            }
        }
    }

    /// <summary>
    /// Removes width and height attributes from the node.
    /// </summary>
    /// <param name="node">The XML node to process.</param>
    private static void RemoveDimensions(XmlNode node)
    {
        if (node.Attributes is { Count: > 0 } attributes)
        {
            var widthAttribute = attributes["width"];
            var heightAttribute = attributes["height"];

            if (widthAttribute is not null)
                node.Attributes.Remove(widthAttribute);

            if (heightAttribute is not null)
                node.Attributes.Remove(heightAttribute);
        }
    }

    /// <summary>
    /// Removes stroke attributes from non-SVG elements.
    /// </summary>
    /// <param name="node">The XML node to process.</param>
    private static void RemoveStrokeFromNonSvgElements(XmlNode node)
    {
        if (node is { NodeType: XmlNodeType.Element, Name: not "svg" })
        {
            if (node.Attributes is { Count: > 0 } attributes)
            {
                var strokeAttribute = attributes["stroke"];

                if (strokeAttribute is not null)
                    node.Attributes.Remove(strokeAttribute);
            }
        }

        if (node.HasChildNodes)
        {
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.NodeType is XmlNodeType.Element)
                {
                    RemoveStrokeFromNonSvgElements(childNode);
                }
            }
        }
    }

    /// <summary>
    /// Removes attributes starting with "data-" from the node.
    /// </summary>
    /// <param name="node">The XML node to process.</param>
    private static void RemoveDataAttributes(XmlNode node)
    {
        if (node.Attributes is { Count: > 0 } attributes)
        {
            foreach (var attribute in attributes
                         .Cast<XmlAttribute>()
                         .Where(static attribute => attribute.Name.StartsWith("data-"))
                         .ToArray())
            {
                node.Attributes.Remove(attribute);
            }
        }

        if (node.HasChildNodes)
        {
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.NodeType is XmlNodeType.Element)
                {
                    RemoveDataAttributes(childNode);
                }
            }
        }
    }

    /// <summary>
    /// Converts an XML element to an <see cref="IconTree"/> object.
    /// </summary>
    /// <param name="node">The XML node to convert.</param>
    /// <param name="multiColor">A boolean indicating whether the SVG contains multiple colors.</param>
    /// <returns>An <see cref="IconTree"/> object representing the node, or null if the node is not an element.</returns>
    private static IconTree? ConvertElementToIconTree(XmlNode node, bool multiColor)
    {
        if (node.NodeType is not XmlNodeType.Element)
            return null;

        var attributes = new Dictionary<string, string>();

        if (node.Attributes is { Count: > 0 } nodeAttributes)
        {
            foreach (XmlAttribute nodeAttribute in nodeAttributes)
            {
                if (nodeAttribute.Name is "fill" or "stroke" && !(nodeAttribute.Value is "none" or "currentColor" || multiColor))
                    continue;

                attributes[nodeAttribute.Name] = nodeAttribute.Value;
            }
        }

        var children = new List<IconTree>();

        if (node.HasChildNodes)
        {
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (ConvertElementToIconTree(childNode, multiColor) is { } childTree)
                    children.Add(childTree);
            }
        }

        return new IconTree { Tag = node.Name, Attributes = attributes, Children = children };
    }
}
