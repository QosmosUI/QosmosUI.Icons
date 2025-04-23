// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoCalculatorOutline : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "x", "112");
		builder.AddAttribute(15, "y", "48");
		builder.AddAttribute(16, "width", "288");
		builder.AddAttribute(17, "height", "416");
		builder.AddAttribute(18, "rx", "32");
		builder.AddAttribute(19, "ry", "32");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linecap", "round");
		builder.AddAttribute(22, "stroke-linejoin", "round");
		builder.AddAttribute(23, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "160.01");
		builder.AddAttribute(26, "y", "112");
		builder.AddAttribute(27, "width", "191.99");
		builder.AddAttribute(28, "height", "64");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "stroke-linecap", "round");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "cx", "168");
		builder.AddAttribute(35, "cy", "248");
		builder.AddAttribute(36, "r", "24");
		builder.CloseElement();
		builder.OpenElement(37, "circle");
		builder.AddAttribute(38, "cx", "256");
		builder.AddAttribute(39, "cy", "248");
		builder.AddAttribute(40, "r", "24");
		builder.CloseElement();
		builder.OpenElement(41, "circle");
		builder.AddAttribute(42, "cx", "344");
		builder.AddAttribute(43, "cy", "248");
		builder.AddAttribute(44, "r", "24");
		builder.CloseElement();
		builder.OpenElement(45, "circle");
		builder.AddAttribute(46, "cx", "168");
		builder.AddAttribute(47, "cy", "328");
		builder.AddAttribute(48, "r", "24");
		builder.CloseElement();
		builder.OpenElement(49, "circle");
		builder.AddAttribute(50, "cx", "256");
		builder.AddAttribute(51, "cy", "328");
		builder.AddAttribute(52, "r", "24");
		builder.CloseElement();
		builder.OpenElement(53, "circle");
		builder.AddAttribute(54, "cx", "168");
		builder.AddAttribute(55, "cy", "408");
		builder.AddAttribute(56, "r", "24");
		builder.CloseElement();
		builder.OpenElement(57, "circle");
		builder.AddAttribute(58, "cx", "256");
		builder.AddAttribute(59, "cy", "408");
		builder.AddAttribute(60, "r", "24");
		builder.CloseElement();
		builder.OpenElement(61, "rect");
		builder.AddAttribute(62, "x", "320");
		builder.AddAttribute(63, "y", "304");
		builder.AddAttribute(64, "width", "48");
		builder.AddAttribute(65, "height", "128");
		builder.AddAttribute(66, "rx", "24");
		builder.AddAttribute(67, "ry", "24");
		builder.CloseElement();
		builder.CloseElement();
    }
}
