// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Lucide.Default;

public class LuChartScatter : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "7.5");
		builder.AddAttribute(15, "cy", "7.5");
		builder.AddAttribute(16, "r", ".5");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "18.5");
		builder.AddAttribute(20, "cy", "5.5");
		builder.AddAttribute(21, "r", ".5");
		builder.AddAttribute(22, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "11.5");
		builder.AddAttribute(25, "cy", "11.5");
		builder.AddAttribute(26, "r", ".5");
		builder.AddAttribute(27, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "7.5");
		builder.AddAttribute(30, "cy", "16.5");
		builder.AddAttribute(31, "r", ".5");
		builder.AddAttribute(32, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "cx", "17.5");
		builder.AddAttribute(35, "cy", "14.5");
		builder.AddAttribute(36, "r", ".5");
		builder.AddAttribute(37, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M3 3v16a2 2 0 0 0 2 2h16");
		builder.CloseElement();
		builder.CloseElement();
    }
}
