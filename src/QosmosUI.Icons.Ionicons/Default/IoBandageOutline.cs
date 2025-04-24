// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoBandageOutline : ComponentBase
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
		builder.AddAttribute(14, "x", "-24.43");
		builder.AddAttribute(15, "y", "167.88");
		builder.AddAttribute(16, "width", "560.87");
		builder.AddAttribute(17, "height", "176.25");
		builder.AddAttribute(18, "rx", "88.12");
		builder.AddAttribute(19, "ry", "88.12");
		builder.AddAttribute(20, "transform", "translate(-106.04 256) rotate(-45)");
		builder.AddAttribute(21, "fill", "none");
		builder.AddAttribute(22, "stroke-linecap", "round");
		builder.AddAttribute(23, "stroke-linejoin", "round");
		builder.AddAttribute(24, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "169.41");
		builder.AddAttribute(27, "y", "156.59");
		builder.AddAttribute(28, "width", "176");
		builder.AddAttribute(29, "height", "196");
		builder.AddAttribute(30, "rx", "32");
		builder.AddAttribute(31, "ry", "32");
		builder.AddAttribute(32, "transform", "translate(255.41 -107.45) rotate(45)");
		builder.AddAttribute(33, "fill", "none");
		builder.AddAttribute(34, "stroke-linecap", "round");
		builder.AddAttribute(35, "stroke-linejoin", "round");
		builder.AddAttribute(36, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(37, "circle");
		builder.AddAttribute(38, "cx", "256");
		builder.AddAttribute(39, "cy", "208");
		builder.AddAttribute(40, "r", "16");
		builder.CloseElement();
		builder.OpenElement(41, "circle");
		builder.AddAttribute(42, "cx", "304");
		builder.AddAttribute(43, "cy", "256");
		builder.AddAttribute(44, "r", "16");
		builder.CloseElement();
		builder.OpenElement(45, "circle");
		builder.AddAttribute(46, "cx", "208");
		builder.AddAttribute(47, "cy", "256");
		builder.AddAttribute(48, "r", "16");
		builder.CloseElement();
		builder.OpenElement(49, "circle");
		builder.AddAttribute(50, "cx", "256");
		builder.AddAttribute(51, "cy", "304");
		builder.AddAttribute(52, "r", "16");
		builder.CloseElement();
		builder.CloseElement();
    }
}
