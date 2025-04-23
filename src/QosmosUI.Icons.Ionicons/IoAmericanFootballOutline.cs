// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoAmericanFootballOutline : ComponentBase
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
		builder.OpenElement(13, "ellipse");
		builder.AddAttribute(14, "cx", "256");
		builder.AddAttribute(15, "cy", "256");
		builder.AddAttribute(16, "rx", "267.57");
		builder.AddAttribute(17, "ry", "173.44");
		builder.AddAttribute(18, "transform", "translate(-106.04 256) rotate(-45)");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "stroke-linecap", "round");
		builder.AddAttribute(21, "stroke-linejoin", "round");
		builder.AddAttribute(22, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(23, "line");
		builder.AddAttribute(24, "x1", "334.04");
		builder.AddAttribute(25, "y1", "177.96");
		builder.AddAttribute(26, "x2", "177.96");
		builder.AddAttribute(27, "y2", "334.04");
		builder.AddAttribute(28, "fill", "none");
		builder.AddAttribute(29, "stroke-linecap", "round");
		builder.AddAttribute(30, "stroke-linejoin", "round");
		builder.AddAttribute(31, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(32, "line");
		builder.AddAttribute(33, "x1", "278.3");
		builder.AddAttribute(34, "y1", "278.3");
		builder.AddAttribute(35, "x2", "233.7");
		builder.AddAttribute(36, "y2", "233.7");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-linecap", "round");
		builder.AddAttribute(39, "stroke-linejoin", "round");
		builder.AddAttribute(40, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(41, "line");
		builder.AddAttribute(42, "x1", "322.89");
		builder.AddAttribute(43, "y1", "233.7");
		builder.AddAttribute(44, "x2", "278.3");
		builder.AddAttribute(45, "y2", "189.11");
		builder.AddAttribute(46, "fill", "none");
		builder.AddAttribute(47, "stroke-linecap", "round");
		builder.AddAttribute(48, "stroke-linejoin", "round");
		builder.AddAttribute(49, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(50, "line");
		builder.AddAttribute(51, "x1", "456.68");
		builder.AddAttribute(52, "y1", "211.4");
		builder.AddAttribute(53, "x2", "300.6");
		builder.AddAttribute(54, "y2", "55.32");
		builder.AddAttribute(55, "fill", "none");
		builder.AddAttribute(56, "stroke-linecap", "round");
		builder.AddAttribute(57, "stroke-linejoin", "round");
		builder.AddAttribute(58, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(59, "line");
		builder.AddAttribute(60, "x1", "211.4");
		builder.AddAttribute(61, "y1", "456.68");
		builder.AddAttribute(62, "x2", "55.32");
		builder.AddAttribute(63, "y2", "300.6");
		builder.AddAttribute(64, "fill", "none");
		builder.AddAttribute(65, "stroke-linecap", "round");
		builder.AddAttribute(66, "stroke-linejoin", "round");
		builder.AddAttribute(67, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(68, "line");
		builder.AddAttribute(69, "x1", "233.7");
		builder.AddAttribute(70, "y1", "322.89");
		builder.AddAttribute(71, "x2", "189.11");
		builder.AddAttribute(72, "y2", "278.3");
		builder.AddAttribute(73, "fill", "none");
		builder.AddAttribute(74, "stroke-linecap", "round");
		builder.AddAttribute(75, "stroke-linejoin", "round");
		builder.AddAttribute(76, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
