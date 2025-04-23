// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoSubwayOutline : ComponentBase
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
		builder.AddAttribute(14, "x", "112");
		builder.AddAttribute(15, "y", "32");
		builder.AddAttribute(16, "width", "288");
		builder.AddAttribute(17, "height", "352");
		builder.AddAttribute(18, "rx", "48");
		builder.AddAttribute(19, "ry", "48");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-miterlimit", "10");
		builder.AddAttribute(22, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(23, "line");
		builder.AddAttribute(24, "x1", "208");
		builder.AddAttribute(25, "y1", "80");
		builder.AddAttribute(26, "x2", "304");
		builder.AddAttribute(27, "y2", "80");
		builder.AddAttribute(28, "fill", "none");
		builder.AddAttribute(29, "stroke-linecap", "round");
		builder.AddAttribute(30, "stroke-linejoin", "round");
		builder.AddAttribute(31, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "112");
		builder.AddAttribute(34, "y", "128");
		builder.AddAttribute(35, "width", "288");
		builder.AddAttribute(36, "height", "96");
		builder.AddAttribute(37, "rx", "32");
		builder.AddAttribute(38, "ry", "32");
		builder.AddAttribute(39, "fill", "none");
		builder.AddAttribute(40, "stroke-linecap", "round");
		builder.AddAttribute(41, "stroke-linejoin", "round");
		builder.AddAttribute(42, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(43, "circle");
		builder.AddAttribute(44, "cx", "176");
		builder.AddAttribute(45, "cy", "320");
		builder.AddAttribute(46, "r", "16");
		builder.AddAttribute(47, "fill", "none");
		builder.AddAttribute(48, "stroke-linejoin", "round");
		builder.AddAttribute(49, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(50, "circle");
		builder.AddAttribute(51, "cx", "336");
		builder.AddAttribute(52, "cy", "320");
		builder.AddAttribute(53, "r", "16");
		builder.AddAttribute(54, "fill", "none");
		builder.AddAttribute(55, "stroke-linejoin", "round");
		builder.AddAttribute(56, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(57, "line");
		builder.AddAttribute(58, "x1", "144");
		builder.AddAttribute(59, "y1", "464");
		builder.AddAttribute(60, "x2", "368");
		builder.AddAttribute(61, "y2", "464");
		builder.AddAttribute(62, "fill", "none");
		builder.AddAttribute(63, "stroke-linecap", "round");
		builder.AddAttribute(64, "stroke-linejoin", "round");
		builder.AddAttribute(65, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(66, "line");
		builder.AddAttribute(67, "x1", "336");
		builder.AddAttribute(68, "y1", "432");
		builder.AddAttribute(69, "x2", "384");
		builder.AddAttribute(70, "y2", "480");
		builder.AddAttribute(71, "fill", "none");
		builder.AddAttribute(72, "stroke-linecap", "round");
		builder.AddAttribute(73, "stroke-linejoin", "round");
		builder.AddAttribute(74, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(75, "line");
		builder.AddAttribute(76, "x1", "176");
		builder.AddAttribute(77, "y1", "432");
		builder.AddAttribute(78, "x2", "128");
		builder.AddAttribute(79, "y2", "480");
		builder.AddAttribute(80, "fill", "none");
		builder.AddAttribute(81, "stroke-linecap", "round");
		builder.AddAttribute(82, "stroke-linejoin", "round");
		builder.AddAttribute(83, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
