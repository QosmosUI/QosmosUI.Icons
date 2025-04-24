// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Lucide.Default;

public class LuGrape : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M22 5V2l-5.89 5.89");
		builder.CloseElement();
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "16.6");
		builder.AddAttribute(17, "cy", "15.89");
		builder.AddAttribute(18, "r", "3");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "8.11");
		builder.AddAttribute(21, "cy", "7.4");
		builder.AddAttribute(22, "r", "3");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "12.35");
		builder.AddAttribute(25, "cy", "11.65");
		builder.AddAttribute(26, "r", "3");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "13.91");
		builder.AddAttribute(29, "cy", "5.85");
		builder.AddAttribute(30, "r", "3");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "18.15");
		builder.AddAttribute(33, "cy", "10.09");
		builder.AddAttribute(34, "r", "3");
		builder.CloseElement();
		builder.OpenElement(35, "circle");
		builder.AddAttribute(36, "cx", "6.56");
		builder.AddAttribute(37, "cy", "13.2");
		builder.AddAttribute(38, "r", "3");
		builder.CloseElement();
		builder.OpenElement(39, "circle");
		builder.AddAttribute(40, "cx", "10.8");
		builder.AddAttribute(41, "cy", "17.44");
		builder.AddAttribute(42, "r", "3");
		builder.CloseElement();
		builder.OpenElement(43, "circle");
		builder.AddAttribute(44, "cx", "5");
		builder.AddAttribute(45, "cy", "19");
		builder.AddAttribute(46, "r", "3");
		builder.CloseElement();
		builder.CloseElement();
    }
}
