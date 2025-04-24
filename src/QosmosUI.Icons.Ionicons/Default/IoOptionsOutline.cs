// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoOptionsOutline : ComponentBase
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
		builder.OpenElement(13, "line");
		builder.AddAttribute(14, "x1", "368");
		builder.AddAttribute(15, "y1", "128");
		builder.AddAttribute(16, "x2", "448");
		builder.AddAttribute(17, "y2", "128");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "stroke-linecap", "round");
		builder.AddAttribute(20, "stroke-linejoin", "round");
		builder.AddAttribute(21, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(22, "line");
		builder.AddAttribute(23, "x1", "64");
		builder.AddAttribute(24, "y1", "128");
		builder.AddAttribute(25, "x2", "304");
		builder.AddAttribute(26, "y2", "128");
		builder.AddAttribute(27, "fill", "none");
		builder.AddAttribute(28, "stroke-linecap", "round");
		builder.AddAttribute(29, "stroke-linejoin", "round");
		builder.AddAttribute(30, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(31, "line");
		builder.AddAttribute(32, "x1", "368");
		builder.AddAttribute(33, "y1", "384");
		builder.AddAttribute(34, "x2", "448");
		builder.AddAttribute(35, "y2", "384");
		builder.AddAttribute(36, "fill", "none");
		builder.AddAttribute(37, "stroke-linecap", "round");
		builder.AddAttribute(38, "stroke-linejoin", "round");
		builder.AddAttribute(39, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(40, "line");
		builder.AddAttribute(41, "x1", "64");
		builder.AddAttribute(42, "y1", "384");
		builder.AddAttribute(43, "x2", "304");
		builder.AddAttribute(44, "y2", "384");
		builder.AddAttribute(45, "fill", "none");
		builder.AddAttribute(46, "stroke-linecap", "round");
		builder.AddAttribute(47, "stroke-linejoin", "round");
		builder.AddAttribute(48, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(49, "line");
		builder.AddAttribute(50, "x1", "208");
		builder.AddAttribute(51, "y1", "256");
		builder.AddAttribute(52, "x2", "448");
		builder.AddAttribute(53, "y2", "256");
		builder.AddAttribute(54, "fill", "none");
		builder.AddAttribute(55, "stroke-linecap", "round");
		builder.AddAttribute(56, "stroke-linejoin", "round");
		builder.AddAttribute(57, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(58, "line");
		builder.AddAttribute(59, "x1", "64");
		builder.AddAttribute(60, "y1", "256");
		builder.AddAttribute(61, "x2", "144");
		builder.AddAttribute(62, "y2", "256");
		builder.AddAttribute(63, "fill", "none");
		builder.AddAttribute(64, "stroke-linecap", "round");
		builder.AddAttribute(65, "stroke-linejoin", "round");
		builder.AddAttribute(66, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(67, "circle");
		builder.AddAttribute(68, "cx", "336");
		builder.AddAttribute(69, "cy", "128");
		builder.AddAttribute(70, "r", "32");
		builder.AddAttribute(71, "fill", "none");
		builder.AddAttribute(72, "stroke-linecap", "round");
		builder.AddAttribute(73, "stroke-linejoin", "round");
		builder.AddAttribute(74, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(75, "circle");
		builder.AddAttribute(76, "cx", "176");
		builder.AddAttribute(77, "cy", "256");
		builder.AddAttribute(78, "r", "32");
		builder.AddAttribute(79, "fill", "none");
		builder.AddAttribute(80, "stroke-linecap", "round");
		builder.AddAttribute(81, "stroke-linejoin", "round");
		builder.AddAttribute(82, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(83, "circle");
		builder.AddAttribute(84, "cx", "336");
		builder.AddAttribute(85, "cy", "384");
		builder.AddAttribute(86, "r", "32");
		builder.AddAttribute(87, "fill", "none");
		builder.AddAttribute(88, "stroke-linecap", "round");
		builder.AddAttribute(89, "stroke-linejoin", "round");
		builder.AddAttribute(90, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
