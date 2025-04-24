// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcLibrary : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#FF9800");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "1");
		builder.AddAttribute(17, "y", "38");
		builder.AddAttribute(18, "width", "46");
		builder.AddAttribute(19, "height", "2");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "25");
		builder.AddAttribute(22, "y", "18");
		builder.AddAttribute(23, "width", "4");
		builder.AddAttribute(24, "height", "16");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "31");
		builder.AddAttribute(27, "y", "18");
		builder.AddAttribute(28, "width", "4");
		builder.AddAttribute(29, "height", "16");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "x", "37");
		builder.AddAttribute(32, "y", "18");
		builder.AddAttribute(33, "width", "4");
		builder.AddAttribute(34, "height", "16");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "19");
		builder.AddAttribute(37, "y", "18");
		builder.AddAttribute(38, "width", "4");
		builder.AddAttribute(39, "height", "16");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "13");
		builder.AddAttribute(42, "y", "18");
		builder.AddAttribute(43, "width", "4");
		builder.AddAttribute(44, "height", "16");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "x", "7");
		builder.AddAttribute(47, "y", "18");
		builder.AddAttribute(48, "width", "4");
		builder.AddAttribute(49, "height", "16");
		builder.CloseElement();
		builder.OpenElement(50, "polygon");
		builder.AddAttribute(51, "points", "43,16 5,16 5,13 24,4 43,13");
		builder.CloseElement();
		builder.OpenElement(52, "rect");
		builder.AddAttribute(53, "x", "5");
		builder.AddAttribute(54, "y", "34");
		builder.AddAttribute(55, "width", "38");
		builder.AddAttribute(56, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(57, "g");
		builder.AddAttribute(58, "fill", "#EF6C00");
		builder.OpenElement(59, "rect");
		builder.AddAttribute(60, "x", "25");
		builder.AddAttribute(61, "y", "16");
		builder.AddAttribute(62, "width", "4");
		builder.AddAttribute(63, "height", "2");
		builder.CloseElement();
		builder.OpenElement(64, "rect");
		builder.AddAttribute(65, "x", "31");
		builder.AddAttribute(66, "y", "16");
		builder.AddAttribute(67, "width", "4");
		builder.AddAttribute(68, "height", "2");
		builder.CloseElement();
		builder.OpenElement(69, "rect");
		builder.AddAttribute(70, "x", "37");
		builder.AddAttribute(71, "y", "16");
		builder.AddAttribute(72, "width", "4");
		builder.AddAttribute(73, "height", "2");
		builder.CloseElement();
		builder.OpenElement(74, "rect");
		builder.AddAttribute(75, "x", "19");
		builder.AddAttribute(76, "y", "16");
		builder.AddAttribute(77, "width", "4");
		builder.AddAttribute(78, "height", "2");
		builder.CloseElement();
		builder.OpenElement(79, "rect");
		builder.AddAttribute(80, "x", "13");
		builder.AddAttribute(81, "y", "16");
		builder.AddAttribute(82, "width", "4");
		builder.AddAttribute(83, "height", "2");
		builder.CloseElement();
		builder.OpenElement(84, "rect");
		builder.AddAttribute(85, "x", "7");
		builder.AddAttribute(86, "y", "16");
		builder.AddAttribute(87, "width", "4");
		builder.AddAttribute(88, "height", "2");
		builder.CloseElement();
		builder.OpenElement(89, "rect");
		builder.AddAttribute(90, "x", "3");
		builder.AddAttribute(91, "y", "36");
		builder.AddAttribute(92, "width", "42");
		builder.AddAttribute(93, "height", "2");
		builder.CloseElement();
		builder.OpenElement(94, "circle");
		builder.AddAttribute(95, "cx", "24");
		builder.AddAttribute(96, "cy", "11");
		builder.AddAttribute(97, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
