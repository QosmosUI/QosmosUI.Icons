// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoFilmOutline : ComponentBase
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
		builder.AddAttribute(14, "x", "48");
		builder.AddAttribute(15, "y", "96");
		builder.AddAttribute(16, "width", "416");
		builder.AddAttribute(17, "height", "320");
		builder.AddAttribute(18, "rx", "28");
		builder.AddAttribute(19, "ry", "28");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linejoin", "round");
		builder.AddAttribute(22, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "x", "384");
		builder.AddAttribute(25, "y", "336");
		builder.AddAttribute(26, "width", "80");
		builder.AddAttribute(27, "height", "80");
		builder.AddAttribute(28, "rx", "28");
		builder.AddAttribute(29, "ry", "28");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "x", "384");
		builder.AddAttribute(35, "y", "256");
		builder.AddAttribute(36, "width", "80");
		builder.AddAttribute(37, "height", "80");
		builder.AddAttribute(38, "rx", "28");
		builder.AddAttribute(39, "ry", "28");
		builder.AddAttribute(40, "fill", "none");
		builder.AddAttribute(41, "stroke-linejoin", "round");
		builder.AddAttribute(42, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "x", "384");
		builder.AddAttribute(45, "y", "176");
		builder.AddAttribute(46, "width", "80");
		builder.AddAttribute(47, "height", "80");
		builder.AddAttribute(48, "rx", "28");
		builder.AddAttribute(49, "ry", "28");
		builder.AddAttribute(50, "fill", "none");
		builder.AddAttribute(51, "stroke-linejoin", "round");
		builder.AddAttribute(52, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(53, "rect");
		builder.AddAttribute(54, "x", "384");
		builder.AddAttribute(55, "y", "96");
		builder.AddAttribute(56, "width", "80");
		builder.AddAttribute(57, "height", "80");
		builder.AddAttribute(58, "rx", "28");
		builder.AddAttribute(59, "ry", "28");
		builder.AddAttribute(60, "fill", "none");
		builder.AddAttribute(61, "stroke-linejoin", "round");
		builder.AddAttribute(62, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(63, "rect");
		builder.AddAttribute(64, "x", "48");
		builder.AddAttribute(65, "y", "336");
		builder.AddAttribute(66, "width", "80");
		builder.AddAttribute(67, "height", "80");
		builder.AddAttribute(68, "rx", "28");
		builder.AddAttribute(69, "ry", "28");
		builder.AddAttribute(70, "fill", "none");
		builder.AddAttribute(71, "stroke-linejoin", "round");
		builder.AddAttribute(72, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(73, "rect");
		builder.AddAttribute(74, "x", "48");
		builder.AddAttribute(75, "y", "256");
		builder.AddAttribute(76, "width", "80");
		builder.AddAttribute(77, "height", "80");
		builder.AddAttribute(78, "rx", "28");
		builder.AddAttribute(79, "ry", "28");
		builder.AddAttribute(80, "fill", "none");
		builder.AddAttribute(81, "stroke-linejoin", "round");
		builder.AddAttribute(82, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(83, "rect");
		builder.AddAttribute(84, "x", "48");
		builder.AddAttribute(85, "y", "176");
		builder.AddAttribute(86, "width", "80");
		builder.AddAttribute(87, "height", "80");
		builder.AddAttribute(88, "rx", "28");
		builder.AddAttribute(89, "ry", "28");
		builder.AddAttribute(90, "fill", "none");
		builder.AddAttribute(91, "stroke-linejoin", "round");
		builder.AddAttribute(92, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(93, "rect");
		builder.AddAttribute(94, "x", "48");
		builder.AddAttribute(95, "y", "96");
		builder.AddAttribute(96, "width", "80");
		builder.AddAttribute(97, "height", "80");
		builder.AddAttribute(98, "rx", "28");
		builder.AddAttribute(99, "ry", "28");
		builder.AddAttribute(100, "fill", "none");
		builder.AddAttribute(101, "stroke-linejoin", "round");
		builder.AddAttribute(102, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(103, "rect");
		builder.AddAttribute(104, "x", "128");
		builder.AddAttribute(105, "y", "96");
		builder.AddAttribute(106, "width", "256");
		builder.AddAttribute(107, "height", "160");
		builder.AddAttribute(108, "rx", "28");
		builder.AddAttribute(109, "ry", "28");
		builder.AddAttribute(110, "fill", "none");
		builder.AddAttribute(111, "stroke-linejoin", "round");
		builder.AddAttribute(112, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(113, "rect");
		builder.AddAttribute(114, "x", "128");
		builder.AddAttribute(115, "y", "256");
		builder.AddAttribute(116, "width", "256");
		builder.AddAttribute(117, "height", "160");
		builder.AddAttribute(118, "rx", "28");
		builder.AddAttribute(119, "ry", "28");
		builder.AddAttribute(120, "fill", "none");
		builder.AddAttribute(121, "stroke-linejoin", "round");
		builder.AddAttribute(122, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
