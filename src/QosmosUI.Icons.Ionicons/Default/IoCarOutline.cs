// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoCarOutline : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M80,224l37.78-88.15C123.93,121.5,139.6,112,157.11,112H354.89c17.51,0,33.18,9.5,39.33,23.85L432,224");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linecap", "round");
		builder.AddAttribute(17, "stroke-linejoin", "round");
		builder.AddAttribute(18, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "80");
		builder.AddAttribute(21, "y", "224");
		builder.AddAttribute(22, "width", "352");
		builder.AddAttribute(23, "height", "144");
		builder.AddAttribute(24, "fill", "none");
		builder.AddAttribute(25, "stroke-linecap", "round");
		builder.AddAttribute(26, "stroke-linejoin", "round");
		builder.AddAttribute(27, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(28, "polyline");
		builder.AddAttribute(29, "points", "112 368 112 400 80 400 80 368");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linecap", "round");
		builder.AddAttribute(32, "stroke-linejoin", "round");
		builder.AddAttribute(33, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(34, "polyline");
		builder.AddAttribute(35, "points", "432 368 432 400 400 400 400 368");
		builder.AddAttribute(36, "fill", "none");
		builder.AddAttribute(37, "stroke-linecap", "round");
		builder.AddAttribute(38, "stroke-linejoin", "round");
		builder.AddAttribute(39, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "144");
		builder.AddAttribute(42, "cy", "288");
		builder.AddAttribute(43, "r", "16");
		builder.AddAttribute(44, "fill", "none");
		builder.AddAttribute(45, "stroke-linecap", "round");
		builder.AddAttribute(46, "stroke-linejoin", "round");
		builder.AddAttribute(47, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(48, "circle");
		builder.AddAttribute(49, "cx", "368");
		builder.AddAttribute(50, "cy", "288");
		builder.AddAttribute(51, "r", "16");
		builder.AddAttribute(52, "fill", "none");
		builder.AddAttribute(53, "stroke-linecap", "round");
		builder.AddAttribute(54, "stroke-linejoin", "round");
		builder.AddAttribute(55, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
