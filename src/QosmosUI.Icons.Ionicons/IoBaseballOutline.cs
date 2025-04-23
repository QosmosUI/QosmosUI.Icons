// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoBaseballOutline : ComponentBase
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
		builder.AddAttribute(14, "x1", "294.25");
		builder.AddAttribute(15, "y1", "108.6");
		builder.AddAttribute(16, "x2", "233.68");
		builder.AddAttribute(17, "y2", "126.19");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "stroke-linecap", "round");
		builder.AddAttribute(20, "stroke-linejoin", "round");
		builder.AddAttribute(21, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(22, "line");
		builder.AddAttribute(23, "x1", "317.13");
		builder.AddAttribute(24, "y1", "156.11");
		builder.AddAttribute(25, "x2", "265.63");
		builder.AddAttribute(26, "y2", "192.51");
		builder.AddAttribute(27, "fill", "none");
		builder.AddAttribute(28, "stroke-linecap", "round");
		builder.AddAttribute(29, "stroke-linejoin", "round");
		builder.AddAttribute(30, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(31, "line");
		builder.AddAttribute(32, "x1", "355.89");
		builder.AddAttribute(33, "y1", "194.87");
		builder.AddAttribute(34, "x2", "319.49");
		builder.AddAttribute(35, "y2", "246.37");
		builder.AddAttribute(36, "fill", "none");
		builder.AddAttribute(37, "stroke-linecap", "round");
		builder.AddAttribute(38, "stroke-linejoin", "round");
		builder.AddAttribute(39, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(40, "line");
		builder.AddAttribute(41, "x1", "403.4");
		builder.AddAttribute(42, "y1", "217.75");
		builder.AddAttribute(43, "x2", "385.81");
		builder.AddAttribute(44, "y2", "278.32");
		builder.AddAttribute(45, "fill", "none");
		builder.AddAttribute(46, "stroke-linecap", "round");
		builder.AddAttribute(47, "stroke-linejoin", "round");
		builder.AddAttribute(48, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(49, "circle");
		builder.AddAttribute(50, "cx", "256");
		builder.AddAttribute(51, "cy", "256");
		builder.AddAttribute(52, "r", "192");
		builder.AddAttribute(53, "fill", "none");
		builder.AddAttribute(54, "stroke-linecap", "round");
		builder.AddAttribute(55, "stroke-linejoin", "round");
		builder.AddAttribute(56, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(57, "path");
		builder.AddAttribute(58, "d", "M432.94,255.05A192,192,0,0,1,256.63,74.35");
		builder.AddAttribute(59, "fill", "none");
		builder.AddAttribute(60, "stroke-linecap", "round");
		builder.AddAttribute(61, "stroke-linejoin", "round");
		builder.AddAttribute(62, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(63, "line");
		builder.AddAttribute(64, "x1", "108.54");
		builder.AddAttribute(65, "y1", "294.31");
		builder.AddAttribute(66, "x2", "126.13");
		builder.AddAttribute(67, "y2", "233.74");
		builder.AddAttribute(68, "fill", "none");
		builder.AddAttribute(69, "stroke-linecap", "round");
		builder.AddAttribute(70, "stroke-linejoin", "round");
		builder.AddAttribute(71, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(72, "line");
		builder.AddAttribute(73, "x1", "156.05");
		builder.AddAttribute(74, "y1", "317.19");
		builder.AddAttribute(75, "x2", "192.45");
		builder.AddAttribute(76, "y2", "265.69");
		builder.AddAttribute(77, "fill", "none");
		builder.AddAttribute(78, "stroke-linecap", "round");
		builder.AddAttribute(79, "stroke-linejoin", "round");
		builder.AddAttribute(80, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(81, "line");
		builder.AddAttribute(82, "x1", "194.81");
		builder.AddAttribute(83, "y1", "355.95");
		builder.AddAttribute(84, "x2", "246.31");
		builder.AddAttribute(85, "y2", "319.55");
		builder.AddAttribute(86, "fill", "none");
		builder.AddAttribute(87, "stroke-linecap", "round");
		builder.AddAttribute(88, "stroke-linejoin", "round");
		builder.AddAttribute(89, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(90, "line");
		builder.AddAttribute(91, "x1", "217.69");
		builder.AddAttribute(92, "y1", "403.46");
		builder.AddAttribute(93, "x2", "278.26");
		builder.AddAttribute(94, "y2", "385.87");
		builder.AddAttribute(95, "fill", "none");
		builder.AddAttribute(96, "stroke-linecap", "round");
		builder.AddAttribute(97, "stroke-linejoin", "round");
		builder.AddAttribute(98, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(99, "path");
		builder.AddAttribute(100, "d", "M255,433.61A192,192,0,0,0,74.29,256.69");
		builder.AddAttribute(101, "fill", "none");
		builder.AddAttribute(102, "stroke-linecap", "round");
		builder.AddAttribute(103, "stroke-linejoin", "round");
		builder.AddAttribute(104, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
