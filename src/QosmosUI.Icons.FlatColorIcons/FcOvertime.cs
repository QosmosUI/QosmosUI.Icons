// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcOvertime : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#CFD8DC");
		builder.AddAttribute(15, "d", "M12,40V20h32v20c0,2.2-1.8,4-4,4H16C13.8,44,12,42.2,12,40z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#78909C");
		builder.AddAttribute(18, "d", "M44,16v6H12v-6c0-2.2,1.8-4,4-4h24C42.2,12,44,13.8,44,16z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#37474F");
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "37");
		builder.AddAttribute(23, "cy", "16");
		builder.AddAttribute(24, "r", "3");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "20");
		builder.AddAttribute(27, "cy", "16");
		builder.AddAttribute(28, "r", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(29, "g");
		builder.AddAttribute(30, "fill", "#B0BEC5");
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M37,10c-1.1,0-2,0.9-2,2v4c0,1.1,0.9,2,2,2s2-0.9,2-2v-4C39,10.9,38.1,10,37,10z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M20,10c-1.1,0-2,0.9-2,2v4c0,1.1,0.9,2,2,2s2-0.9,2-2v-4C22,10.9,21.1,10,20,10z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "32");
		builder.AddAttribute(37, "y", "34");
		builder.AddAttribute(38, "fill", "#90A4AE");
		builder.AddAttribute(39, "width", "4");
		builder.AddAttribute(40, "height", "4");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "26");
		builder.AddAttribute(43, "y", "34");
		builder.AddAttribute(44, "fill", "#90A4AE");
		builder.AddAttribute(45, "width", "4");
		builder.AddAttribute(46, "height", "4");
		builder.CloseElement();
		builder.OpenElement(47, "rect");
		builder.AddAttribute(48, "x", "20");
		builder.AddAttribute(49, "y", "34");
		builder.AddAttribute(50, "fill", "#90A4AE");
		builder.AddAttribute(51, "width", "4");
		builder.AddAttribute(52, "height", "4");
		builder.CloseElement();
		builder.OpenElement(53, "rect");
		builder.AddAttribute(54, "x", "32");
		builder.AddAttribute(55, "y", "28");
		builder.AddAttribute(56, "fill", "#90A4AE");
		builder.AddAttribute(57, "width", "4");
		builder.AddAttribute(58, "height", "4");
		builder.CloseElement();
		builder.OpenElement(59, "rect");
		builder.AddAttribute(60, "x", "26");
		builder.AddAttribute(61, "y", "28");
		builder.AddAttribute(62, "fill", "#90A4AE");
		builder.AddAttribute(63, "width", "4");
		builder.AddAttribute(64, "height", "4");
		builder.CloseElement();
		builder.OpenElement(65, "rect");
		builder.AddAttribute(66, "x", "20");
		builder.AddAttribute(67, "y", "28");
		builder.AddAttribute(68, "fill", "#90A4AE");
		builder.AddAttribute(69, "width", "4");
		builder.AddAttribute(70, "height", "4");
		builder.CloseElement();
		builder.OpenElement(71, "circle");
		builder.AddAttribute(72, "fill", "#F44336");
		builder.AddAttribute(73, "cx", "16");
		builder.AddAttribute(74, "cy", "15");
		builder.AddAttribute(75, "r", "12");
		builder.CloseElement();
		builder.OpenElement(76, "circle");
		builder.AddAttribute(77, "fill", "#eee");
		builder.AddAttribute(78, "cx", "16");
		builder.AddAttribute(79, "cy", "15");
		builder.AddAttribute(80, "r", "9");
		builder.CloseElement();
		builder.OpenElement(81, "rect");
		builder.AddAttribute(82, "x", "15");
		builder.AddAttribute(83, "y", "8");
		builder.AddAttribute(84, "width", "2");
		builder.AddAttribute(85, "height", "7");
		builder.CloseElement();
		builder.OpenElement(86, "rect");
		builder.AddAttribute(87, "x", "16.9");
		builder.AddAttribute(88, "y", "14.2");
		builder.AddAttribute(89, "transform", "matrix(-.707 .707 -.707 -.707 42.506 16.192)");
		builder.AddAttribute(90, "width", "1.9");
		builder.AddAttribute(91, "height", "5.4");
		builder.CloseElement();
		builder.OpenElement(92, "circle");
		builder.AddAttribute(93, "cx", "16");
		builder.AddAttribute(94, "cy", "15");
		builder.AddAttribute(95, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
