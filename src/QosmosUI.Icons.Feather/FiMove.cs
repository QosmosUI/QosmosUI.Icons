// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Feather;

public class FiMove : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

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
		builder.OpenElement(13, "polyline");
		builder.AddAttribute(14, "points", "5 9 2 12 5 15");
		builder.CloseElement();
		builder.OpenElement(15, "polyline");
		builder.AddAttribute(16, "points", "9 5 12 2 15 5");
		builder.CloseElement();
		builder.OpenElement(17, "polyline");
		builder.AddAttribute(18, "points", "15 19 12 22 9 19");
		builder.CloseElement();
		builder.OpenElement(19, "polyline");
		builder.AddAttribute(20, "points", "19 9 22 12 19 15");
		builder.CloseElement();
		builder.OpenElement(21, "line");
		builder.AddAttribute(22, "x1", "2");
		builder.AddAttribute(23, "y1", "12");
		builder.AddAttribute(24, "x2", "22");
		builder.AddAttribute(25, "y2", "12");
		builder.CloseElement();
		builder.OpenElement(26, "line");
		builder.AddAttribute(27, "x1", "12");
		builder.AddAttribute(28, "y1", "2");
		builder.AddAttribute(29, "x2", "12");
		builder.AddAttribute(30, "y2", "22");
		builder.CloseElement();
		builder.CloseElement();
    }
}
