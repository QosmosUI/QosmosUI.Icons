// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcDepartment : ComponentBase
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
		builder.OpenElement(13, "polygon");
		builder.AddAttribute(14, "fill", "#C5CAE9");
		builder.AddAttribute(15, "points", "42,42 6,42 6,9 24,2 42,9");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "6");
		builder.AddAttribute(18, "y", "42");
		builder.AddAttribute(19, "fill", "#9FA8DA");
		builder.AddAttribute(20, "width", "36");
		builder.AddAttribute(21, "height", "2");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "x", "20");
		builder.AddAttribute(24, "y", "35");
		builder.AddAttribute(25, "fill", "#BF360C");
		builder.AddAttribute(26, "width", "8");
		builder.AddAttribute(27, "height", "9");
		builder.CloseElement();
		builder.OpenElement(28, "g");
		builder.AddAttribute(29, "fill", "#1565C0");
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "x", "31");
		builder.AddAttribute(32, "y", "27");
		builder.AddAttribute(33, "width", "6");
		builder.AddAttribute(34, "height", "5");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "21");
		builder.AddAttribute(37, "y", "27");
		builder.AddAttribute(38, "width", "6");
		builder.AddAttribute(39, "height", "5");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "11");
		builder.AddAttribute(42, "y", "27");
		builder.AddAttribute(43, "width", "6");
		builder.AddAttribute(44, "height", "5");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "x", "31");
		builder.AddAttribute(47, "y", "35");
		builder.AddAttribute(48, "width", "6");
		builder.AddAttribute(49, "height", "5");
		builder.CloseElement();
		builder.OpenElement(50, "rect");
		builder.AddAttribute(51, "x", "11");
		builder.AddAttribute(52, "y", "35");
		builder.AddAttribute(53, "width", "6");
		builder.AddAttribute(54, "height", "5");
		builder.CloseElement();
		builder.OpenElement(55, "rect");
		builder.AddAttribute(56, "x", "31");
		builder.AddAttribute(57, "y", "19");
		builder.AddAttribute(58, "width", "6");
		builder.AddAttribute(59, "height", "5");
		builder.CloseElement();
		builder.OpenElement(60, "rect");
		builder.AddAttribute(61, "x", "21");
		builder.AddAttribute(62, "y", "19");
		builder.AddAttribute(63, "width", "6");
		builder.AddAttribute(64, "height", "5");
		builder.CloseElement();
		builder.OpenElement(65, "rect");
		builder.AddAttribute(66, "x", "11");
		builder.AddAttribute(67, "y", "19");
		builder.AddAttribute(68, "width", "6");
		builder.AddAttribute(69, "height", "5");
		builder.CloseElement();
		builder.OpenElement(70, "rect");
		builder.AddAttribute(71, "x", "31");
		builder.AddAttribute(72, "y", "11");
		builder.AddAttribute(73, "width", "6");
		builder.AddAttribute(74, "height", "5");
		builder.CloseElement();
		builder.OpenElement(75, "rect");
		builder.AddAttribute(76, "x", "21");
		builder.AddAttribute(77, "y", "11");
		builder.AddAttribute(78, "width", "6");
		builder.AddAttribute(79, "height", "5");
		builder.CloseElement();
		builder.OpenElement(80, "rect");
		builder.AddAttribute(81, "x", "11");
		builder.AddAttribute(82, "y", "11");
		builder.AddAttribute(83, "width", "6");
		builder.AddAttribute(84, "height", "5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
