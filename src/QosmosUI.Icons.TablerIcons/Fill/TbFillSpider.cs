// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillSpider : ComponentBase
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
		builder.AddAttribute(14, "d", "M19 3a1 1 0 0 1 1 1v2a1 1 0 0 1 -.293 .707l-3.293 3.293h3.17l1.209 -1.207a1 1 0 0 1 1.414 1.414l-1.5 1.5a1 1 0 0 1 -.707 .293h-3.585l4.292 4.293a1 1 0 0 1 .293 .707v2a1 1 0 0 1 -2 0v-1.585l-2.016 -2.016a5 5 0 0 1 -9.968 0l-2.016 2.015v1.586a1 1 0 0 1 -.883 .993l-.117 .007a1 1 0 0 1 -1 -1v-2a1 1 0 0 1 .293 -.707l4.291 -4.293h-3.584a1 1 0 0 1 -.707 -.293l-1.5 -1.5a1 1 0 0 1 1.414 -1.414l1.208 1.207h3.17l-3.292 -3.293a1 1 0 0 1 -.293 -.707v-2a1 1 0 1 1 2 0v1.585l3.025 3.025a3 3 0 0 1 5.95 0l3.025 -3.026v-1.584a1 1 0 0 1 .883 -.993z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
