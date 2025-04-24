// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoFootballOutline : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "256");
		builder.AddAttribute(15, "cy", "256");
		builder.AddAttribute(16, "r", "192");
		builder.AddAttribute(17, "fill", "none");
		builder.AddAttribute(18, "stroke-linecap", "round");
		builder.AddAttribute(19, "stroke-miterlimit", "10");
		builder.AddAttribute(20, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "points", "256 175.15 179.91 238.98 200 320 256 320 312 320 332.09 238.98 256 175.15");
		builder.AddAttribute(23, "fill", "none");
		builder.AddAttribute(24, "stroke-linecap", "round");
		builder.AddAttribute(25, "stroke-linejoin", "round");
		builder.AddAttribute(26, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(27, "polyline");
		builder.AddAttribute(28, "points", "332.09 238.98 384.96 216.58 410.74 143.32");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "stroke-linecap", "round");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "line");
		builder.AddAttribute(34, "x1", "447");
		builder.AddAttribute(35, "y1", "269.97");
		builder.AddAttribute(36, "x2", "384.96");
		builder.AddAttribute(37, "y2", "216.58");
		builder.AddAttribute(38, "fill", "none");
		builder.AddAttribute(39, "stroke-linecap", "round");
		builder.AddAttribute(40, "stroke-linejoin", "round");
		builder.AddAttribute(41, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(42, "polyline");
		builder.AddAttribute(43, "points", "179.91 238.98 127.04 216.58 101.26 143.32");
		builder.AddAttribute(44, "fill", "none");
		builder.AddAttribute(45, "stroke-linecap", "round");
		builder.AddAttribute(46, "stroke-linejoin", "round");
		builder.AddAttribute(47, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(48, "line");
		builder.AddAttribute(49, "x1", "65");
		builder.AddAttribute(50, "y1", "269.97");
		builder.AddAttribute(51, "x2", "127.04");
		builder.AddAttribute(52, "y2", "216.58");
		builder.AddAttribute(53, "fill", "none");
		builder.AddAttribute(54, "stroke-linecap", "round");
		builder.AddAttribute(55, "stroke-linejoin", "round");
		builder.AddAttribute(56, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(57, "polyline");
		builder.AddAttribute(58, "points", "256 175.15 256 117.58 320 74.94");
		builder.AddAttribute(59, "fill", "none");
		builder.AddAttribute(60, "stroke-linecap", "round");
		builder.AddAttribute(61, "stroke-linejoin", "round");
		builder.AddAttribute(62, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(63, "line");
		builder.AddAttribute(64, "x1", "192");
		builder.AddAttribute(65, "y1", "74.93");
		builder.AddAttribute(66, "x2", "256");
		builder.AddAttribute(67, "y2", "117.58");
		builder.AddAttribute(68, "fill", "none");
		builder.AddAttribute(69, "stroke-linecap", "round");
		builder.AddAttribute(70, "stroke-linejoin", "round");
		builder.AddAttribute(71, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(72, "polyline");
		builder.AddAttribute(73, "points", "312 320 340 368 312 439");
		builder.AddAttribute(74, "fill", "none");
		builder.AddAttribute(75, "stroke-linecap", "round");
		builder.AddAttribute(76, "stroke-linejoin", "round");
		builder.AddAttribute(77, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(78, "line");
		builder.AddAttribute(79, "x1", "410.74");
		builder.AddAttribute(80, "y1", "368");
		builder.AddAttribute(81, "x2", "342");
		builder.AddAttribute(82, "y2", "368");
		builder.AddAttribute(83, "fill", "none");
		builder.AddAttribute(84, "stroke-linecap", "round");
		builder.AddAttribute(85, "stroke-linejoin", "round");
		builder.AddAttribute(86, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(87, "polyline");
		builder.AddAttribute(88, "points", "200 320 172 368 200.37 439.5");
		builder.AddAttribute(89, "fill", "none");
		builder.AddAttribute(90, "stroke-linecap", "round");
		builder.AddAttribute(91, "stroke-linejoin", "round");
		builder.AddAttribute(92, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(93, "line");
		builder.AddAttribute(94, "x1", "101.63");
		builder.AddAttribute(95, "y1", "368");
		builder.AddAttribute(96, "x2", "172");
		builder.AddAttribute(97, "y2", "368");
		builder.AddAttribute(98, "fill", "none");
		builder.AddAttribute(99, "stroke-linecap", "round");
		builder.AddAttribute(100, "stroke-linejoin", "round");
		builder.AddAttribute(101, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
