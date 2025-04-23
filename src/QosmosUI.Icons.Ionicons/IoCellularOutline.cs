// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoCellularOutline : ComponentBase
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
		builder.AddAttribute(14, "x", "416");
		builder.AddAttribute(15, "y", "96");
		builder.AddAttribute(16, "width", "64");
		builder.AddAttribute(17, "height", "320");
		builder.AddAttribute(18, "rx", "8");
		builder.AddAttribute(19, "ry", "8");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linejoin", "round");
		builder.AddAttribute(22, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "x", "288");
		builder.AddAttribute(25, "y", "176");
		builder.AddAttribute(26, "width", "64");
		builder.AddAttribute(27, "height", "240");
		builder.AddAttribute(28, "rx", "8");
		builder.AddAttribute(29, "ry", "8");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "x", "160");
		builder.AddAttribute(35, "y", "240");
		builder.AddAttribute(36, "width", "64");
		builder.AddAttribute(37, "height", "176");
		builder.AddAttribute(38, "rx", "8");
		builder.AddAttribute(39, "ry", "8");
		builder.AddAttribute(40, "fill", "none");
		builder.AddAttribute(41, "stroke-linejoin", "round");
		builder.AddAttribute(42, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "x", "32");
		builder.AddAttribute(45, "y", "304");
		builder.AddAttribute(46, "width", "64");
		builder.AddAttribute(47, "height", "112");
		builder.AddAttribute(48, "rx", "8");
		builder.AddAttribute(49, "ry", "8");
		builder.AddAttribute(50, "fill", "none");
		builder.AddAttribute(51, "stroke-linejoin", "round");
		builder.AddAttribute(52, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
