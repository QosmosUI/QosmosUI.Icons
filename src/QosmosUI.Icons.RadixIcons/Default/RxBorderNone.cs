// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxBorderNone : ComponentBase
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
		builder.AddAttribute(21, "x", "13");
		builder.AddAttribute(22, "y", "5.025");
		builder.AddAttribute(23, "width", "1");
		builder.AddAttribute(24, "height", "1");
		builder.AddAttribute(25, "rx", ".5");
		builder.AddAttribute(26, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "7");
		builder.AddAttribute(29, "y", "3.025");
		builder.AddAttribute(30, "width", "1");
		builder.AddAttribute(31, "height", "1");
		builder.AddAttribute(32, "rx", ".5");
		builder.AddAttribute(33, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "13");
		builder.AddAttribute(36, "y", "3.025");
		builder.AddAttribute(37, "width", "1");
		builder.AddAttribute(38, "height", "1");
		builder.AddAttribute(39, "rx", ".5");
		builder.AddAttribute(40, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "7");
		builder.AddAttribute(43, "y", "7.025");
		builder.AddAttribute(44, "width", "1");
		builder.AddAttribute(45, "height", "1");
		builder.AddAttribute(46, "rx", ".5");
		builder.AddAttribute(47, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(48, "rect");
		builder.AddAttribute(49, "x", "7");
		builder.AddAttribute(50, "y", "13.025");
		builder.AddAttribute(51, "width", "1");
		builder.AddAttribute(52, "height", "1");
		builder.AddAttribute(53, "rx", ".5");
		builder.AddAttribute(54, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(55, "rect");
		builder.AddAttribute(56, "x", "7");
		builder.AddAttribute(57, "y", "1.025");
		builder.AddAttribute(58, "width", "1");
		builder.AddAttribute(59, "height", "1");
		builder.AddAttribute(60, "rx", ".5");
		builder.AddAttribute(61, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(62, "rect");
		builder.AddAttribute(63, "x", "13");
		builder.AddAttribute(64, "y", "7.025");
		builder.AddAttribute(65, "width", "1");
		builder.AddAttribute(66, "height", "1");
		builder.AddAttribute(67, "rx", ".5");
		builder.AddAttribute(68, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(69, "rect");
		builder.AddAttribute(70, "x", "13");
		builder.AddAttribute(71, "y", "13.025");
		builder.AddAttribute(72, "width", "1");
		builder.AddAttribute(73, "height", "1");
		builder.AddAttribute(74, "rx", ".5");
		builder.AddAttribute(75, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(76, "rect");
		builder.AddAttribute(77, "x", "13");
		builder.AddAttribute(78, "y", "1.025");
		builder.AddAttribute(79, "width", "1");
		builder.AddAttribute(80, "height", "1");
		builder.AddAttribute(81, "rx", ".5");
		builder.AddAttribute(82, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(83, "rect");
		builder.AddAttribute(84, "x", "5");
		builder.AddAttribute(85, "y", "7.025");
		builder.AddAttribute(86, "width", "1");
		builder.AddAttribute(87, "height", "1");
		builder.AddAttribute(88, "rx", ".5");
		builder.AddAttribute(89, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(90, "rect");
		builder.AddAttribute(91, "x", "5");
		builder.AddAttribute(92, "y", "13.025");
		builder.AddAttribute(93, "width", "1");
		builder.AddAttribute(94, "height", "1");
		builder.AddAttribute(95, "rx", ".5");
		builder.AddAttribute(96, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(97, "rect");
		builder.AddAttribute(98, "x", "5");
		builder.AddAttribute(99, "y", "1.025");
		builder.AddAttribute(100, "width", "1");
		builder.AddAttribute(101, "height", "1");
		builder.AddAttribute(102, "rx", ".5");
		builder.AddAttribute(103, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(104, "rect");
		builder.AddAttribute(105, "x", "3");
		builder.AddAttribute(106, "y", "7.025");
		builder.AddAttribute(107, "width", "1");
		builder.AddAttribute(108, "height", "1");
		builder.AddAttribute(109, "rx", ".5");
		builder.AddAttribute(110, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(111, "rect");
		builder.AddAttribute(112, "x", "3");
		builder.AddAttribute(113, "y", "13.025");
		builder.AddAttribute(114, "width", "1");
		builder.AddAttribute(115, "height", "1");
		builder.AddAttribute(116, "rx", ".5");
		builder.AddAttribute(117, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(118, "rect");
		builder.AddAttribute(119, "x", "3");
		builder.AddAttribute(120, "y", "1.025");
		builder.AddAttribute(121, "width", "1");
		builder.AddAttribute(122, "height", "1");
		builder.AddAttribute(123, "rx", ".5");
		builder.AddAttribute(124, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(125, "rect");
		builder.AddAttribute(126, "x", "9");
		builder.AddAttribute(127, "y", "7.025");
		builder.AddAttribute(128, "width", "1");
		builder.AddAttribute(129, "height", "1");
		builder.AddAttribute(130, "rx", ".5");
		builder.AddAttribute(131, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(132, "rect");
		builder.AddAttribute(133, "x", "9");
		builder.AddAttribute(134, "y", "13.025");
		builder.AddAttribute(135, "width", "1");
		builder.AddAttribute(136, "height", "1");
		builder.AddAttribute(137, "rx", ".5");
		builder.AddAttribute(138, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(139, "rect");
		builder.AddAttribute(140, "x", "9");
		builder.AddAttribute(141, "y", "1.025");
		builder.AddAttribute(142, "width", "1");
		builder.AddAttribute(143, "height", "1");
		builder.AddAttribute(144, "rx", ".5");
		builder.AddAttribute(145, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(146, "rect");
		builder.AddAttribute(147, "x", "11");
		builder.AddAttribute(148, "y", "7.025");
		builder.AddAttribute(149, "width", "1");
		builder.AddAttribute(150, "height", "1");
		builder.AddAttribute(151, "rx", ".5");
		builder.AddAttribute(152, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(153, "rect");
		builder.AddAttribute(154, "x", "11");
		builder.AddAttribute(155, "y", "13.025");
		builder.AddAttribute(156, "width", "1");
		builder.AddAttribute(157, "height", "1");
		builder.AddAttribute(158, "rx", ".5");
		builder.AddAttribute(159, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(160, "rect");
		builder.AddAttribute(161, "x", "11");
		builder.AddAttribute(162, "y", "1.025");
		builder.AddAttribute(163, "width", "1");
		builder.AddAttribute(164, "height", "1");
		builder.AddAttribute(165, "rx", ".5");
		builder.AddAttribute(166, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(167, "rect");
		builder.AddAttribute(168, "x", "7");
		builder.AddAttribute(169, "y", "9.025");
		builder.AddAttribute(170, "width", "1");
		builder.AddAttribute(171, "height", "1");
		builder.AddAttribute(172, "rx", ".5");
		builder.AddAttribute(173, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(174, "rect");
		builder.AddAttribute(175, "x", "13");
		builder.AddAttribute(176, "y", "9.025");
		builder.AddAttribute(177, "width", "1");
		builder.AddAttribute(178, "height", "1");
		builder.AddAttribute(179, "rx", ".5");
		builder.AddAttribute(180, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(181, "rect");
		builder.AddAttribute(182, "x", "7");
		builder.AddAttribute(183, "y", "11.025");
		builder.AddAttribute(184, "width", "1");
		builder.AddAttribute(185, "height", "1");
		builder.AddAttribute(186, "rx", ".5");
		builder.AddAttribute(187, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(188, "rect");
		builder.AddAttribute(189, "x", "13");
		builder.AddAttribute(190, "y", "11.025");
		builder.AddAttribute(191, "width", "1");
		builder.AddAttribute(192, "height", "1");
		builder.AddAttribute(193, "rx", ".5");
		builder.AddAttribute(194, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(195, "rect");
		builder.AddAttribute(196, "x", "1");
		builder.AddAttribute(197, "y", "5.025");
		builder.AddAttribute(198, "width", "1");
		builder.AddAttribute(199, "height", "1");
		builder.AddAttribute(200, "rx", ".5");
		builder.AddAttribute(201, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(202, "rect");
		builder.AddAttribute(203, "x", "1");
		builder.AddAttribute(204, "y", "3.025");
		builder.AddAttribute(205, "width", "1");
		builder.AddAttribute(206, "height", "1");
		builder.AddAttribute(207, "rx", ".5");
		builder.AddAttribute(208, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(209, "rect");
		builder.AddAttribute(210, "x", "1");
		builder.AddAttribute(211, "y", "7.025");
		builder.AddAttribute(212, "width", "1");
		builder.AddAttribute(213, "height", "1");
		builder.AddAttribute(214, "rx", ".5");
		builder.AddAttribute(215, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(216, "rect");
		builder.AddAttribute(217, "x", "1");
		builder.AddAttribute(218, "y", "13.025");
		builder.AddAttribute(219, "width", "1");
		builder.AddAttribute(220, "height", "1");
		builder.AddAttribute(221, "rx", ".5");
		builder.AddAttribute(222, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(223, "rect");
		builder.AddAttribute(224, "x", "1");
		builder.AddAttribute(225, "y", "1.025");
		builder.AddAttribute(226, "width", "1");
		builder.AddAttribute(227, "height", "1");
		builder.AddAttribute(228, "rx", ".5");
		builder.AddAttribute(229, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(230, "rect");
		builder.AddAttribute(231, "x", "1");
		builder.AddAttribute(232, "y", "9.025");
		builder.AddAttribute(233, "width", "1");
		builder.AddAttribute(234, "height", "1");
		builder.AddAttribute(235, "rx", ".5");
		builder.AddAttribute(236, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(237, "rect");
		builder.AddAttribute(238, "x", "1");
		builder.AddAttribute(239, "y", "11.025");
		builder.AddAttribute(240, "width", "1");
		builder.AddAttribute(241, "height", "1");
		builder.AddAttribute(242, "rx", ".5");
		builder.AddAttribute(243, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
