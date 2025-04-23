// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcOrganization : ComponentBase
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
		builder.AddAttribute(14, "fill", "#90CAF9");
		builder.AddAttribute(15, "d", "M42,42H6V10c0-2.2,1.8-4,4-4h28c2.2,0,4,1.8,4,4V42z");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "6");
		builder.AddAttribute(18, "y", "42");
		builder.AddAttribute(19, "fill", "#64B5F6");
		builder.AddAttribute(20, "width", "36");
		builder.AddAttribute(21, "height", "2");
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#1565C0");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "31");
		builder.AddAttribute(26, "y", "27");
		builder.AddAttribute(27, "width", "6");
		builder.AddAttribute(28, "height", "5");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "21");
		builder.AddAttribute(31, "y", "27");
		builder.AddAttribute(32, "width", "6");
		builder.AddAttribute(33, "height", "5");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "11");
		builder.AddAttribute(36, "y", "27");
		builder.AddAttribute(37, "width", "6");
		builder.AddAttribute(38, "height", "5");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "31");
		builder.AddAttribute(41, "y", "35");
		builder.AddAttribute(42, "width", "6");
		builder.AddAttribute(43, "height", "5");
		builder.CloseElement();
		builder.OpenElement(44, "rect");
		builder.AddAttribute(45, "x", "11");
		builder.AddAttribute(46, "y", "35");
		builder.AddAttribute(47, "width", "6");
		builder.AddAttribute(48, "height", "5");
		builder.CloseElement();
		builder.OpenElement(49, "rect");
		builder.AddAttribute(50, "x", "31");
		builder.AddAttribute(51, "y", "19");
		builder.AddAttribute(52, "width", "6");
		builder.AddAttribute(53, "height", "5");
		builder.CloseElement();
		builder.OpenElement(54, "rect");
		builder.AddAttribute(55, "x", "21");
		builder.AddAttribute(56, "y", "19");
		builder.AddAttribute(57, "width", "6");
		builder.AddAttribute(58, "height", "5");
		builder.CloseElement();
		builder.OpenElement(59, "rect");
		builder.AddAttribute(60, "x", "11");
		builder.AddAttribute(61, "y", "19");
		builder.AddAttribute(62, "width", "6");
		builder.AddAttribute(63, "height", "5");
		builder.CloseElement();
		builder.OpenElement(64, "rect");
		builder.AddAttribute(65, "x", "31");
		builder.AddAttribute(66, "y", "11");
		builder.AddAttribute(67, "width", "6");
		builder.AddAttribute(68, "height", "5");
		builder.CloseElement();
		builder.OpenElement(69, "rect");
		builder.AddAttribute(70, "x", "21");
		builder.AddAttribute(71, "y", "11");
		builder.AddAttribute(72, "width", "6");
		builder.AddAttribute(73, "height", "5");
		builder.CloseElement();
		builder.OpenElement(74, "rect");
		builder.AddAttribute(75, "x", "11");
		builder.AddAttribute(76, "y", "11");
		builder.AddAttribute(77, "width", "6");
		builder.AddAttribute(78, "height", "5");
		builder.CloseElement();
		builder.OpenElement(79, "rect");
		builder.AddAttribute(80, "x", "21");
		builder.AddAttribute(81, "y", "35");
		builder.AddAttribute(82, "width", "6");
		builder.AddAttribute(83, "height", "9");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
