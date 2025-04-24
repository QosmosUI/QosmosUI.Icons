// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxDragHandleDots1 : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "4.5");
		builder.AddAttribute(15, "cy", "2.5");
		builder.AddAttribute(16, "r", ".6");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "4.5");
		builder.AddAttribute(20, "cy", "4.5");
		builder.AddAttribute(21, "r", ".6");
		builder.AddAttribute(22, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "4.5");
		builder.AddAttribute(25, "cy", "6.499");
		builder.AddAttribute(26, "r", ".6");
		builder.AddAttribute(27, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "4.5");
		builder.AddAttribute(30, "cy", "8.499");
		builder.AddAttribute(31, "r", ".6");
		builder.AddAttribute(32, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "cx", "4.5");
		builder.AddAttribute(35, "cy", "10.498");
		builder.AddAttribute(36, "r", ".6");
		builder.AddAttribute(37, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "4.5");
		builder.AddAttribute(40, "cy", "12.498");
		builder.AddAttribute(41, "r", ".6");
		builder.AddAttribute(42, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(43, "circle");
		builder.AddAttribute(44, "cx", "6.5");
		builder.AddAttribute(45, "cy", "2.5");
		builder.AddAttribute(46, "r", ".6");
		builder.AddAttribute(47, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(48, "circle");
		builder.AddAttribute(49, "cx", "6.5");
		builder.AddAttribute(50, "cy", "4.5");
		builder.AddAttribute(51, "r", ".6");
		builder.AddAttribute(52, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(53, "circle");
		builder.AddAttribute(54, "cx", "6.5");
		builder.AddAttribute(55, "cy", "6.499");
		builder.AddAttribute(56, "r", ".6");
		builder.AddAttribute(57, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(58, "circle");
		builder.AddAttribute(59, "cx", "6.5");
		builder.AddAttribute(60, "cy", "8.499");
		builder.AddAttribute(61, "r", ".6");
		builder.AddAttribute(62, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(63, "circle");
		builder.AddAttribute(64, "cx", "6.5");
		builder.AddAttribute(65, "cy", "10.498");
		builder.AddAttribute(66, "r", ".6");
		builder.AddAttribute(67, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(68, "circle");
		builder.AddAttribute(69, "cx", "6.5");
		builder.AddAttribute(70, "cy", "12.498");
		builder.AddAttribute(71, "r", ".6");
		builder.AddAttribute(72, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(73, "circle");
		builder.AddAttribute(74, "cx", "8.499");
		builder.AddAttribute(75, "cy", "2.5");
		builder.AddAttribute(76, "r", ".6");
		builder.AddAttribute(77, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(78, "circle");
		builder.AddAttribute(79, "cx", "8.499");
		builder.AddAttribute(80, "cy", "4.5");
		builder.AddAttribute(81, "r", ".6");
		builder.AddAttribute(82, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(83, "circle");
		builder.AddAttribute(84, "cx", "8.499");
		builder.AddAttribute(85, "cy", "6.499");
		builder.AddAttribute(86, "r", ".6");
		builder.AddAttribute(87, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(88, "circle");
		builder.AddAttribute(89, "cx", "8.499");
		builder.AddAttribute(90, "cy", "8.499");
		builder.AddAttribute(91, "r", ".6");
		builder.AddAttribute(92, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(93, "circle");
		builder.AddAttribute(94, "cx", "8.499");
		builder.AddAttribute(95, "cy", "10.498");
		builder.AddAttribute(96, "r", ".6");
		builder.AddAttribute(97, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(98, "circle");
		builder.AddAttribute(99, "cx", "8.499");
		builder.AddAttribute(100, "cy", "12.498");
		builder.AddAttribute(101, "r", ".6");
		builder.AddAttribute(102, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(103, "circle");
		builder.AddAttribute(104, "cx", "10.499");
		builder.AddAttribute(105, "cy", "2.5");
		builder.AddAttribute(106, "r", ".6");
		builder.AddAttribute(107, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(108, "circle");
		builder.AddAttribute(109, "cx", "10.499");
		builder.AddAttribute(110, "cy", "4.5");
		builder.AddAttribute(111, "r", ".6");
		builder.AddAttribute(112, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(113, "circle");
		builder.AddAttribute(114, "cx", "10.499");
		builder.AddAttribute(115, "cy", "6.499");
		builder.AddAttribute(116, "r", ".6");
		builder.AddAttribute(117, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(118, "circle");
		builder.AddAttribute(119, "cx", "10.499");
		builder.AddAttribute(120, "cy", "8.499");
		builder.AddAttribute(121, "r", ".6");
		builder.AddAttribute(122, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(123, "circle");
		builder.AddAttribute(124, "cx", "10.499");
		builder.AddAttribute(125, "cy", "10.498");
		builder.AddAttribute(126, "r", ".6");
		builder.AddAttribute(127, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(128, "circle");
		builder.AddAttribute(129, "cx", "10.499");
		builder.AddAttribute(130, "cy", "12.498");
		builder.AddAttribute(131, "r", ".6");
		builder.AddAttribute(132, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
