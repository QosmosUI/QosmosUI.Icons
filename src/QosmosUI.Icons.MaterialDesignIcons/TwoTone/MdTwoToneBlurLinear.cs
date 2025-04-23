// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneBlurLinear : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M17 16.5c.28 0 .5-.22.5-.5s-.22-.5-.5-.5-.5.22-.5.5.22.5.5.5z");
		builder.CloseElement();
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "9");
		builder.AddAttribute(20, "cy", "12");
		builder.AddAttribute(21, "r", "1");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "13");
		builder.AddAttribute(24, "cy", "8");
		builder.AddAttribute(25, "r", "1");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "13");
		builder.AddAttribute(28, "cy", "16");
		builder.AddAttribute(29, "r", "1");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M17 12.5c.28 0 .5-.22.5-.5s-.22-.5-.5-.5-.5.22-.5.5.22.5.5.5z");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "13");
		builder.AddAttribute(34, "cy", "12");
		builder.AddAttribute(35, "r", "1");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M3 3h18v2H3z");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "5");
		builder.AddAttribute(40, "cy", "8");
		builder.AddAttribute(41, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "5");
		builder.AddAttribute(44, "cy", "12");
		builder.AddAttribute(45, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "5");
		builder.AddAttribute(48, "cy", "16");
		builder.AddAttribute(49, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(50, "path");
		builder.AddAttribute(51, "d", "M17 8.5c.28 0 .5-.22.5-.5s-.22-.5-.5-.5-.5.22-.5.5.22.5.5.5z");
		builder.CloseElement();
		builder.OpenElement(52, "circle");
		builder.AddAttribute(53, "cx", "9");
		builder.AddAttribute(54, "cy", "16");
		builder.AddAttribute(55, "r", "1");
		builder.CloseElement();
		builder.OpenElement(56, "circle");
		builder.AddAttribute(57, "cx", "9");
		builder.AddAttribute(58, "cy", "8");
		builder.AddAttribute(59, "r", "1");
		builder.CloseElement();
		builder.OpenElement(60, "path");
		builder.AddAttribute(61, "d", "M3 19h18v2H3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
