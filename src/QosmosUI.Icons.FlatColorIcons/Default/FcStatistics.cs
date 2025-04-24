// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcStatistics : ComponentBase
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
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "23");
		builder.AddAttribute(17, "y", "5");
		builder.AddAttribute(18, "width", "2");
		builder.AddAttribute(19, "height", "36");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "20.5");
		builder.AddAttribute(22, "y", "31.4");
		builder.AddAttribute(23, "transform", "matrix(.707 .707 -.707 .707 33.523 -3.921)");
		builder.AddAttribute(24, "width", "2");
		builder.AddAttribute(25, "height", "14.2");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "x", "25.5");
		builder.AddAttribute(28, "y", "31.4");
		builder.AddAttribute(29, "transform", "matrix(-.707 .707 -.707 -.707 72.487 46.995)");
		builder.AddAttribute(30, "width", "2");
		builder.AddAttribute(31, "height", "14.2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "4");
		builder.AddAttribute(34, "y", "8");
		builder.AddAttribute(35, "fill", "#CFD8DC");
		builder.AddAttribute(36, "width", "40");
		builder.AddAttribute(37, "height", "28");
		builder.CloseElement();
		builder.OpenElement(38, "g");
		builder.AddAttribute(39, "fill", "#607D8B");
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "3");
		builder.AddAttribute(42, "y", "7");
		builder.AddAttribute(43, "width", "42");
		builder.AddAttribute(44, "height", "4");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "x", "3");
		builder.AddAttribute(47, "y", "35");
		builder.AddAttribute(48, "width", "42");
		builder.AddAttribute(49, "height", "2");
		builder.CloseElement();
		builder.OpenElement(50, "circle");
		builder.AddAttribute(51, "cx", "31.5");
		builder.AddAttribute(52, "cy", "43.5");
		builder.AddAttribute(53, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(54, "circle");
		builder.AddAttribute(55, "cx", "16.5");
		builder.AddAttribute(56, "cy", "43.5");
		builder.AddAttribute(57, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(58, "g");
		builder.AddAttribute(59, "fill", "#C51162");
		builder.OpenElement(60, "polygon");
		builder.AddAttribute(61, "points", "31.9,18.9 26,24.9 20,18.9 11.9,26.9 14.1,29.1 20,23.1 26,29.1 34.1,21.1");
		builder.CloseElement();
		builder.OpenElement(62, "polygon");
		builder.AddAttribute(63, "points", "36,24 29,17 36,17");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
