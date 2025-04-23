// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcRadarPlot : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "#CFD8DC");
		builder.AddAttribute(15, "d", "M38.4,13L24.1,6.4L4.6,12.1l8.8,13.2l-2.2,15.1h22.7l6.6-13.3L38.4,13z M32.1,37.5H14.7l1.8-12.9L9.4,13.9 l14.5-4.3L35.6,15l1.8,11.7L32.1,37.5z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#00BCD4");
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "24");
		builder.AddAttribute(20, "cy", "8");
		builder.AddAttribute(21, "r", "4");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "37");
		builder.AddAttribute(24, "cy", "14");
		builder.AddAttribute(25, "r", "4");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "39");
		builder.AddAttribute(28, "cy", "27");
		builder.AddAttribute(29, "r", "4");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "7");
		builder.AddAttribute(32, "cy", "13");
		builder.AddAttribute(33, "r", "4");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "13");
		builder.AddAttribute(36, "cy", "39");
		builder.AddAttribute(37, "r", "4");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "15");
		builder.AddAttribute(40, "cy", "25");
		builder.AddAttribute(41, "r", "4");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "33");
		builder.AddAttribute(44, "cy", "39");
		builder.AddAttribute(45, "r", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
