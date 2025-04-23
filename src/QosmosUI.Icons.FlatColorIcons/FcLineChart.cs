// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcLineChart : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#3F51B5");
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "8");
		builder.AddAttribute(17, "cy", "38");
		builder.AddAttribute(18, "r", "3");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "16");
		builder.AddAttribute(21, "cy", "40");
		builder.AddAttribute(22, "r", "3");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "24");
		builder.AddAttribute(25, "cy", "33");
		builder.AddAttribute(26, "r", "3");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "32");
		builder.AddAttribute(29, "cy", "35");
		builder.AddAttribute(30, "r", "3");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "40");
		builder.AddAttribute(33, "cy", "31");
		builder.AddAttribute(34, "r", "3");
		builder.CloseElement();
		builder.OpenElement(35, "polygon");
		builder.AddAttribute(36, "points", "39.1,29.2 31.8,32.9 23.5,30.8 15.5,37.8 8.5,36.1 7.5,39.9 16.5,42.2 24.5,35.2 32.2,37.1 40.9,32.8");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(37, "g");
		builder.AddAttribute(38, "fill", "#00BCD4");
		builder.OpenElement(39, "circle");
		builder.AddAttribute(40, "cx", "8");
		builder.AddAttribute(41, "cy", "20");
		builder.AddAttribute(42, "r", "3");
		builder.CloseElement();
		builder.OpenElement(43, "circle");
		builder.AddAttribute(44, "cx", "16");
		builder.AddAttribute(45, "cy", "22");
		builder.AddAttribute(46, "r", "3");
		builder.CloseElement();
		builder.OpenElement(47, "circle");
		builder.AddAttribute(48, "cx", "24");
		builder.AddAttribute(49, "cy", "15");
		builder.AddAttribute(50, "r", "3");
		builder.CloseElement();
		builder.OpenElement(51, "circle");
		builder.AddAttribute(52, "cx", "32");
		builder.AddAttribute(53, "cy", "20");
		builder.AddAttribute(54, "r", "3");
		builder.CloseElement();
		builder.OpenElement(55, "circle");
		builder.AddAttribute(56, "cx", "40");
		builder.AddAttribute(57, "cy", "8");
		builder.AddAttribute(58, "r", "3");
		builder.CloseElement();
		builder.OpenElement(59, "path");
		builder.AddAttribute(60, "d", "M38.3,6.9c-2.1,3.2-5.3,8-6.9,10.4c-1.2-0.7-3.1-2-6.4-4l-1.3-0.8l-8.3,7.3l-7-1.7l-1,3.9l9,2.3l7.7-6.7 c2.6,1.6,5.8,3.6,6.5,4.1l0.5,0.5l0.9-0.1c1.1-0.1,1.1-0.1,9.5-12.9L38.3,6.9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
