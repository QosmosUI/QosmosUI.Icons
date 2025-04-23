// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillDumpling : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M10.003 2.04a3.53 3.53 0 0 1 2.602 .62l.09 .07l.149 -.11a3.53 3.53 0 0 1 3.044 -.462l.207 .072a3.53 3.53 0 0 1 1.99 1.903l.014 .031l.045 -.004a3.53 3.53 0 0 1 2.624 .879l.153 .144l.358 .358c1.976 1.977 -.32 6.748 -4.655 11.083c-4.336 4.335 -9.106 6.632 -11.083 4.655l-.382 -.382l-.135 -.145a3.53 3.53 0 0 1 -.87 -2.556l.01 -.1l-.162 -.072a3.53 3.53 0 0 1 -1.838 -2.124l-.055 -.192a3.53 3.53 0 0 1 .56 -2.937l.062 -.079l-.07 -.092a3.53 3.53 0 0 1 -.644 -2.401l.025 -.2a3.53 3.53 0 0 1 1.707 -2.505l.046 -.026l-.005 -.14a3.53 3.53 0 0 1 .885 -2.345l.15 -.16l.159 -.149a3.53 3.53 0 0 1 2.346 -.884l.14 .004l.026 -.046a3.53 3.53 0 0 1 2.308 -1.67z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
