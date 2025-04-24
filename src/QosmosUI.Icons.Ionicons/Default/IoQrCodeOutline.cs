// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoQrCodeOutline : ComponentBase
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
		builder.AddAttribute(14, "x", "336");
		builder.AddAttribute(15, "y", "336");
		builder.AddAttribute(16, "width", "80");
		builder.AddAttribute(17, "height", "80");
		builder.AddAttribute(18, "rx", "8");
		builder.AddAttribute(19, "ry", "8");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "272");
		builder.AddAttribute(22, "y", "272");
		builder.AddAttribute(23, "width", "64");
		builder.AddAttribute(24, "height", "64");
		builder.AddAttribute(25, "rx", "8");
		builder.AddAttribute(26, "ry", "8");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "416");
		builder.AddAttribute(29, "y", "416");
		builder.AddAttribute(30, "width", "64");
		builder.AddAttribute(31, "height", "64");
		builder.AddAttribute(32, "rx", "8");
		builder.AddAttribute(33, "ry", "8");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "432");
		builder.AddAttribute(36, "y", "272");
		builder.AddAttribute(37, "width", "48");
		builder.AddAttribute(38, "height", "48");
		builder.AddAttribute(39, "rx", "8");
		builder.AddAttribute(40, "ry", "8");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "272");
		builder.AddAttribute(43, "y", "432");
		builder.AddAttribute(44, "width", "48");
		builder.AddAttribute(45, "height", "48");
		builder.AddAttribute(46, "rx", "8");
		builder.AddAttribute(47, "ry", "8");
		builder.CloseElement();
		builder.OpenElement(48, "rect");
		builder.AddAttribute(49, "x", "336");
		builder.AddAttribute(50, "y", "96");
		builder.AddAttribute(51, "width", "80");
		builder.AddAttribute(52, "height", "80");
		builder.AddAttribute(53, "rx", "8");
		builder.AddAttribute(54, "ry", "8");
		builder.CloseElement();
		builder.OpenElement(55, "rect");
		builder.AddAttribute(56, "x", "288");
		builder.AddAttribute(57, "y", "48");
		builder.AddAttribute(58, "width", "176");
		builder.AddAttribute(59, "height", "176");
		builder.AddAttribute(60, "rx", "16");
		builder.AddAttribute(61, "ry", "16");
		builder.AddAttribute(62, "fill", "none");
		builder.AddAttribute(63, "stroke-linecap", "round");
		builder.AddAttribute(64, "stroke-linejoin", "round");
		builder.AddAttribute(65, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(66, "rect");
		builder.AddAttribute(67, "x", "96");
		builder.AddAttribute(68, "y", "96");
		builder.AddAttribute(69, "width", "80");
		builder.AddAttribute(70, "height", "80");
		builder.AddAttribute(71, "rx", "8");
		builder.AddAttribute(72, "ry", "8");
		builder.CloseElement();
		builder.OpenElement(73, "rect");
		builder.AddAttribute(74, "x", "48");
		builder.AddAttribute(75, "y", "48");
		builder.AddAttribute(76, "width", "176");
		builder.AddAttribute(77, "height", "176");
		builder.AddAttribute(78, "rx", "16");
		builder.AddAttribute(79, "ry", "16");
		builder.AddAttribute(80, "fill", "none");
		builder.AddAttribute(81, "stroke-linecap", "round");
		builder.AddAttribute(82, "stroke-linejoin", "round");
		builder.AddAttribute(83, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(84, "rect");
		builder.AddAttribute(85, "x", "96");
		builder.AddAttribute(86, "y", "336");
		builder.AddAttribute(87, "width", "80");
		builder.AddAttribute(88, "height", "80");
		builder.AddAttribute(89, "rx", "8");
		builder.AddAttribute(90, "ry", "8");
		builder.CloseElement();
		builder.OpenElement(91, "rect");
		builder.AddAttribute(92, "x", "48");
		builder.AddAttribute(93, "y", "288");
		builder.AddAttribute(94, "width", "176");
		builder.AddAttribute(95, "height", "176");
		builder.AddAttribute(96, "rx", "16");
		builder.AddAttribute(97, "ry", "16");
		builder.AddAttribute(98, "fill", "none");
		builder.AddAttribute(99, "stroke-linecap", "round");
		builder.AddAttribute(100, "stroke-linejoin", "round");
		builder.AddAttribute(101, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
