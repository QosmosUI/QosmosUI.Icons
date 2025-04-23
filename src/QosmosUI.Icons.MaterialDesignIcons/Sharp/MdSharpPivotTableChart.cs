// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpPivotTableChart : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "height", "5");
		builder.AddAttribute(21, "width", "11");
		builder.AddAttribute(22, "x", "10");
		builder.AddAttribute(23, "y", "3");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "11");
		builder.AddAttribute(26, "width", "5");
		builder.AddAttribute(27, "x", "3");
		builder.AddAttribute(28, "y", "10");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "height", "5");
		builder.AddAttribute(31, "width", "5");
		builder.AddAttribute(32, "x", "3");
		builder.AddAttribute(33, "y", "3");
		builder.CloseElement();
		builder.OpenElement(34, "polygon");
		builder.AddAttribute(35, "points", "18,9 14,13 17,13 17,17 13,17 13,14 9,18 13,22 13,19 19,19 19,13 22,13");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
