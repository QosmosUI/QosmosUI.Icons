// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcStackOfPhotos : ComponentBase
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
		builder.AddAttribute(14, "x", "12.3");
		builder.AddAttribute(15, "y", "12.3");
		builder.AddAttribute(16, "transform", "matrix(.948 .318 -.318 .948 9.725 -6.994)");
		builder.AddAttribute(17, "fill", "#64B5F6");
		builder.AddAttribute(18, "width", "28");
		builder.AddAttribute(19, "height", "28");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "15.6");
		builder.AddAttribute(22, "y", "15.4");
		builder.AddAttribute(23, "transform", "matrix(.951 .31 -.31 .951 9.176 -6.977)");
		builder.AddAttribute(24, "fill", "#1E88E5");
		builder.AddAttribute(25, "width", "22");
		builder.AddAttribute(26, "height", "20");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "8.1");
		builder.AddAttribute(29, "y", "8.1");
		builder.AddAttribute(30, "transform", "matrix(.983 .181 -.181 .983 4.385 -3.65)");
		builder.AddAttribute(31, "fill", "#90CAF9");
		builder.AddAttribute(32, "width", "28");
		builder.AddAttribute(33, "height", "28");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "11.3");
		builder.AddAttribute(36, "y", "11.2");
		builder.AddAttribute(37, "transform", "matrix(.985 .175 -.175 .985 4.048 -3.566)");
		builder.AddAttribute(38, "fill", "#42A5F5");
		builder.AddAttribute(39, "width", "22");
		builder.AddAttribute(40, "height", "20");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "4");
		builder.AddAttribute(43, "y", "4");
		builder.AddAttribute(44, "fill", "#BBDEFB");
		builder.AddAttribute(45, "width", "28");
		builder.AddAttribute(46, "height", "28");
		builder.CloseElement();
		builder.OpenElement(47, "rect");
		builder.AddAttribute(48, "x", "7");
		builder.AddAttribute(49, "y", "7");
		builder.AddAttribute(50, "fill", "#4CAF50");
		builder.AddAttribute(51, "width", "22");
		builder.AddAttribute(52, "height", "20");
		builder.CloseElement();
		builder.OpenElement(53, "path");
		builder.AddAttribute(54, "fill", "#fff");
		builder.AddAttribute(55, "d", "M16,13c0-1.1,0.9-2,2-2s2,0.9,2,2s-2,4-2,4S16,14.1,16,13z");
		builder.CloseElement();
		builder.OpenElement(56, "path");
		builder.AddAttribute(57, "fill", "#fff");
		builder.AddAttribute(58, "d", "M20,21c0,1.1-0.9,2-2,2s-2-0.9-2-2s2-4,2-4S20,19.9,20,21z");
		builder.CloseElement();
		builder.OpenElement(59, "path");
		builder.AddAttribute(60, "fill", "#fff");
		builder.AddAttribute(61, "d", "M13.5,16.7c-1-0.6-1.3-1.8-0.7-2.7c0.6-1,1.8-1.3,2.7-0.7c1,0.6,2.5,3.7,2.5,3.7S14.5,17.3,13.5,16.7z");
		builder.CloseElement();
		builder.OpenElement(62, "path");
		builder.AddAttribute(63, "fill", "#fff");
		builder.AddAttribute(64, "d", "M22.5,17.3c1,0.6,1.3,1.8,0.7,2.7c-0.6,1-1.8,1.3-2.7,0.7C19.5,20.2,18,17,18,17S21.5,16.7,22.5,17.3z");
		builder.CloseElement();
		builder.OpenElement(65, "path");
		builder.AddAttribute(66, "fill", "#fff");
		builder.AddAttribute(67, "d", "M22.5,16.7c1-0.6,1.3-1.8,0.7-2.7c-0.6-1-1.8-1.3-2.7-0.7C19.5,13.8,18,17,18,17S21.5,17.3,22.5,16.7z");
		builder.CloseElement();
		builder.OpenElement(68, "path");
		builder.AddAttribute(69, "fill", "#fff");
		builder.AddAttribute(70, "d", "M13.5,17.3c-1,0.6-1.3,1.8-0.7,2.7c0.6,1,1.8,1.3,2.7,0.7c1-0.6,2.5-3.7,2.5-3.7S14.5,16.7,13.5,17.3z");
		builder.CloseElement();
		builder.OpenElement(71, "circle");
		builder.AddAttribute(72, "fill", "#FFC107");
		builder.AddAttribute(73, "cx", "18");
		builder.AddAttribute(74, "cy", "17");
		builder.AddAttribute(75, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
