// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcAlarmClock : ComponentBase
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
		builder.AddAttribute(14, "fill", "#37474F");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M38.5,44.6l-4-4l2.1-2.1l4,4c0.6,0.6,0.6,1.5,0,2.1l0,0C40.1,45.1,39.1,45.1,38.5,44.6z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M9.5,44.6l4-4l-2.1-2.1l-4,4c-0.6,0.6-0.6,1.5,0,2.1l0,0C7.9,45.1,8.9,45.1,9.5,44.6z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "fill", "#C62828");
		builder.AddAttribute(21, "cx", "24");
		builder.AddAttribute(22, "cy", "24");
		builder.AddAttribute(23, "r", "20");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "fill", "#eee");
		builder.AddAttribute(26, "cx", "24");
		builder.AddAttribute(27, "cy", "24");
		builder.AddAttribute(28, "r", "16");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "19");
		builder.AddAttribute(31, "y", "22.1");
		builder.AddAttribute(32, "transform", "matrix(-.707 -.707 .707 -.707 12.904 62.537)");
		builder.AddAttribute(33, "fill", "#E53935");
		builder.AddAttribute(34, "width", ".8");
		builder.AddAttribute(35, "height", "13");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "x", "23");
		builder.AddAttribute(38, "y", "11");
		builder.AddAttribute(39, "width", "2");
		builder.AddAttribute(40, "height", "13");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "26.1");
		builder.AddAttribute(43, "y", "22.7");
		builder.AddAttribute(44, "transform", "matrix(-.707 .707 -.707 -.707 65.787 27.25)");
		builder.AddAttribute(45, "width", "2.3");
		builder.AddAttribute(46, "height", "9.2");
		builder.CloseElement();
		builder.OpenElement(47, "circle");
		builder.AddAttribute(48, "cx", "24");
		builder.AddAttribute(49, "cy", "24");
		builder.AddAttribute(50, "r", "2");
		builder.CloseElement();
		builder.OpenElement(51, "circle");
		builder.AddAttribute(52, "fill", "#C62828");
		builder.AddAttribute(53, "cx", "24");
		builder.AddAttribute(54, "cy", "24");
		builder.AddAttribute(55, "r", "1");
		builder.CloseElement();
		builder.OpenElement(56, "rect");
		builder.AddAttribute(57, "x", "22");
		builder.AddAttribute(58, "y", "1");
		builder.AddAttribute(59, "fill", "#37474F");
		builder.AddAttribute(60, "width", "4");
		builder.AddAttribute(61, "height", "3");
		builder.CloseElement();
		builder.OpenElement(62, "g");
		builder.AddAttribute(63, "fill", "#37474F");
		builder.OpenElement(64, "path");
		builder.AddAttribute(65, "d", "M44.4,16.2c2.5-3.5,2.1-8.4-1-11.5c-3.1-3.1-8-3.5-11.5-1L44.4,16.2z");
		builder.CloseElement();
		builder.OpenElement(66, "path");
		builder.AddAttribute(67, "d", "M3.6,16.2c-2.5-3.5-2.1-8.4,1-11.5c3.1-3.1,8-3.5,11.5-1L3.6,16.2z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
