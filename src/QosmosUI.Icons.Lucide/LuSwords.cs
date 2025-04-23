// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Lucide;

public class LuSwords : ComponentBase
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
		builder.AddAttribute(14, "points", "14.5 17.5 3 6 3 3 6 3 17.5 14.5");
		builder.CloseElement();
		builder.OpenElement(15, "line");
		builder.AddAttribute(16, "x1", "13");
		builder.AddAttribute(17, "x2", "19");
		builder.AddAttribute(18, "y1", "19");
		builder.AddAttribute(19, "y2", "13");
		builder.CloseElement();
		builder.OpenElement(20, "line");
		builder.AddAttribute(21, "x1", "16");
		builder.AddAttribute(22, "x2", "20");
		builder.AddAttribute(23, "y1", "16");
		builder.AddAttribute(24, "y2", "20");
		builder.CloseElement();
		builder.OpenElement(25, "line");
		builder.AddAttribute(26, "x1", "19");
		builder.AddAttribute(27, "x2", "21");
		builder.AddAttribute(28, "y1", "21");
		builder.AddAttribute(29, "y2", "19");
		builder.CloseElement();
		builder.OpenElement(30, "polyline");
		builder.AddAttribute(31, "points", "14.5 6.5 18 3 21 3 21 6 17.5 9.5");
		builder.CloseElement();
		builder.OpenElement(32, "line");
		builder.AddAttribute(33, "x1", "5");
		builder.AddAttribute(34, "x2", "9");
		builder.AddAttribute(35, "y1", "14");
		builder.AddAttribute(36, "y2", "18");
		builder.CloseElement();
		builder.OpenElement(37, "line");
		builder.AddAttribute(38, "x1", "7");
		builder.AddAttribute(39, "x2", "4");
		builder.AddAttribute(40, "y1", "17");
		builder.AddAttribute(41, "y2", "20");
		builder.CloseElement();
		builder.OpenElement(42, "line");
		builder.AddAttribute(43, "x1", "3");
		builder.AddAttribute(44, "x2", "5");
		builder.AddAttribute(45, "y1", "19");
		builder.AddAttribute(46, "y2", "21");
		builder.CloseElement();
		builder.CloseElement();
    }
}
