// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Lucide.Default;

public class LuBatteryFull : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "width", "16");
		builder.AddAttribute(15, "height", "10");
		builder.AddAttribute(16, "x", "2");
		builder.AddAttribute(17, "y", "7");
		builder.AddAttribute(18, "rx", "2");
		builder.AddAttribute(19, "ry", "2");
		builder.CloseElement();
		builder.OpenElement(20, "line");
		builder.AddAttribute(21, "x1", "22");
		builder.AddAttribute(22, "x2", "22");
		builder.AddAttribute(23, "y1", "11");
		builder.AddAttribute(24, "y2", "13");
		builder.CloseElement();
		builder.OpenElement(25, "line");
		builder.AddAttribute(26, "x1", "6");
		builder.AddAttribute(27, "x2", "6");
		builder.AddAttribute(28, "y1", "11");
		builder.AddAttribute(29, "y2", "13");
		builder.CloseElement();
		builder.OpenElement(30, "line");
		builder.AddAttribute(31, "x1", "10");
		builder.AddAttribute(32, "x2", "10");
		builder.AddAttribute(33, "y1", "11");
		builder.AddAttribute(34, "y2", "13");
		builder.CloseElement();
		builder.OpenElement(35, "line");
		builder.AddAttribute(36, "x1", "14");
		builder.AddAttribute(37, "x2", "14");
		builder.AddAttribute(38, "y1", "11");
		builder.AddAttribute(39, "y2", "13");
		builder.CloseElement();
		builder.CloseElement();
    }
}
