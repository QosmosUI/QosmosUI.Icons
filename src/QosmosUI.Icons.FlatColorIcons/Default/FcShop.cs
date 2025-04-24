// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcShop : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "5");
		builder.AddAttribute(15, "y", "19");
		builder.AddAttribute(16, "fill", "#CFD8DC");
		builder.AddAttribute(17, "width", "38");
		builder.AddAttribute(18, "height", "19");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "5");
		builder.AddAttribute(21, "y", "38");
		builder.AddAttribute(22, "fill", "#B0BEC5");
		builder.AddAttribute(23, "width", "38");
		builder.AddAttribute(24, "height", "4");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "27");
		builder.AddAttribute(27, "y", "24");
		builder.AddAttribute(28, "fill", "#455A64");
		builder.AddAttribute(29, "width", "12");
		builder.AddAttribute(30, "height", "18");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "9");
		builder.AddAttribute(33, "y", "24");
		builder.AddAttribute(34, "fill", "#E3F2FD");
		builder.AddAttribute(35, "width", "14");
		builder.AddAttribute(36, "height", "11");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "x", "10");
		builder.AddAttribute(39, "y", "25");
		builder.AddAttribute(40, "fill", "#1E88E5");
		builder.AddAttribute(41, "width", "12");
		builder.AddAttribute(42, "height", "9");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "fill", "#90A4AE");
		builder.AddAttribute(45, "d", "M36.5,33.5c-0.3,0-0.5,0.2-0.5,0.5v2c0,0.3,0.2,0.5,0.5,0.5S37,36.3,37,36v-2C37,33.7,36.8,33.5,36.5,33.5z");
		builder.CloseElement();
		builder.OpenElement(46, "g");
		builder.AddAttribute(47, "fill", "#558B2F");
		builder.OpenElement(48, "circle");
		builder.AddAttribute(49, "cx", "24");
		builder.AddAttribute(50, "cy", "19");
		builder.AddAttribute(51, "r", "3");
		builder.CloseElement();
		builder.OpenElement(52, "circle");
		builder.AddAttribute(53, "cx", "36");
		builder.AddAttribute(54, "cy", "19");
		builder.AddAttribute(55, "r", "3");
		builder.CloseElement();
		builder.OpenElement(56, "circle");
		builder.AddAttribute(57, "cx", "12");
		builder.AddAttribute(58, "cy", "19");
		builder.AddAttribute(59, "r", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(60, "path");
		builder.AddAttribute(61, "fill", "#7CB342");
		builder.AddAttribute(62, "d", "M40,6H8C6.9,6,6,6.9,6,8v3h36V8C42,6.9,41.1,6,40,6z");
		builder.CloseElement();
		builder.OpenElement(63, "rect");
		builder.AddAttribute(64, "x", "21");
		builder.AddAttribute(65, "y", "11");
		builder.AddAttribute(66, "fill", "#7CB342");
		builder.AddAttribute(67, "width", "6");
		builder.AddAttribute(68, "height", "8");
		builder.CloseElement();
		builder.OpenElement(69, "polygon");
		builder.AddAttribute(70, "fill", "#7CB342");
		builder.AddAttribute(71, "points", "37,11 32,11 33,19 39,19");
		builder.CloseElement();
		builder.OpenElement(72, "polygon");
		builder.AddAttribute(73, "fill", "#7CB342");
		builder.AddAttribute(74, "points", "11,11 16,11 15,19 9,19");
		builder.CloseElement();
		builder.OpenElement(75, "g");
		builder.AddAttribute(76, "fill", "#FFA000");
		builder.OpenElement(77, "circle");
		builder.AddAttribute(78, "cx", "30");
		builder.AddAttribute(79, "cy", "19");
		builder.AddAttribute(80, "r", "3");
		builder.CloseElement();
		builder.OpenElement(81, "path");
		builder.AddAttribute(82, "d", "M45,19c0,1.7-1.3,3-3,3s-3-1.3-3-3s1.3-3,3-3L45,19z");
		builder.CloseElement();
		builder.OpenElement(83, "circle");
		builder.AddAttribute(84, "cx", "18");
		builder.AddAttribute(85, "cy", "19");
		builder.AddAttribute(86, "r", "3");
		builder.CloseElement();
		builder.OpenElement(87, "path");
		builder.AddAttribute(88, "d", "M3,19c0,1.7,1.3,3,3,3s3-1.3,3-3s-1.3-3-3-3L3,19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(89, "g");
		builder.AddAttribute(90, "fill", "#FFC107");
		builder.OpenElement(91, "polygon");
		builder.AddAttribute(92, "points", "32,11 27,11 27,19 33,19");
		builder.CloseElement();
		builder.OpenElement(93, "polygon");
		builder.AddAttribute(94, "points", "42,11 37,11 39,19 45,19");
		builder.CloseElement();
		builder.OpenElement(95, "polygon");
		builder.AddAttribute(96, "points", "16,11 21,11 21,19 15,19");
		builder.CloseElement();
		builder.OpenElement(97, "polygon");
		builder.AddAttribute(98, "points", "6,11 11,11 9,19 3,19");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
