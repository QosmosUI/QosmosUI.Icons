// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoCashOutline : ComponentBase
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
		builder.AddAttribute(14, "x", "32");
		builder.AddAttribute(15, "y", "80");
		builder.AddAttribute(16, "width", "448");
		builder.AddAttribute(17, "height", "256");
		builder.AddAttribute(18, "rx", "16");
		builder.AddAttribute(19, "ry", "16");
		builder.AddAttribute(20, "transform", "translate(512 416) rotate(180)");
		builder.AddAttribute(21, "fill", "none");
		builder.AddAttribute(22, "stroke-linejoin", "round");
		builder.AddAttribute(23, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(24, "line");
		builder.AddAttribute(25, "x1", "64");
		builder.AddAttribute(26, "y1", "384");
		builder.AddAttribute(27, "x2", "448");
		builder.AddAttribute(28, "y2", "384");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "stroke-linecap", "round");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "line");
		builder.AddAttribute(34, "x1", "96");
		builder.AddAttribute(35, "y1", "432");
		builder.AddAttribute(36, "x2", "416");
		builder.AddAttribute(37, "y2", "432");
		builder.AddAttribute(38, "fill", "none");
		builder.AddAttribute(39, "stroke-linecap", "round");
		builder.AddAttribute(40, "stroke-linejoin", "round");
		builder.AddAttribute(41, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "256");
		builder.AddAttribute(44, "cy", "208");
		builder.AddAttribute(45, "r", "80");
		builder.AddAttribute(46, "fill", "none");
		builder.AddAttribute(47, "stroke-linecap", "round");
		builder.AddAttribute(48, "stroke-linejoin", "round");
		builder.AddAttribute(49, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(50, "path");
		builder.AddAttribute(51, "d", "M480,160a80,80,0,0,1-80-80");
		builder.AddAttribute(52, "fill", "none");
		builder.AddAttribute(53, "stroke-linecap", "round");
		builder.AddAttribute(54, "stroke-linejoin", "round");
		builder.AddAttribute(55, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(56, "path");
		builder.AddAttribute(57, "d", "M32,160a80,80,0,0,0,80-80");
		builder.AddAttribute(58, "fill", "none");
		builder.AddAttribute(59, "stroke-linecap", "round");
		builder.AddAttribute(60, "stroke-linejoin", "round");
		builder.AddAttribute(61, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(62, "path");
		builder.AddAttribute(63, "d", "M480,256a80,80,0,0,0-80,80");
		builder.AddAttribute(64, "fill", "none");
		builder.AddAttribute(65, "stroke-linecap", "round");
		builder.AddAttribute(66, "stroke-linejoin", "round");
		builder.AddAttribute(67, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(68, "path");
		builder.AddAttribute(69, "d", "M32,256a80,80,0,0,1,80,80");
		builder.AddAttribute(70, "fill", "none");
		builder.AddAttribute(71, "stroke-linecap", "round");
		builder.AddAttribute(72, "stroke-linejoin", "round");
		builder.AddAttribute(73, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
