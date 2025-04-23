// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcClearFilters : ComponentBase
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
		builder.OpenElement(13, "polygon");
		builder.AddAttribute(14, "fill", "#F57C00");
		builder.AddAttribute(15, "points", "29,23 19,23 7,9 41,9");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#FF9800");
		builder.OpenElement(18, "polygon");
		builder.AddAttribute(19, "points", "29,38 19,44 19,23 29,23");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M41.5,9h-35C5.7,9,5,8.3,5,7.5v0C5,6.7,5.7,6,6.5,6h35C42.3,6,43,6.7,43,7.5v0C43,8.3,42.3,9,41.5,9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "fill", "#F44336");
		builder.AddAttribute(24, "cx", "38");
		builder.AddAttribute(25, "cy", "38");
		builder.AddAttribute(26, "r", "10");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "32");
		builder.AddAttribute(29, "y", "36");
		builder.AddAttribute(30, "fill", "#fff");
		builder.AddAttribute(31, "width", "12");
		builder.AddAttribute(32, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
    }
}
