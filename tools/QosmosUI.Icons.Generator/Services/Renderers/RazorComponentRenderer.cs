// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using System.Text;
using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Renderers;

/// <summary>
/// A service for generating Razor components for icons based on metadata, icon sets, and SVG tree structures.
/// </summary>
public sealed class RazorComponentRenderer : IComponentRenderer
{
    private const string DefaultViewBox = "0 0 24 24";

    private const string DefaultSize = "1em";

    private const string DefaultStroke = "currentColor";

    private const string DefaultFill = "currentColor";

    private const string DefaultStrokeWidth = "0";

    private const string DefaultStrokeLinecap = "round";

    private const string DefaultStrokeLinejoin = "round";

    private const string Template =
        """
        // Copyright (c) QosmosUI 2025.
        // QosmosUI licenses this file to you under the MIT license.
        // See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

        using Microsoft.AspNetCore.Components;
        using Microsoft.AspNetCore.Components.Rendering;

        namespace %Namespace%;

        public class %Name% : ComponentBase
        {
            [Parameter]
            public string Title { get; set; } = string.Empty;

            [Parameter]
            public string Size { get; set; } = "%Size%";

            [Parameter]
            public string Stroke { get; set; } = "%Stroke%";

            [Parameter]
            public string Fill { get; set; } = "%Fill%";

            [Parameter]
            public string StrokeWidth { get; set; } = "%StrokeWidth%";

            [Parameter]
            public string StrokeLinecap { get; set; } = "%StrokeLinecap%";

            [Parameter]
            public string StrokeLinejoin { get; set; } = "%StrokeLinejoin%";

            [Parameter]
            public string ViewBox { get; set; } = "%ViewBox%";

            [Parameter(CaptureUnmatchedValues = true)]
            public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

            protected override void BuildRenderTree(RenderTreeBuilder builder)
            {
                builder.OpenElement(0, "svg");
                builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
                builder.AddAttribute(2, "viewBox", ViewBox);
                builder.AddAttribute(3, "width", Size);
                builder.AddAttribute(4, "height", Size);
                builder.AddAttribute(5, "fill", Fill);
                builder.AddAttribute(6, "stroke", Stroke);
                builder.AddAttribute(7, "stroke-width", StrokeWidth);
                builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
                builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
                builder.AddMultipleAttributes(10, AdditionalAttributes);
                if (!string.IsNullOrEmpty(Title))
                {
                    builder.OpenElement(11, "title");
                    builder.AddContent(12, Title);
                    builder.CloseElement();
                }
        %Content%builder.CloseElement();
            }
        }

        """;

    /// <summary>
    /// Generates a Razor component based on the provided icon metadata, icon set, name, and SVG tree structure.
    /// </summary>
    /// <param name="metadata">The metadata of the icon, including its properties and attributes.</param>
    /// <param name="set">The icon set to which the icon belongs.</param>
    /// <param name="name">The name of the Razor component to be generated.</param>
    /// <param name="tree">The tree structure representing the icon's SVG or graphical data.</param>
    /// <returns>A string containing the generated Razor component code.</returns>
    public string GenerateComponent(IconMetadata metadata, IconSet set, string name, IconTree tree)
    {
        var viewBox = GetSvgAttribute(tree, "viewBox", DefaultViewBox);
        var size = GetSvgAttribute(tree, "width", () => GetSvgAttribute(tree, "height", DefaultSize));
        var stroke = GetSvgAttribute(tree, "stroke", DefaultStroke);
        var strokeWidth = GetSvgAttribute(tree, "stroke-width", DefaultStrokeWidth);
        var strokeLinecap = GetSvgAttribute(tree, "stroke-linecap", DefaultStrokeLinecap);
        var strokeLinejoin = GetSvgAttribute(tree, "stroke-linejoin", DefaultStrokeLinejoin);
        var fill = GetSvgAttribute(tree, "fill", DefaultFill);

        var @namespace = BuildNamespace(metadata, set);

        var sequence = 13;

        var content = GenerateContent(tree.Children, ref sequence);

        return Template
            .Replace("%Namespace%", @namespace)
            .Replace("%Name%", EscapeString(name))
            .Replace("%Size%", EscapeString(size))
            .Replace("%Stroke%", EscapeString(stroke))
            .Replace("%Fill%", EscapeString(fill))
            .Replace("%StrokeWidth%", EscapeString(strokeWidth))
            .Replace("%StrokeLinecap%", EscapeString(strokeLinecap))
            .Replace("%StrokeLinejoin%", EscapeString(strokeLinejoin))
            .Replace("%ViewBox%", EscapeString(viewBox))
            .Replace("%Content%", string.Concat(content, "\t\t"));
    }

    /// <summary>
    /// Builds the namespace for the Razor component based on the icon metadata and icon set.
    /// </summary>
    /// <param name="metadata">The metadata of the icon.</param>
    /// <param name="set">The icon set to which the icon belongs.</param>
    /// <returns>A string representing the namespace of the Razor component.</returns>
    private static string BuildNamespace(IconMetadata metadata, IconSet set)
    {
        return $"QosmosUI.Icons.{metadata.Name}.{set.Name}";
    }

    /// <summary>
    /// Retrieves an SVG attribute from the tree or returns a default value if the attribute is not found.
    /// </summary>
    /// <param name="tree">The SVG tree structure.</param>
    /// <param name="key">The key of the attribute to retrieve.</param>
    /// <param name="defaultValue">The default value to return if the attribute is not found.</param>
    /// <returns>The value of the SVG attribute or the default value.</returns>
    private static string GetSvgAttribute(IconTree tree, string key, string defaultValue)
    {
        return tree.Attributes.GetValueOrDefault(key, defaultValue);
    }

    /// <summary>
    /// Retrieves an SVG attribute from the tree or uses a fallback provider if the attribute is not found.
    /// </summary>
    /// <param name="tree">The SVG tree structure.</param>
    /// <param name="key">The key of the attribute to retrieve.</param>
    /// <param name="fallbackProvider">A function that provides a fallback value if the attribute is not found.</param>
    /// <returns>The value of the SVG attribute or the fallback value.</returns>
    private static string GetSvgAttribute(IconTree tree, string key, Func<string> fallbackProvider)
    {
        return tree.Attributes.GetValueOrDefault(key, fallbackProvider());
    }

    /// <summary>
    /// Escapes special characters in a string to make it safe for use in Razor components.
    /// </summary>
    /// <param name="value">The string to escape.</param>
    /// <returns>The escaped string.</returns>
    private static string EscapeString(string value)
    {
        return value
            .Replace("\"", "\\\"")
            .Replace("\r\n", string.Empty)
            .Replace("\n", string.Empty);
    }

    /// <summary>
    /// Generates the content of the Razor component by recursively processing the children of the SVG tree.
    /// </summary>
    /// <param name="children">The list of child nodes in the SVG tree.</param>
    /// <param name="sequence">A reference to the sequence number used for rendering.</param>
    /// <returns>A string containing the generated content for the Razor component.</returns>
    private static string GenerateContent(List<IconTree> children, ref int sequence)
    {
        var indentStr = new string('\t', 2);
        var builder = new StringBuilder();

        foreach (var tree in children)
        {
            builder.AppendLine($"{indentStr}builder.OpenElement({sequence++}, \"{EscapeString(tree.Tag)}\");");

            foreach (var attribute in tree.Attributes)
                builder.AppendLine($"{indentStr}builder.AddAttribute({sequence++}, \"{EscapeString(attribute.Key)}\", \"{EscapeString(attribute.Value)}\");");

            if (tree.Children.Count > 0)
                builder.Append(GenerateContent(tree.Children, ref sequence));

            builder.AppendLine($"{indentStr}builder.CloseElement();");
        }

        return builder.ToString();
    }
}
