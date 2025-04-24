// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcSearch : ComponentBase
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
		builder.AddAttribute(14, "fill", "#616161");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "34.6");
		builder.AddAttribute(17, "y", "28.1");
		builder.AddAttribute(18, "transform", "matrix(.707 -.707 .707 .707 -15.154 36.586)");
		builder.AddAttribute(19, "width", "4");
		builder.AddAttribute(20, "height", "17");
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "20");
		builder.AddAttribute(23, "cy", "20");
		builder.AddAttribute(24, "r", "16");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "36.2");
		builder.AddAttribute(27, "y", "32.1");
		builder.AddAttribute(28, "transform", "matrix(.707 -.707 .707 .707 -15.839 38.239)");
		builder.AddAttribute(29, "fill", "#37474F");
		builder.AddAttribute(30, "width", "4");
		builder.AddAttribute(31, "height", "12.3");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "fill", "#64B5F6");
		builder.AddAttribute(34, "cx", "20");
		builder.AddAttribute(35, "cy", "20");
		builder.AddAttribute(36, "r", "13");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "fill", "#BBDEFB");
		builder.AddAttribute(39, "d", "M26.9,14.2c-1.7-2-4.2-3.2-6.9-3.2s-5.2,1.2-6.9,3.2c-0.4,0.4-0.3,1.1,0.1,1.4c0.4,0.4,1.1,0.3,1.4-0.1 C16,13.9,17.9,13,20,13s4,0.9,5.4,2.5c0.2,0.2,0.5,0.4,0.8,0.4c0.2,0,0.5-0.1,0.6-0.2C27.2,15.3,27.2,14.6,26.9,14.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
