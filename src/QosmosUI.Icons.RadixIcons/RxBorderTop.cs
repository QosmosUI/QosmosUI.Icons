// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxBorderTop : ComponentBase
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
		builder.AddAttribute(16, "d", "M14 1.75L1 1.75L1 0.249999L14 0.25L14 1.75Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "x", "8");
		builder.AddAttribute(20, "y", "10");
		builder.AddAttribute(21, "width", "1");
		builder.AddAttribute(22, "height", "1");
		builder.AddAttribute(23, "rx", ".5");
		builder.AddAttribute(24, "transform", "rotate(-180 8 10)");
		builder.AddAttribute(25, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "x", "2");
		builder.AddAttribute(28, "y", "10");
		builder.AddAttribute(29, "width", "1");
		builder.AddAttribute(30, "height", "1");
		builder.AddAttribute(31, "rx", ".5");
		builder.AddAttribute(32, "transform", "rotate(-180 2 10)");
		builder.AddAttribute(33, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "8");
		builder.AddAttribute(36, "y", "12");
		builder.AddAttribute(37, "width", "1");
		builder.AddAttribute(38, "height", "1");
		builder.AddAttribute(39, "rx", ".5");
		builder.AddAttribute(40, "transform", "rotate(-180 8 12)");
		builder.AddAttribute(41, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "x", "2");
		builder.AddAttribute(44, "y", "12");
		builder.AddAttribute(45, "width", "1");
		builder.AddAttribute(46, "height", "1");
		builder.AddAttribute(47, "rx", ".5");
		builder.AddAttribute(48, "transform", "rotate(-180 2 12)");
		builder.AddAttribute(49, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(50, "rect");
		builder.AddAttribute(51, "x", "8");
		builder.AddAttribute(52, "y", "8");
		builder.AddAttribute(53, "width", "1");
		builder.AddAttribute(54, "height", "1");
		builder.AddAttribute(55, "rx", ".5");
		builder.AddAttribute(56, "transform", "rotate(-180 8 8)");
		builder.AddAttribute(57, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(58, "rect");
		builder.AddAttribute(59, "x", "8");
		builder.AddAttribute(60, "y", "14");
		builder.AddAttribute(61, "width", "1");
		builder.AddAttribute(62, "height", "1");
		builder.AddAttribute(63, "rx", ".5");
		builder.AddAttribute(64, "transform", "rotate(-180 8 14)");
		builder.AddAttribute(65, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(66, "rect");
		builder.AddAttribute(67, "x", "2");
		builder.AddAttribute(68, "y", "8");
		builder.AddAttribute(69, "width", "1");
		builder.AddAttribute(70, "height", "1");
		builder.AddAttribute(71, "rx", ".5");
		builder.AddAttribute(72, "transform", "rotate(-180 2 8)");
		builder.AddAttribute(73, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(74, "rect");
		builder.AddAttribute(75, "x", "2");
		builder.AddAttribute(76, "y", "14");
		builder.AddAttribute(77, "width", "1");
		builder.AddAttribute(78, "height", "1");
		builder.AddAttribute(79, "rx", ".5");
		builder.AddAttribute(80, "transform", "rotate(-180 2 14)");
		builder.AddAttribute(81, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(82, "rect");
		builder.AddAttribute(83, "x", "10");
		builder.AddAttribute(84, "y", "8");
		builder.AddAttribute(85, "width", "1");
		builder.AddAttribute(86, "height", "1");
		builder.AddAttribute(87, "rx", ".5");
		builder.AddAttribute(88, "transform", "rotate(-180 10 8)");
		builder.AddAttribute(89, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(90, "rect");
		builder.AddAttribute(91, "x", "10");
		builder.AddAttribute(92, "y", "14");
		builder.AddAttribute(93, "width", "1");
		builder.AddAttribute(94, "height", "1");
		builder.AddAttribute(95, "rx", ".5");
		builder.AddAttribute(96, "transform", "rotate(-180 10 14)");
		builder.AddAttribute(97, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(98, "rect");
		builder.AddAttribute(99, "x", "12");
		builder.AddAttribute(100, "y", "8");
		builder.AddAttribute(101, "width", "1");
		builder.AddAttribute(102, "height", "1");
		builder.AddAttribute(103, "rx", ".5");
		builder.AddAttribute(104, "transform", "rotate(-180 12 8)");
		builder.AddAttribute(105, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(106, "rect");
		builder.AddAttribute(107, "x", "12");
		builder.AddAttribute(108, "y", "14");
		builder.AddAttribute(109, "width", "1");
		builder.AddAttribute(110, "height", "1");
		builder.AddAttribute(111, "rx", ".5");
		builder.AddAttribute(112, "transform", "rotate(-180 12 14)");
		builder.AddAttribute(113, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(114, "rect");
		builder.AddAttribute(115, "x", "6");
		builder.AddAttribute(116, "y", "8");
		builder.AddAttribute(117, "width", "1");
		builder.AddAttribute(118, "height", "1");
		builder.AddAttribute(119, "rx", ".5");
		builder.AddAttribute(120, "transform", "rotate(-180 6 8)");
		builder.AddAttribute(121, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(122, "rect");
		builder.AddAttribute(123, "x", "6");
		builder.AddAttribute(124, "y", "14");
		builder.AddAttribute(125, "width", "1");
		builder.AddAttribute(126, "height", "1");
		builder.AddAttribute(127, "rx", ".5");
		builder.AddAttribute(128, "transform", "rotate(-180 6 14)");
		builder.AddAttribute(129, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(130, "rect");
		builder.AddAttribute(131, "x", "4");
		builder.AddAttribute(132, "y", "8");
		builder.AddAttribute(133, "width", "1");
		builder.AddAttribute(134, "height", "1");
		builder.AddAttribute(135, "rx", ".5");
		builder.AddAttribute(136, "transform", "rotate(-180 4 8)");
		builder.AddAttribute(137, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(138, "rect");
		builder.AddAttribute(139, "x", "4");
		builder.AddAttribute(140, "y", "14");
		builder.AddAttribute(141, "width", "1");
		builder.AddAttribute(142, "height", "1");
		builder.AddAttribute(143, "rx", ".5");
		builder.AddAttribute(144, "transform", "rotate(-180 4 14)");
		builder.AddAttribute(145, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(146, "rect");
		builder.AddAttribute(147, "x", "8");
		builder.AddAttribute(148, "y", "6");
		builder.AddAttribute(149, "width", "1");
		builder.AddAttribute(150, "height", "1");
		builder.AddAttribute(151, "rx", ".5");
		builder.AddAttribute(152, "transform", "rotate(-180 8 6)");
		builder.AddAttribute(153, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(154, "rect");
		builder.AddAttribute(155, "x", "2");
		builder.AddAttribute(156, "y", "6");
		builder.AddAttribute(157, "width", "1");
		builder.AddAttribute(158, "height", "1");
		builder.AddAttribute(159, "rx", ".5");
		builder.AddAttribute(160, "transform", "rotate(-180 2 6)");
		builder.AddAttribute(161, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(162, "rect");
		builder.AddAttribute(163, "x", "8");
		builder.AddAttribute(164, "y", "4");
		builder.AddAttribute(165, "width", "1");
		builder.AddAttribute(166, "height", "1");
		builder.AddAttribute(167, "rx", ".5");
		builder.AddAttribute(168, "transform", "rotate(-180 8 4)");
		builder.AddAttribute(169, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(170, "rect");
		builder.AddAttribute(171, "x", "2");
		builder.AddAttribute(172, "y", "4");
		builder.AddAttribute(173, "width", "1");
		builder.AddAttribute(174, "height", "1");
		builder.AddAttribute(175, "rx", ".5");
		builder.AddAttribute(176, "transform", "rotate(-180 2 4)");
		builder.AddAttribute(177, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(178, "rect");
		builder.AddAttribute(179, "x", "14");
		builder.AddAttribute(180, "y", "10");
		builder.AddAttribute(181, "width", "1");
		builder.AddAttribute(182, "height", "1");
		builder.AddAttribute(183, "rx", ".5");
		builder.AddAttribute(184, "transform", "rotate(-180 14 10)");
		builder.AddAttribute(185, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(186, "rect");
		builder.AddAttribute(187, "x", "14");
		builder.AddAttribute(188, "y", "12");
		builder.AddAttribute(189, "width", "1");
		builder.AddAttribute(190, "height", "1");
		builder.AddAttribute(191, "rx", ".5");
		builder.AddAttribute(192, "transform", "rotate(-180 14 12)");
		builder.AddAttribute(193, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(194, "rect");
		builder.AddAttribute(195, "x", "14");
		builder.AddAttribute(196, "y", "8");
		builder.AddAttribute(197, "width", "1");
		builder.AddAttribute(198, "height", "1");
		builder.AddAttribute(199, "rx", ".5");
		builder.AddAttribute(200, "transform", "rotate(-180 14 8)");
		builder.AddAttribute(201, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(202, "rect");
		builder.AddAttribute(203, "x", "14");
		builder.AddAttribute(204, "y", "14");
		builder.AddAttribute(205, "width", "1");
		builder.AddAttribute(206, "height", "1");
		builder.AddAttribute(207, "rx", ".5");
		builder.AddAttribute(208, "transform", "rotate(-180 14 14)");
		builder.AddAttribute(209, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(210, "rect");
		builder.AddAttribute(211, "x", "14");
		builder.AddAttribute(212, "y", "6");
		builder.AddAttribute(213, "width", "1");
		builder.AddAttribute(214, "height", "1");
		builder.AddAttribute(215, "rx", ".5");
		builder.AddAttribute(216, "transform", "rotate(-180 14 6)");
		builder.AddAttribute(217, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(218, "rect");
		builder.AddAttribute(219, "x", "14");
		builder.AddAttribute(220, "y", "4");
		builder.AddAttribute(221, "width", "1");
		builder.AddAttribute(222, "height", "1");
		builder.AddAttribute(223, "rx", ".5");
		builder.AddAttribute(224, "transform", "rotate(-180 14 4)");
		builder.AddAttribute(225, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
