// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxBorderBottom : ComponentBase
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
		builder.AddAttribute(16, "d", "M1 13.25L14 13.25V14.75L1 14.75V13.25Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "x", "7");
		builder.AddAttribute(20, "y", "5");
		builder.AddAttribute(21, "width", "1");
		builder.AddAttribute(22, "height", "1");
		builder.AddAttribute(23, "rx", ".5");
		builder.AddAttribute(24, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "13");
		builder.AddAttribute(27, "y", "5");
		builder.AddAttribute(28, "width", "1");
		builder.AddAttribute(29, "height", "1");
		builder.AddAttribute(30, "rx", ".5");
		builder.AddAttribute(31, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "7");
		builder.AddAttribute(34, "y", "3");
		builder.AddAttribute(35, "width", "1");
		builder.AddAttribute(36, "height", "1");
		builder.AddAttribute(37, "rx", ".5");
		builder.AddAttribute(38, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "13");
		builder.AddAttribute(41, "y", "3");
		builder.AddAttribute(42, "width", "1");
		builder.AddAttribute(43, "height", "1");
		builder.AddAttribute(44, "rx", ".5");
		builder.AddAttribute(45, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "x", "7");
		builder.AddAttribute(48, "y", "7");
		builder.AddAttribute(49, "width", "1");
		builder.AddAttribute(50, "height", "1");
		builder.AddAttribute(51, "rx", ".5");
		builder.AddAttribute(52, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(53, "rect");
		builder.AddAttribute(54, "x", "7");
		builder.AddAttribute(55, "y", "1");
		builder.AddAttribute(56, "width", "1");
		builder.AddAttribute(57, "height", "1");
		builder.AddAttribute(58, "rx", ".5");
		builder.AddAttribute(59, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(60, "rect");
		builder.AddAttribute(61, "x", "13");
		builder.AddAttribute(62, "y", "7");
		builder.AddAttribute(63, "width", "1");
		builder.AddAttribute(64, "height", "1");
		builder.AddAttribute(65, "rx", ".5");
		builder.AddAttribute(66, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(67, "rect");
		builder.AddAttribute(68, "x", "13");
		builder.AddAttribute(69, "y", "1");
		builder.AddAttribute(70, "width", "1");
		builder.AddAttribute(71, "height", "1");
		builder.AddAttribute(72, "rx", ".5");
		builder.AddAttribute(73, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(74, "rect");
		builder.AddAttribute(75, "x", "5");
		builder.AddAttribute(76, "y", "7");
		builder.AddAttribute(77, "width", "1");
		builder.AddAttribute(78, "height", "1");
		builder.AddAttribute(79, "rx", ".5");
		builder.AddAttribute(80, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(81, "rect");
		builder.AddAttribute(82, "x", "5");
		builder.AddAttribute(83, "y", "1");
		builder.AddAttribute(84, "width", "1");
		builder.AddAttribute(85, "height", "1");
		builder.AddAttribute(86, "rx", ".5");
		builder.AddAttribute(87, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(88, "rect");
		builder.AddAttribute(89, "x", "3");
		builder.AddAttribute(90, "y", "7");
		builder.AddAttribute(91, "width", "1");
		builder.AddAttribute(92, "height", "1");
		builder.AddAttribute(93, "rx", ".5");
		builder.AddAttribute(94, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(95, "rect");
		builder.AddAttribute(96, "x", "3");
		builder.AddAttribute(97, "y", "1");
		builder.AddAttribute(98, "width", "1");
		builder.AddAttribute(99, "height", "1");
		builder.AddAttribute(100, "rx", ".5");
		builder.AddAttribute(101, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(102, "rect");
		builder.AddAttribute(103, "x", "9");
		builder.AddAttribute(104, "y", "7");
		builder.AddAttribute(105, "width", "1");
		builder.AddAttribute(106, "height", "1");
		builder.AddAttribute(107, "rx", ".5");
		builder.AddAttribute(108, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(109, "rect");
		builder.AddAttribute(110, "x", "9");
		builder.AddAttribute(111, "y", "1");
		builder.AddAttribute(112, "width", "1");
		builder.AddAttribute(113, "height", "1");
		builder.AddAttribute(114, "rx", ".5");
		builder.AddAttribute(115, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(116, "rect");
		builder.AddAttribute(117, "x", "11");
		builder.AddAttribute(118, "y", "7");
		builder.AddAttribute(119, "width", "1");
		builder.AddAttribute(120, "height", "1");
		builder.AddAttribute(121, "rx", ".5");
		builder.AddAttribute(122, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(123, "rect");
		builder.AddAttribute(124, "x", "11");
		builder.AddAttribute(125, "y", "1");
		builder.AddAttribute(126, "width", "1");
		builder.AddAttribute(127, "height", "1");
		builder.AddAttribute(128, "rx", ".5");
		builder.AddAttribute(129, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(130, "rect");
		builder.AddAttribute(131, "x", "7");
		builder.AddAttribute(132, "y", "9");
		builder.AddAttribute(133, "width", "1");
		builder.AddAttribute(134, "height", "1");
		builder.AddAttribute(135, "rx", ".5");
		builder.AddAttribute(136, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(137, "rect");
		builder.AddAttribute(138, "x", "13");
		builder.AddAttribute(139, "y", "9");
		builder.AddAttribute(140, "width", "1");
		builder.AddAttribute(141, "height", "1");
		builder.AddAttribute(142, "rx", ".5");
		builder.AddAttribute(143, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(144, "rect");
		builder.AddAttribute(145, "x", "7");
		builder.AddAttribute(146, "y", "11");
		builder.AddAttribute(147, "width", "1");
		builder.AddAttribute(148, "height", "1");
		builder.AddAttribute(149, "rx", ".5");
		builder.AddAttribute(150, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(151, "rect");
		builder.AddAttribute(152, "x", "13");
		builder.AddAttribute(153, "y", "11");
		builder.AddAttribute(154, "width", "1");
		builder.AddAttribute(155, "height", "1");
		builder.AddAttribute(156, "rx", ".5");
		builder.AddAttribute(157, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(158, "rect");
		builder.AddAttribute(159, "x", "1");
		builder.AddAttribute(160, "y", "5");
		builder.AddAttribute(161, "width", "1");
		builder.AddAttribute(162, "height", "1");
		builder.AddAttribute(163, "rx", ".5");
		builder.AddAttribute(164, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(165, "rect");
		builder.AddAttribute(166, "x", "1");
		builder.AddAttribute(167, "y", "3");
		builder.AddAttribute(168, "width", "1");
		builder.AddAttribute(169, "height", "1");
		builder.AddAttribute(170, "rx", ".5");
		builder.AddAttribute(171, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(172, "rect");
		builder.AddAttribute(173, "x", "1");
		builder.AddAttribute(174, "y", "7");
		builder.AddAttribute(175, "width", "1");
		builder.AddAttribute(176, "height", "1");
		builder.AddAttribute(177, "rx", ".5");
		builder.AddAttribute(178, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(179, "rect");
		builder.AddAttribute(180, "x", "1");
		builder.AddAttribute(181, "y", "1");
		builder.AddAttribute(182, "width", "1");
		builder.AddAttribute(183, "height", "1");
		builder.AddAttribute(184, "rx", ".5");
		builder.AddAttribute(185, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(186, "rect");
		builder.AddAttribute(187, "x", "1");
		builder.AddAttribute(188, "y", "9");
		builder.AddAttribute(189, "width", "1");
		builder.AddAttribute(190, "height", "1");
		builder.AddAttribute(191, "rx", ".5");
		builder.AddAttribute(192, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(193, "rect");
		builder.AddAttribute(194, "x", "1");
		builder.AddAttribute(195, "y", "11");
		builder.AddAttribute(196, "width", "1");
		builder.AddAttribute(197, "height", "1");
		builder.AddAttribute(198, "rx", ".5");
		builder.AddAttribute(199, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
