// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxBorderSplit : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(14, "x", "7");
		builder.AddAttribute(15, "y", "5.025");
		builder.AddAttribute(16, "width", "1");
		builder.AddAttribute(17, "height", "1");
		builder.AddAttribute(18, "rx", ".5");
		builder.AddAttribute(19, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "7");
		builder.AddAttribute(22, "y", "3.025");
		builder.AddAttribute(23, "width", "1");
		builder.AddAttribute(24, "height", "1");
		builder.AddAttribute(25, "rx", ".5");
		builder.AddAttribute(26, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "7");
		builder.AddAttribute(29, "y", "7.025");
		builder.AddAttribute(30, "width", "1");
		builder.AddAttribute(31, "height", "1");
		builder.AddAttribute(32, "rx", ".5");
		builder.AddAttribute(33, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "7");
		builder.AddAttribute(36, "y", "13.025");
		builder.AddAttribute(37, "width", "1");
		builder.AddAttribute(38, "height", "1");
		builder.AddAttribute(39, "rx", ".5");
		builder.AddAttribute(40, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "7");
		builder.AddAttribute(43, "y", "1.025");
		builder.AddAttribute(44, "width", "1");
		builder.AddAttribute(45, "height", "1");
		builder.AddAttribute(46, "rx", ".5");
		builder.AddAttribute(47, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(48, "rect");
		builder.AddAttribute(49, "x", "13");
		builder.AddAttribute(50, "y", "7.025");
		builder.AddAttribute(51, "width", "1");
		builder.AddAttribute(52, "height", "1");
		builder.AddAttribute(53, "rx", ".5");
		builder.AddAttribute(54, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(55, "rect");
		builder.AddAttribute(56, "x", "5");
		builder.AddAttribute(57, "y", "7.025");
		builder.AddAttribute(58, "width", "1");
		builder.AddAttribute(59, "height", "1");
		builder.AddAttribute(60, "rx", ".5");
		builder.AddAttribute(61, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(62, "rect");
		builder.AddAttribute(63, "x", "3");
		builder.AddAttribute(64, "y", "7.025");
		builder.AddAttribute(65, "width", "1");
		builder.AddAttribute(66, "height", "1");
		builder.AddAttribute(67, "rx", ".5");
		builder.AddAttribute(68, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(69, "rect");
		builder.AddAttribute(70, "x", "9");
		builder.AddAttribute(71, "y", "7.025");
		builder.AddAttribute(72, "width", "1");
		builder.AddAttribute(73, "height", "1");
		builder.AddAttribute(74, "rx", ".5");
		builder.AddAttribute(75, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(76, "rect");
		builder.AddAttribute(77, "x", "11");
		builder.AddAttribute(78, "y", "7.025");
		builder.AddAttribute(79, "width", "1");
		builder.AddAttribute(80, "height", "1");
		builder.AddAttribute(81, "rx", ".5");
		builder.AddAttribute(82, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(83, "rect");
		builder.AddAttribute(84, "x", "7");
		builder.AddAttribute(85, "y", "9.025");
		builder.AddAttribute(86, "width", "1");
		builder.AddAttribute(87, "height", "1");
		builder.AddAttribute(88, "rx", ".5");
		builder.AddAttribute(89, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(90, "rect");
		builder.AddAttribute(91, "x", "7");
		builder.AddAttribute(92, "y", "11.025");
		builder.AddAttribute(93, "width", "1");
		builder.AddAttribute(94, "height", "1");
		builder.AddAttribute(95, "rx", ".5");
		builder.AddAttribute(96, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(97, "rect");
		builder.AddAttribute(98, "x", "1");
		builder.AddAttribute(99, "y", "7.025");
		builder.AddAttribute(100, "width", "1");
		builder.AddAttribute(101, "height", "1");
		builder.AddAttribute(102, "rx", ".5");
		builder.AddAttribute(103, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(104, "path");
		builder.AddAttribute(105, "fill-rule", "evenodd");
		builder.AddAttribute(106, "clip-rule", "evenodd");
		builder.AddAttribute(107, "d", "M1 1.49994C1 1.2238 1.22386 0.999939 1.5 0.999939H6V1.99994H2V5.99994H1V1.49994ZM13 1.99994H9V0.999939H13.5C13.7761 0.999939 14 1.2238 14 1.49994V5.99994H13V1.99994ZM1 13.4999V8.99994H2V12.9999H6V13.9999H1.5C1.22386 13.9999 1 13.7761 1 13.4999ZM13 12.9999V8.99994H14V13.4999C14 13.7761 13.7761 13.9999 13.5 13.9999H9.5V12.9999H13Z");
		builder.AddAttribute(108, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
