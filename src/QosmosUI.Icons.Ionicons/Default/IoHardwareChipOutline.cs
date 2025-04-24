// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoHardwareChipOutline : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "x", "80");
		builder.AddAttribute(15, "y", "80");
		builder.AddAttribute(16, "width", "352");
		builder.AddAttribute(17, "height", "352");
		builder.AddAttribute(18, "rx", "48");
		builder.AddAttribute(19, "ry", "48");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linejoin", "round");
		builder.AddAttribute(22, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "x", "144");
		builder.AddAttribute(25, "y", "144");
		builder.AddAttribute(26, "width", "224");
		builder.AddAttribute(27, "height", "224");
		builder.AddAttribute(28, "rx", "16");
		builder.AddAttribute(29, "ry", "16");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "line");
		builder.AddAttribute(34, "x1", "256");
		builder.AddAttribute(35, "y1", "80");
		builder.AddAttribute(36, "x2", "256");
		builder.AddAttribute(37, "y2", "48");
		builder.AddAttribute(38, "fill", "none");
		builder.AddAttribute(39, "stroke-linecap", "round");
		builder.AddAttribute(40, "stroke-linejoin", "round");
		builder.AddAttribute(41, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(42, "line");
		builder.AddAttribute(43, "x1", "336");
		builder.AddAttribute(44, "y1", "80");
		builder.AddAttribute(45, "x2", "336");
		builder.AddAttribute(46, "y2", "48");
		builder.AddAttribute(47, "fill", "none");
		builder.AddAttribute(48, "stroke-linecap", "round");
		builder.AddAttribute(49, "stroke-linejoin", "round");
		builder.AddAttribute(50, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(51, "line");
		builder.AddAttribute(52, "x1", "176");
		builder.AddAttribute(53, "y1", "80");
		builder.AddAttribute(54, "x2", "176");
		builder.AddAttribute(55, "y2", "48");
		builder.AddAttribute(56, "fill", "none");
		builder.AddAttribute(57, "stroke-linecap", "round");
		builder.AddAttribute(58, "stroke-linejoin", "round");
		builder.AddAttribute(59, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(60, "line");
		builder.AddAttribute(61, "x1", "256");
		builder.AddAttribute(62, "y1", "464");
		builder.AddAttribute(63, "x2", "256");
		builder.AddAttribute(64, "y2", "432");
		builder.AddAttribute(65, "fill", "none");
		builder.AddAttribute(66, "stroke-linecap", "round");
		builder.AddAttribute(67, "stroke-linejoin", "round");
		builder.AddAttribute(68, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(69, "line");
		builder.AddAttribute(70, "x1", "336");
		builder.AddAttribute(71, "y1", "464");
		builder.AddAttribute(72, "x2", "336");
		builder.AddAttribute(73, "y2", "432");
		builder.AddAttribute(74, "fill", "none");
		builder.AddAttribute(75, "stroke-linecap", "round");
		builder.AddAttribute(76, "stroke-linejoin", "round");
		builder.AddAttribute(77, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(78, "line");
		builder.AddAttribute(79, "x1", "176");
		builder.AddAttribute(80, "y1", "464");
		builder.AddAttribute(81, "x2", "176");
		builder.AddAttribute(82, "y2", "432");
		builder.AddAttribute(83, "fill", "none");
		builder.AddAttribute(84, "stroke-linecap", "round");
		builder.AddAttribute(85, "stroke-linejoin", "round");
		builder.AddAttribute(86, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(87, "line");
		builder.AddAttribute(88, "x1", "432");
		builder.AddAttribute(89, "y1", "256");
		builder.AddAttribute(90, "x2", "464");
		builder.AddAttribute(91, "y2", "256");
		builder.AddAttribute(92, "fill", "none");
		builder.AddAttribute(93, "stroke-linecap", "round");
		builder.AddAttribute(94, "stroke-linejoin", "round");
		builder.AddAttribute(95, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(96, "line");
		builder.AddAttribute(97, "x1", "432");
		builder.AddAttribute(98, "y1", "336");
		builder.AddAttribute(99, "x2", "464");
		builder.AddAttribute(100, "y2", "336");
		builder.AddAttribute(101, "fill", "none");
		builder.AddAttribute(102, "stroke-linecap", "round");
		builder.AddAttribute(103, "stroke-linejoin", "round");
		builder.AddAttribute(104, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(105, "line");
		builder.AddAttribute(106, "x1", "432");
		builder.AddAttribute(107, "y1", "176");
		builder.AddAttribute(108, "x2", "464");
		builder.AddAttribute(109, "y2", "176");
		builder.AddAttribute(110, "fill", "none");
		builder.AddAttribute(111, "stroke-linecap", "round");
		builder.AddAttribute(112, "stroke-linejoin", "round");
		builder.AddAttribute(113, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(114, "line");
		builder.AddAttribute(115, "x1", "48");
		builder.AddAttribute(116, "y1", "256");
		builder.AddAttribute(117, "x2", "80");
		builder.AddAttribute(118, "y2", "256");
		builder.AddAttribute(119, "fill", "none");
		builder.AddAttribute(120, "stroke-linecap", "round");
		builder.AddAttribute(121, "stroke-linejoin", "round");
		builder.AddAttribute(122, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(123, "line");
		builder.AddAttribute(124, "x1", "48");
		builder.AddAttribute(125, "y1", "336");
		builder.AddAttribute(126, "x2", "80");
		builder.AddAttribute(127, "y2", "336");
		builder.AddAttribute(128, "fill", "none");
		builder.AddAttribute(129, "stroke-linecap", "round");
		builder.AddAttribute(130, "stroke-linejoin", "round");
		builder.AddAttribute(131, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(132, "line");
		builder.AddAttribute(133, "x1", "48");
		builder.AddAttribute(134, "y1", "176");
		builder.AddAttribute(135, "x2", "80");
		builder.AddAttribute(136, "y2", "176");
		builder.AddAttribute(137, "fill", "none");
		builder.AddAttribute(138, "stroke-linecap", "round");
		builder.AddAttribute(139, "stroke-linejoin", "round");
		builder.AddAttribute(140, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
