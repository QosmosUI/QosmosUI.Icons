// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcRuler : ComponentBase
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
		builder.AddAttribute(14, "x", "16.7");
		builder.AddAttribute(15, "y", "1.6");
		builder.AddAttribute(16, "transform", "matrix(-.707 -.707 .707 -.707 24 57.941)");
		builder.AddAttribute(17, "fill", "#FFA000");
		builder.AddAttribute(18, "width", "14.6");
		builder.AddAttribute(19, "height", "44.8");
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.AddAttribute(21, "fill", "#9E6400");
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "x", "17.9");
		builder.AddAttribute(24, "y", "20.2");
		builder.AddAttribute(25, "transform", "matrix(-.707 -.707 .707 -.707 21.177 51.125)");
		builder.AddAttribute(26, "width", "6.6");
		builder.AddAttribute(27, "height", "2");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "x", "22.3");
		builder.AddAttribute(30, "y", "15.2");
		builder.AddAttribute(31, "transform", "matrix(-.707 -.707 .707 -.707 29.833 44.71)");
		builder.AddAttribute(32, "width", "3.7");
		builder.AddAttribute(33, "height", "2");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "25.9");
		builder.AddAttribute(36, "y", "12.2");
		builder.AddAttribute(37, "transform", "matrix(-.707 -.707 .707 -.707 40.49 43.125)");
		builder.AddAttribute(38, "width", "6.6");
		builder.AddAttribute(39, "height", "2");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "31.2");
		builder.AddAttribute(42, "y", "6.3");
		builder.AddAttribute(43, "transform", "matrix(.707 -.707 .707 .707 3.643 25.147)");
		builder.AddAttribute(44, "width", "2");
		builder.AddAttribute(45, "height", "3.7");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "x", "6.3");
		builder.AddAttribute(48, "y", "31.2");
		builder.AddAttribute(49, "transform", "matrix(-.707 -.707 .707 -.707 -8.794 60.71)");
		builder.AddAttribute(50, "width", "3.7");
		builder.AddAttribute(51, "height", "2");
		builder.CloseElement();
		builder.OpenElement(52, "rect");
		builder.AddAttribute(53, "x", "9.9");
		builder.AddAttribute(54, "y", "28.2");
		builder.AddAttribute(55, "transform", "matrix(-.707 -.707 .707 -.707 1.863 59.125)");
		builder.AddAttribute(56, "width", "6.6");
		builder.AddAttribute(57, "height", "2");
		builder.CloseElement();
		builder.OpenElement(58, "rect");
		builder.AddAttribute(59, "x", "14.3");
		builder.AddAttribute(60, "y", "23.2");
		builder.AddAttribute(61, "transform", "matrix(-.707 -.707 .707 -.707 10.52 52.71)");
		builder.AddAttribute(62, "width", "3.7");
		builder.AddAttribute(63, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
