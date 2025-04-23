// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillMacro : ComponentBase
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
		builder.AddAttribute(14, "d", "M17.994 2.888l.006 .112v3a6 6 0 0 1 -5 5.916v4.186a6.98 6.98 0 0 1 5 -2.102a1 1 0 0 1 1 1a7 7 0 0 1 -14 0a1 1 0 0 1 1 -1c1.96 0 3.731 .805 5.002 2.103l-.002 -4.186a6 6 0 0 1 -5 -5.917v-3a1 1 0 0 1 1.555 -.832l2.317 1.544l1.42 -1.42a1 1 0 0 1 1.32 -.082l.095 .083l1.42 1.419l2.318 -1.544a1 1 0 0 1 1.55 .72m-10.865 13.24l.03 .134a5.01 5.01 0 0 0 3.71 3.61a5 5 0 0 0 -3.74 -3.744m9.742 .002l-.134 .03a5.01 5.01 0 0 0 -3.61 3.71a5 5 0 0 0 3.744 -3.74");
		builder.CloseElement();
		builder.CloseElement();
    }
}
