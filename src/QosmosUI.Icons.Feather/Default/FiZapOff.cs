// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Feather.Default;

public class FiZapOff : ComponentBase
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
    public string StrokeWidth { get; set; } = "2";

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
		builder.AddAttribute(14, "points", "12.41 6.75 13 2 10.57 4.92");
		builder.CloseElement();
		builder.OpenElement(15, "polyline");
		builder.AddAttribute(16, "points", "18.57 12.91 21 10 15.66 10");
		builder.CloseElement();
		builder.OpenElement(17, "polyline");
		builder.AddAttribute(18, "points", "8 8 3 14 12 14 11 22 16 16");
		builder.CloseElement();
		builder.OpenElement(19, "line");
		builder.AddAttribute(20, "x1", "1");
		builder.AddAttribute(21, "y1", "1");
		builder.AddAttribute(22, "x2", "23");
		builder.AddAttribute(23, "y2", "23");
		builder.CloseElement();
		builder.CloseElement();
    }
}
