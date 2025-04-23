// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineStream : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "20");
		builder.AddAttribute(22, "cy", "12");
		builder.AddAttribute(23, "r", "2");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "4");
		builder.AddAttribute(26, "cy", "12");
		builder.AddAttribute(27, "r", "2");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "12");
		builder.AddAttribute(30, "cy", "20");
		builder.AddAttribute(31, "r", "2");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "2");
		builder.AddAttribute(34, "transform", "matrix(0.7081 -0.7061 0.7061 0.7081 -0.1146 13.9802)");
		builder.AddAttribute(35, "width", "6.22");
		builder.AddAttribute(36, "x", "13.74");
		builder.AddAttribute(37, "y", "6.13");
		builder.CloseElement();
		builder.OpenElement(38, "polygon");
		builder.AddAttribute(39, "points", "8.32,9.68 8.63,10 10.05,8.59 6.03,4.55 6.02,4.55 5.71,4.23 4.29,5.64 8.31,9.69");
		builder.CloseElement();
		builder.OpenElement(40, "polygon");
		builder.AddAttribute(41, "points", "15.41,13.94 14,15.35 17.99,19.36 18.34,19.71 19.76,18.3 15.77,14.29");
		builder.CloseElement();
		builder.OpenElement(42, "polygon");
		builder.AddAttribute(43, "points", "8.59,13.95 4.56,17.96 4.24,18.29 5.65,19.7 9.68,15.68 10.01,15.36");
		builder.CloseElement();
		builder.OpenElement(44, "circle");
		builder.AddAttribute(45, "cx", "12");
		builder.AddAttribute(46, "cy", "4");
		builder.AddAttribute(47, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
