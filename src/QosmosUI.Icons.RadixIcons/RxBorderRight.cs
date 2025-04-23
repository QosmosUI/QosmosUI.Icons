// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxBorderRight : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M13.25 1L13.25 14L14.75 14L14.75 1L13.25 1Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "width", "1");
		builder.AddAttribute(20, "height", "1");
		builder.AddAttribute(21, "rx", ".5");
		builder.AddAttribute(22, "transform", "matrix(0 1 1 0 5 7)");
		builder.AddAttribute(23, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "width", "1");
		builder.AddAttribute(26, "height", "1");
		builder.AddAttribute(27, "rx", ".5");
		builder.AddAttribute(28, "transform", "matrix(0 1 1 0 5 13)");
		builder.AddAttribute(29, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "width", "1");
		builder.AddAttribute(32, "height", "1");
		builder.AddAttribute(33, "rx", ".5");
		builder.AddAttribute(34, "transform", "matrix(0 1 1 0 3 7)");
		builder.AddAttribute(35, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "width", "1");
		builder.AddAttribute(38, "height", "1");
		builder.AddAttribute(39, "rx", ".5");
		builder.AddAttribute(40, "transform", "matrix(0 1 1 0 3 13)");
		builder.AddAttribute(41, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "width", "1");
		builder.AddAttribute(44, "height", "1");
		builder.AddAttribute(45, "rx", ".5");
		builder.AddAttribute(46, "transform", "matrix(0 1 1 0 7 7)");
		builder.AddAttribute(47, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(48, "rect");
		builder.AddAttribute(49, "width", "1");
		builder.AddAttribute(50, "height", "1");
		builder.AddAttribute(51, "rx", ".5");
		builder.AddAttribute(52, "transform", "matrix(0 1 1 0 1 7)");
		builder.AddAttribute(53, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(54, "rect");
		builder.AddAttribute(55, "width", "1");
		builder.AddAttribute(56, "height", "1");
		builder.AddAttribute(57, "rx", ".5");
		builder.AddAttribute(58, "transform", "matrix(0 1 1 0 7 13)");
		builder.AddAttribute(59, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(60, "rect");
		builder.AddAttribute(61, "width", "1");
		builder.AddAttribute(62, "height", "1");
		builder.AddAttribute(63, "rx", ".5");
		builder.AddAttribute(64, "transform", "matrix(0 1 1 0 1 13)");
		builder.AddAttribute(65, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(66, "rect");
		builder.AddAttribute(67, "width", "1");
		builder.AddAttribute(68, "height", "1");
		builder.AddAttribute(69, "rx", ".5");
		builder.AddAttribute(70, "transform", "matrix(0 1 1 0 7 5)");
		builder.AddAttribute(71, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(72, "rect");
		builder.AddAttribute(73, "width", "1");
		builder.AddAttribute(74, "height", "1");
		builder.AddAttribute(75, "rx", ".5");
		builder.AddAttribute(76, "transform", "matrix(0 1 1 0 1 5)");
		builder.AddAttribute(77, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(78, "rect");
		builder.AddAttribute(79, "width", "1");
		builder.AddAttribute(80, "height", "1");
		builder.AddAttribute(81, "rx", ".5");
		builder.AddAttribute(82, "transform", "matrix(0 1 1 0 7 3)");
		builder.AddAttribute(83, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(84, "rect");
		builder.AddAttribute(85, "width", "1");
		builder.AddAttribute(86, "height", "1");
		builder.AddAttribute(87, "rx", ".5");
		builder.AddAttribute(88, "transform", "matrix(0 1 1 0 1 3)");
		builder.AddAttribute(89, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(90, "rect");
		builder.AddAttribute(91, "width", "1");
		builder.AddAttribute(92, "height", "1");
		builder.AddAttribute(93, "rx", ".5");
		builder.AddAttribute(94, "transform", "matrix(0 1 1 0 7 9)");
		builder.AddAttribute(95, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(96, "rect");
		builder.AddAttribute(97, "width", "1");
		builder.AddAttribute(98, "height", "1");
		builder.AddAttribute(99, "rx", ".5");
		builder.AddAttribute(100, "transform", "matrix(0 1 1 0 1 9)");
		builder.AddAttribute(101, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(102, "rect");
		builder.AddAttribute(103, "width", "1");
		builder.AddAttribute(104, "height", "1");
		builder.AddAttribute(105, "rx", ".5");
		builder.AddAttribute(106, "transform", "matrix(0 1 1 0 7 11)");
		builder.AddAttribute(107, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(108, "rect");
		builder.AddAttribute(109, "width", "1");
		builder.AddAttribute(110, "height", "1");
		builder.AddAttribute(111, "rx", ".5");
		builder.AddAttribute(112, "transform", "matrix(0 1 1 0 1 11)");
		builder.AddAttribute(113, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(114, "rect");
		builder.AddAttribute(115, "width", "1");
		builder.AddAttribute(116, "height", "1");
		builder.AddAttribute(117, "rx", ".5");
		builder.AddAttribute(118, "transform", "matrix(0 1 1 0 9 7)");
		builder.AddAttribute(119, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(120, "rect");
		builder.AddAttribute(121, "width", "1");
		builder.AddAttribute(122, "height", "1");
		builder.AddAttribute(123, "rx", ".5");
		builder.AddAttribute(124, "transform", "matrix(0 1 1 0 9 13)");
		builder.AddAttribute(125, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(126, "rect");
		builder.AddAttribute(127, "width", "1");
		builder.AddAttribute(128, "height", "1");
		builder.AddAttribute(129, "rx", ".5");
		builder.AddAttribute(130, "transform", "matrix(0 1 1 0 11 7)");
		builder.AddAttribute(131, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(132, "rect");
		builder.AddAttribute(133, "width", "1");
		builder.AddAttribute(134, "height", "1");
		builder.AddAttribute(135, "rx", ".5");
		builder.AddAttribute(136, "transform", "matrix(0 1 1 0 11 13)");
		builder.AddAttribute(137, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(138, "rect");
		builder.AddAttribute(139, "width", "1");
		builder.AddAttribute(140, "height", "1");
		builder.AddAttribute(141, "rx", ".5");
		builder.AddAttribute(142, "transform", "matrix(0 1 1 0 5 1)");
		builder.AddAttribute(143, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(144, "rect");
		builder.AddAttribute(145, "width", "1");
		builder.AddAttribute(146, "height", "1");
		builder.AddAttribute(147, "rx", ".5");
		builder.AddAttribute(148, "transform", "matrix(0 1 1 0 3 1)");
		builder.AddAttribute(149, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(150, "rect");
		builder.AddAttribute(151, "width", "1");
		builder.AddAttribute(152, "height", "1");
		builder.AddAttribute(153, "rx", ".5");
		builder.AddAttribute(154, "transform", "matrix(0 1 1 0 7 1)");
		builder.AddAttribute(155, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(156, "rect");
		builder.AddAttribute(157, "width", "1");
		builder.AddAttribute(158, "height", "1");
		builder.AddAttribute(159, "rx", ".5");
		builder.AddAttribute(160, "transform", "matrix(0 1 1 0 1 1)");
		builder.AddAttribute(161, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(162, "rect");
		builder.AddAttribute(163, "width", "1");
		builder.AddAttribute(164, "height", "1");
		builder.AddAttribute(165, "rx", ".5");
		builder.AddAttribute(166, "transform", "matrix(0 1 1 0 9 1)");
		builder.AddAttribute(167, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(168, "rect");
		builder.AddAttribute(169, "width", "1");
		builder.AddAttribute(170, "height", "1");
		builder.AddAttribute(171, "rx", ".5");
		builder.AddAttribute(172, "transform", "matrix(0 1 1 0 11 1)");
		builder.AddAttribute(173, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
