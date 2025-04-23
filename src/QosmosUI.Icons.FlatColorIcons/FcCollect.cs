// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCollect : ComponentBase
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
		builder.AddAttribute(14, "fill", "#009688");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "22");
		builder.AddAttribute(17, "y", "35");
		builder.AddAttribute(18, "width", "4");
		builder.AddAttribute(19, "height", "11");
		builder.CloseElement();
		builder.OpenElement(20, "polygon");
		builder.AddAttribute(21, "points", "24,29.6 31,38 17,38");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#009688");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "22");
		builder.AddAttribute(26, "y", "2");
		builder.AddAttribute(27, "width", "4");
		builder.AddAttribute(28, "height", "11");
		builder.CloseElement();
		builder.OpenElement(29, "polygon");
		builder.AddAttribute(30, "points", "24,18.4 17,10 31,10");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(31, "g");
		builder.AddAttribute(32, "fill", "#009688");
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "x", "2");
		builder.AddAttribute(35, "y", "22");
		builder.AddAttribute(36, "width", "11");
		builder.AddAttribute(37, "height", "4");
		builder.CloseElement();
		builder.OpenElement(38, "polygon");
		builder.AddAttribute(39, "points", "18.4,24 10,31 10,17");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(40, "g");
		builder.AddAttribute(41, "fill", "#009688");
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "x", "35");
		builder.AddAttribute(44, "y", "22");
		builder.AddAttribute(45, "width", "11");
		builder.AddAttribute(46, "height", "4");
		builder.CloseElement();
		builder.OpenElement(47, "polygon");
		builder.AddAttribute(48, "points", "29.6,24 38,17 38,31");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(49, "circle");
		builder.AddAttribute(50, "fill", "#F44336");
		builder.AddAttribute(51, "cx", "24");
		builder.AddAttribute(52, "cy", "24");
		builder.AddAttribute(53, "r", "3");
		builder.CloseElement();
		builder.CloseElement();
    }
}
