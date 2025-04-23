// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneMedicationLiquid : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "g");
		builder.AddAttribute(22, "opacity", ".3");
		builder.OpenElement(23, "defs");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "11");
		builder.AddAttribute(26, "id", "SVGID_1_");
		builder.AddAttribute(27, "opacity", ".3");
		builder.AddAttribute(28, "width", "10");
		builder.AddAttribute(29, "x", "4");
		builder.AddAttribute(30, "y", "8");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(31, "use");
		builder.AddAttribute(32, "overflow", "visible");
		builder.AddAttribute(33, "xlink:href", "#SVGID_1_");
		builder.CloseElement();
		builder.OpenElement(34, "clipPath");
		builder.AddAttribute(35, "id", "SVGID_2_");
		builder.OpenElement(36, "use");
		builder.AddAttribute(37, "overflow", "visible");
		builder.AddAttribute(38, "xlink:href", "#SVGID_1_");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "clip-path", "url(#SVGID_2_)");
		builder.AddAttribute(41, "d", "M4,19h10V8H4V19z M5,12h2.5V9.5h3V12H13v3h-2.5v2.5h-3V15H5V12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "height", "2");
		builder.AddAttribute(44, "width", "12");
		builder.AddAttribute(45, "x", "3");
		builder.AddAttribute(46, "y", "3");
		builder.CloseElement();
		builder.OpenElement(47, "path");
		builder.AddAttribute(48, "d", "M14,6H4C2.9,6,2,6.9,2,8v11c0,1.1,0.9,2,2,2h10c1.1,0,2-0.9,2-2V8C16,6.9,15.1,6,14,6 M14,19H4V8h10V19z");
		builder.CloseElement();
		builder.OpenElement(49, "polygon");
		builder.AddAttribute(50, "points", "7.5,17.5 10.5,17.5 10.5,15 13,15 13,12 10.5,12 10.5,9.5 7.5,9.5 7.5,12 5,12 5,15 7.5,15");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(51, "ellipse");
		builder.AddAttribute(52, "cx", "20");
		builder.AddAttribute(53, "cy", "10");
		builder.AddAttribute(54, "opacity", ".3");
		builder.AddAttribute(55, "rx", "1");
		builder.AddAttribute(56, "ry", "2");
		builder.CloseElement();
		builder.OpenElement(57, "path");
		builder.AddAttribute(58, "d", "M20,6c-1.68,0-3,1.76-3,4c0,1.77,0.83,3.22,2,3.76V20c0,0.55,0.45,1,1,1s1-0.45,1-1v-6.24c1.17-0.54,2-1.99,2-3.76 C23,7.76,21.68,6,20,6z M20,12c-0.41,0-1-0.78-1-2s0.59-2,1-2s1,0.78,1,2S20.41,12,20,12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
