// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcDeleteColumn : ComponentBase
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
		builder.AddAttribute(14, "fill", "#90CAF9");
		builder.AddAttribute(15, "d", "M30,5H18c-2.2,0-4,1.8-4,4v30c0,2.2,1.8,4,4,4h12c2.2,0,4-1.8,4-4V9C34,6.8,32.2,5,30,5z M18,39V9h12l0,30 H18z");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "fill", "#F44336");
		builder.AddAttribute(18, "cx", "38");
		builder.AddAttribute(19, "cy", "38");
		builder.AddAttribute(20, "r", "10");
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.AddAttribute(22, "fill", "#fff");
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "x", "36.5");
		builder.AddAttribute(25, "y", "32");
		builder.AddAttribute(26, "transform", "matrix(-.707 .707 -.707 -.707 91.74 38)");
		builder.AddAttribute(27, "width", "3");
		builder.AddAttribute(28, "height", "12");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "36.5");
		builder.AddAttribute(31, "y", "32");
		builder.AddAttribute(32, "transform", "matrix(-.707 -.707 .707 -.707 38 91.74)");
		builder.AddAttribute(33, "width", "3");
		builder.AddAttribute(34, "height", "12");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
