// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Feather;

public class FiLifeBuoy : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "12");
		builder.AddAttribute(15, "cy", "12");
		builder.AddAttribute(16, "r", "10");
		builder.CloseElement();
		builder.OpenElement(17, "circle");
		builder.AddAttribute(18, "cx", "12");
		builder.AddAttribute(19, "cy", "12");
		builder.AddAttribute(20, "r", "4");
		builder.CloseElement();
		builder.OpenElement(21, "line");
		builder.AddAttribute(22, "x1", "4.93");
		builder.AddAttribute(23, "y1", "4.93");
		builder.AddAttribute(24, "x2", "9.17");
		builder.AddAttribute(25, "y2", "9.17");
		builder.CloseElement();
		builder.OpenElement(26, "line");
		builder.AddAttribute(27, "x1", "14.83");
		builder.AddAttribute(28, "y1", "14.83");
		builder.AddAttribute(29, "x2", "19.07");
		builder.AddAttribute(30, "y2", "19.07");
		builder.CloseElement();
		builder.OpenElement(31, "line");
		builder.AddAttribute(32, "x1", "14.83");
		builder.AddAttribute(33, "y1", "9.17");
		builder.AddAttribute(34, "x2", "19.07");
		builder.AddAttribute(35, "y2", "4.93");
		builder.CloseElement();
		builder.OpenElement(36, "line");
		builder.AddAttribute(37, "x1", "14.83");
		builder.AddAttribute(38, "y1", "9.17");
		builder.AddAttribute(39, "x2", "18.36");
		builder.AddAttribute(40, "y2", "5.64");
		builder.CloseElement();
		builder.OpenElement(41, "line");
		builder.AddAttribute(42, "x1", "4.93");
		builder.AddAttribute(43, "y1", "19.07");
		builder.AddAttribute(44, "x2", "9.17");
		builder.AddAttribute(45, "y2", "14.83");
		builder.CloseElement();
		builder.CloseElement();
    }
}
