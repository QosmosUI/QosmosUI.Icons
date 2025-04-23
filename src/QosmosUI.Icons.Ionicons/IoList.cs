// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoList : ComponentBase
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
		builder.AddAttribute(14, "x1", "160");
		builder.AddAttribute(15, "y1", "144");
		builder.AddAttribute(16, "x2", "448");
		builder.AddAttribute(17, "y2", "144");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "stroke-linecap", "round");
		builder.AddAttribute(20, "stroke-linejoin", "round");
		builder.AddAttribute(21, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(22, "line");
		builder.AddAttribute(23, "x1", "160");
		builder.AddAttribute(24, "y1", "256");
		builder.AddAttribute(25, "x2", "448");
		builder.AddAttribute(26, "y2", "256");
		builder.AddAttribute(27, "fill", "none");
		builder.AddAttribute(28, "stroke-linecap", "round");
		builder.AddAttribute(29, "stroke-linejoin", "round");
		builder.AddAttribute(30, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(31, "line");
		builder.AddAttribute(32, "x1", "160");
		builder.AddAttribute(33, "y1", "368");
		builder.AddAttribute(34, "x2", "448");
		builder.AddAttribute(35, "y2", "368");
		builder.AddAttribute(36, "fill", "none");
		builder.AddAttribute(37, "stroke-linecap", "round");
		builder.AddAttribute(38, "stroke-linejoin", "round");
		builder.AddAttribute(39, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "80");
		builder.AddAttribute(42, "cy", "144");
		builder.AddAttribute(43, "r", "16");
		builder.AddAttribute(44, "fill", "none");
		builder.AddAttribute(45, "stroke-linecap", "round");
		builder.AddAttribute(46, "stroke-linejoin", "round");
		builder.AddAttribute(47, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(48, "circle");
		builder.AddAttribute(49, "cx", "80");
		builder.AddAttribute(50, "cy", "256");
		builder.AddAttribute(51, "r", "16");
		builder.AddAttribute(52, "fill", "none");
		builder.AddAttribute(53, "stroke-linecap", "round");
		builder.AddAttribute(54, "stroke-linejoin", "round");
		builder.AddAttribute(55, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(56, "circle");
		builder.AddAttribute(57, "cx", "80");
		builder.AddAttribute(58, "cy", "368");
		builder.AddAttribute(59, "r", "16");
		builder.AddAttribute(60, "fill", "none");
		builder.AddAttribute(61, "stroke-linecap", "round");
		builder.AddAttribute(62, "stroke-linejoin", "round");
		builder.AddAttribute(63, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
