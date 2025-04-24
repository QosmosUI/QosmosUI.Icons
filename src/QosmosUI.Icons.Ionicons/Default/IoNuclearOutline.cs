// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoNuclearOutline : ComponentBase
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
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "256");
		builder.AddAttribute(23, "cy", "256");
		builder.AddAttribute(24, "r", "64");
		builder.AddAttribute(25, "fill", "none");
		builder.AddAttribute(26, "stroke-miterlimit", "10");
		builder.AddAttribute(27, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(28, "line");
		builder.AddAttribute(29, "x1", "224");
		builder.AddAttribute(30, "y1", "192");
		builder.AddAttribute(31, "x2", "171");
		builder.AddAttribute(32, "y2", "85");
		builder.AddAttribute(33, "fill", "none");
		builder.AddAttribute(34, "stroke-linecap", "round");
		builder.AddAttribute(35, "stroke-miterlimit", "10");
		builder.AddAttribute(36, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(37, "line");
		builder.AddAttribute(38, "x1", "288");
		builder.AddAttribute(39, "y1", "192");
		builder.AddAttribute(40, "x2", "341");
		builder.AddAttribute(41, "y2", "85");
		builder.AddAttribute(42, "fill", "none");
		builder.AddAttribute(43, "stroke-linecap", "round");
		builder.AddAttribute(44, "stroke-miterlimit", "10");
		builder.AddAttribute(45, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(46, "line");
		builder.AddAttribute(47, "x1", "327.55");
		builder.AddAttribute(48, "y1", "255.81");
		builder.AddAttribute(49, "x2", "446.96");
		builder.AddAttribute(50, "y2", "255.94");
		builder.AddAttribute(51, "fill", "none");
		builder.AddAttribute(52, "stroke-linecap", "round");
		builder.AddAttribute(53, "stroke-miterlimit", "10");
		builder.AddAttribute(54, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(55, "line");
		builder.AddAttribute(56, "x1", "299.09");
		builder.AddAttribute(57, "y1", "313.13");
		builder.AddAttribute(58, "x2", "371.34");
		builder.AddAttribute(59, "y2", "408.19");
		builder.AddAttribute(60, "fill", "none");
		builder.AddAttribute(61, "stroke-linecap", "round");
		builder.AddAttribute(62, "stroke-miterlimit", "10");
		builder.AddAttribute(63, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(64, "line");
		builder.AddAttribute(65, "x1", "184.45");
		builder.AddAttribute(66, "y1", "255.81");
		builder.AddAttribute(67, "x2", "65.04");
		builder.AddAttribute(68, "y2", "255.94");
		builder.AddAttribute(69, "fill", "none");
		builder.AddAttribute(70, "stroke-linecap", "round");
		builder.AddAttribute(71, "stroke-miterlimit", "10");
		builder.AddAttribute(72, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(73, "line");
		builder.AddAttribute(74, "x1", "212.91");
		builder.AddAttribute(75, "y1", "313.13");
		builder.AddAttribute(76, "x2", "140.66");
		builder.AddAttribute(77, "y2", "408.19");
		builder.AddAttribute(78, "fill", "none");
		builder.AddAttribute(79, "stroke-linecap", "round");
		builder.AddAttribute(80, "stroke-miterlimit", "10");
		builder.AddAttribute(81, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
