// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Feather;

public class FiShare2 : ComponentBase
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
		builder.AddAttribute(14, "cx", "18");
		builder.AddAttribute(15, "cy", "5");
		builder.AddAttribute(16, "r", "3");
		builder.CloseElement();
		builder.OpenElement(17, "circle");
		builder.AddAttribute(18, "cx", "6");
		builder.AddAttribute(19, "cy", "12");
		builder.AddAttribute(20, "r", "3");
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "18");
		builder.AddAttribute(23, "cy", "19");
		builder.AddAttribute(24, "r", "3");
		builder.CloseElement();
		builder.OpenElement(25, "line");
		builder.AddAttribute(26, "x1", "8.59");
		builder.AddAttribute(27, "y1", "13.51");
		builder.AddAttribute(28, "x2", "15.42");
		builder.AddAttribute(29, "y2", "17.49");
		builder.CloseElement();
		builder.OpenElement(30, "line");
		builder.AddAttribute(31, "x1", "15.41");
		builder.AddAttribute(32, "y1", "6.51");
		builder.AddAttribute(33, "x2", "8.59");
		builder.AddAttribute(34, "y2", "10.49");
		builder.CloseElement();
		builder.CloseElement();
    }
}
