// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcFinePrint : ComponentBase
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
		builder.OpenElement(13, "polygon");
		builder.AddAttribute(14, "fill", "#90CAF9");
		builder.AddAttribute(15, "points", "33,42 5,42 5,4 24,4 33,13");
		builder.CloseElement();
		builder.OpenElement(16, "polygon");
		builder.AddAttribute(17, "fill", "#E1F5FE");
		builder.AddAttribute(18, "points", "31.5,14 23,14 23,5.5");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "38.3");
		builder.AddAttribute(21, "y", "34.8");
		builder.AddAttribute(22, "transform", "matrix(.707 -.707 .707 .707 -17.177 40.055)");
		builder.AddAttribute(23, "fill", "#616161");
		builder.AddAttribute(24, "width", "2.8");
		builder.AddAttribute(25, "height", "12");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "fill", "#616161");
		builder.AddAttribute(28, "cx", "28");
		builder.AddAttribute(29, "cy", "29");
		builder.AddAttribute(30, "r", "11");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "fill", "#90CAF9");
		builder.AddAttribute(33, "cx", "28");
		builder.AddAttribute(34, "cy", "29");
		builder.AddAttribute(35, "r", "9");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "x", "39.5");
		builder.AddAttribute(38, "y", "37.6");
		builder.AddAttribute(39, "transform", "matrix(.707 -.707 .707 .707 -17.661 41.223)");
		builder.AddAttribute(40, "fill", "#37474F");
		builder.AddAttribute(41, "width", "2.8");
		builder.AddAttribute(42, "height", "8.7");
		builder.CloseElement();
		builder.OpenElement(43, "g");
		builder.AddAttribute(44, "fill", "#1976D2");
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "d", "M30,31h-9.7c0.4,1.6,1.3,3,2.5,4H30V31z");
		builder.CloseElement();
		builder.OpenElement(47, "path");
		builder.AddAttribute(48, "d", "M20.3,27H30v-4h-7.3C21.5,24,20.7,25.4,20.3,27z");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "d", "M20.1,20H11v2h7.3C18.8,21.3,19.4,20.6,20.1,20z");
		builder.CloseElement();
		builder.OpenElement(51, "path");
		builder.AddAttribute(52, "d", "M17.1,24H11v2h5.4C16.6,25.3,16.8,24.6,17.1,24z");
		builder.CloseElement();
		builder.OpenElement(53, "path");
		builder.AddAttribute(54, "d", "M16,29c0-0.3,0-0.7,0.1-1H11v2h5.1C16,29.7,16,29.3,16,29z");
		builder.CloseElement();
		builder.OpenElement(55, "path");
		builder.AddAttribute(56, "d", "M16.4,32H11v2h6.1C16.8,33.4,16.6,32.7,16.4,32z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
