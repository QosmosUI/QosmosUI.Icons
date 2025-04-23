// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoStatsChartOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "64");
		builder.AddAttribute(15, "y", "320");
		builder.AddAttribute(16, "width", "48");
		builder.AddAttribute(17, "height", "160");
		builder.AddAttribute(18, "rx", "8");
		builder.AddAttribute(19, "ry", "8");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linecap", "round");
		builder.AddAttribute(22, "stroke-linejoin", "round");
		builder.AddAttribute(23, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "288");
		builder.AddAttribute(26, "y", "224");
		builder.AddAttribute(27, "width", "48");
		builder.AddAttribute(28, "height", "256");
		builder.AddAttribute(29, "rx", "8");
		builder.AddAttribute(30, "ry", "8");
		builder.AddAttribute(31, "fill", "none");
		builder.AddAttribute(32, "stroke-linecap", "round");
		builder.AddAttribute(33, "stroke-linejoin", "round");
		builder.AddAttribute(34, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "400");
		builder.AddAttribute(37, "y", "112");
		builder.AddAttribute(38, "width", "48");
		builder.AddAttribute(39, "height", "368");
		builder.AddAttribute(40, "rx", "8");
		builder.AddAttribute(41, "ry", "8");
		builder.AddAttribute(42, "fill", "none");
		builder.AddAttribute(43, "stroke-linecap", "round");
		builder.AddAttribute(44, "stroke-linejoin", "round");
		builder.AddAttribute(45, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "x", "176");
		builder.AddAttribute(48, "y", "32");
		builder.AddAttribute(49, "width", "48");
		builder.AddAttribute(50, "height", "448");
		builder.AddAttribute(51, "rx", "8");
		builder.AddAttribute(52, "ry", "8");
		builder.AddAttribute(53, "fill", "none");
		builder.AddAttribute(54, "stroke-linecap", "round");
		builder.AddAttribute(55, "stroke-linejoin", "round");
		builder.AddAttribute(56, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
