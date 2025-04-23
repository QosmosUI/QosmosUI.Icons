// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Lucide;

public class LuSlack : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "width", "3");
		builder.AddAttribute(15, "height", "8");
		builder.AddAttribute(16, "x", "13");
		builder.AddAttribute(17, "y", "2");
		builder.AddAttribute(18, "rx", "1.5");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M19 8.5V10h1.5A1.5 1.5 0 1 0 19 8.5");
		builder.CloseElement();
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "width", "3");
		builder.AddAttribute(23, "height", "8");
		builder.AddAttribute(24, "x", "8");
		builder.AddAttribute(25, "y", "14");
		builder.AddAttribute(26, "rx", "1.5");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M5 15.5V14H3.5A1.5 1.5 0 1 0 5 15.5");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "width", "8");
		builder.AddAttribute(31, "height", "3");
		builder.AddAttribute(32, "x", "14");
		builder.AddAttribute(33, "y", "13");
		builder.AddAttribute(34, "rx", "1.5");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M15.5 19H14v1.5a1.5 1.5 0 1 0 1.5-1.5");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "width", "8");
		builder.AddAttribute(39, "height", "3");
		builder.AddAttribute(40, "x", "2");
		builder.AddAttribute(41, "y", "8");
		builder.AddAttribute(42, "rx", "1.5");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M8.5 5H10V3.5A1.5 1.5 0 1 0 8.5 5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
