// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoDiceOutline : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-linecap", "round");
		builder.AddAttribute(16, "stroke-linejoin", "round");
		builder.AddAttribute(17, "stroke-width", "32");
		builder.AddAttribute(18, "d", "M448,341.37V170.61A32,32,0,0,0,432.11,143l-152-88.46a47.94,47.94,0,0,0-48.24,0L79.89,143A32,32,0,0,0,64,170.61V341.37A32,32,0,0,0,79.89,369l152,88.46a48,48,0,0,0,48.24,0l152-88.46A32,32,0,0,0,448,341.37Z");
		builder.CloseElement();
		builder.OpenElement(19, "polyline");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linecap", "round");
		builder.AddAttribute(22, "stroke-linejoin", "round");
		builder.AddAttribute(23, "stroke-width", "32");
		builder.AddAttribute(24, "points", "69 153.99 256 263.99 443 153.99");
		builder.CloseElement();
		builder.OpenElement(25, "line");
		builder.AddAttribute(26, "fill", "none");
		builder.AddAttribute(27, "stroke-linecap", "round");
		builder.AddAttribute(28, "stroke-linejoin", "round");
		builder.AddAttribute(29, "stroke-width", "32");
		builder.AddAttribute(30, "x1", "256");
		builder.AddAttribute(31, "y1", "463.99");
		builder.AddAttribute(32, "x2", "256");
		builder.AddAttribute(33, "y2", "263.99");
		builder.CloseElement();
		builder.OpenElement(34, "ellipse");
		builder.AddAttribute(35, "cx", "256");
		builder.AddAttribute(36, "cy", "152");
		builder.AddAttribute(37, "rx", "24");
		builder.AddAttribute(38, "ry", "16");
		builder.CloseElement();
		builder.OpenElement(39, "ellipse");
		builder.AddAttribute(40, "cx", "208");
		builder.AddAttribute(41, "cy", "296");
		builder.AddAttribute(42, "rx", "16");
		builder.AddAttribute(43, "ry", "24");
		builder.CloseElement();
		builder.OpenElement(44, "ellipse");
		builder.AddAttribute(45, "cx", "112");
		builder.AddAttribute(46, "cy", "328");
		builder.AddAttribute(47, "rx", "16");
		builder.AddAttribute(48, "ry", "24");
		builder.CloseElement();
		builder.OpenElement(49, "ellipse");
		builder.AddAttribute(50, "cx", "304");
		builder.AddAttribute(51, "cy", "296");
		builder.AddAttribute(52, "rx", "16");
		builder.AddAttribute(53, "ry", "24");
		builder.CloseElement();
		builder.OpenElement(54, "ellipse");
		builder.AddAttribute(55, "cx", "400");
		builder.AddAttribute(56, "cy", "240");
		builder.AddAttribute(57, "rx", "16");
		builder.AddAttribute(58, "ry", "24");
		builder.CloseElement();
		builder.OpenElement(59, "ellipse");
		builder.AddAttribute(60, "cx", "304");
		builder.AddAttribute(61, "cy", "384");
		builder.AddAttribute(62, "rx", "16");
		builder.AddAttribute(63, "ry", "24");
		builder.CloseElement();
		builder.OpenElement(64, "ellipse");
		builder.AddAttribute(65, "cx", "400");
		builder.AddAttribute(66, "cy", "328");
		builder.AddAttribute(67, "rx", "16");
		builder.AddAttribute(68, "ry", "24");
		builder.CloseElement();
		builder.CloseElement();
    }
}
