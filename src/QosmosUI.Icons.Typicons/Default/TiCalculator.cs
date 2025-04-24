// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiCalculator : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "M17 21h-8c-1.7 0-3-1.3-3-3v-12c0-1.7 1.3-3 3-3h8c1.7 0 3 1.3 3 3v12c0 1.7-1.3 3-3 3zm-8-16c-.6 0-1 .4-1 1v12c0 .6.4 1 1 1h8c.6 0 1-.4 1-1v-12c0-.6-.4-1-1-1h-8z");
		builder.CloseElement();
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "10");
		builder.AddAttribute(17, "cy", "11");
		builder.AddAttribute(18, "r", "1");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "13");
		builder.AddAttribute(21, "cy", "11");
		builder.AddAttribute(22, "r", "1");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "16");
		builder.AddAttribute(25, "cy", "11");
		builder.AddAttribute(26, "r", "1");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "10");
		builder.AddAttribute(29, "cy", "14");
		builder.AddAttribute(30, "r", "1");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "13");
		builder.AddAttribute(33, "cy", "14");
		builder.AddAttribute(34, "r", "1");
		builder.CloseElement();
		builder.OpenElement(35, "circle");
		builder.AddAttribute(36, "cx", "16");
		builder.AddAttribute(37, "cy", "14");
		builder.AddAttribute(38, "r", "1");
		builder.CloseElement();
		builder.OpenElement(39, "circle");
		builder.AddAttribute(40, "cx", "10");
		builder.AddAttribute(41, "cy", "17");
		builder.AddAttribute(42, "r", "1");
		builder.CloseElement();
		builder.OpenElement(43, "circle");
		builder.AddAttribute(44, "cx", "13");
		builder.AddAttribute(45, "cy", "17");
		builder.AddAttribute(46, "r", "1");
		builder.CloseElement();
		builder.OpenElement(47, "circle");
		builder.AddAttribute(48, "cx", "16");
		builder.AddAttribute(49, "cy", "17");
		builder.AddAttribute(50, "r", "1");
		builder.CloseElement();
		builder.OpenElement(51, "path");
		builder.AddAttribute(52, "d", "M16 7v1h-6v-1h6m1-1h-8v3h8v-3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
