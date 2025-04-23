// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoCalendarOutline : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-linejoin", "round");
		builder.AddAttribute(16, "stroke-width", "32");
		builder.AddAttribute(17, "x", "48");
		builder.AddAttribute(18, "y", "80");
		builder.AddAttribute(19, "width", "416");
		builder.AddAttribute(20, "height", "384");
		builder.AddAttribute(21, "rx", "48");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "296");
		builder.AddAttribute(24, "cy", "232");
		builder.AddAttribute(25, "r", "24");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "376");
		builder.AddAttribute(28, "cy", "232");
		builder.AddAttribute(29, "r", "24");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "296");
		builder.AddAttribute(32, "cy", "312");
		builder.AddAttribute(33, "r", "24");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "376");
		builder.AddAttribute(36, "cy", "312");
		builder.AddAttribute(37, "r", "24");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "136");
		builder.AddAttribute(40, "cy", "312");
		builder.AddAttribute(41, "r", "24");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "216");
		builder.AddAttribute(44, "cy", "312");
		builder.AddAttribute(45, "r", "24");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "136");
		builder.AddAttribute(48, "cy", "392");
		builder.AddAttribute(49, "r", "24");
		builder.CloseElement();
		builder.OpenElement(50, "circle");
		builder.AddAttribute(51, "cx", "216");
		builder.AddAttribute(52, "cy", "392");
		builder.AddAttribute(53, "r", "24");
		builder.CloseElement();
		builder.OpenElement(54, "circle");
		builder.AddAttribute(55, "cx", "296");
		builder.AddAttribute(56, "cy", "392");
		builder.AddAttribute(57, "r", "24");
		builder.CloseElement();
		builder.OpenElement(58, "line");
		builder.AddAttribute(59, "fill", "none");
		builder.AddAttribute(60, "stroke-linejoin", "round");
		builder.AddAttribute(61, "stroke-width", "32");
		builder.AddAttribute(62, "stroke-linecap", "round");
		builder.AddAttribute(63, "x1", "128");
		builder.AddAttribute(64, "y1", "48");
		builder.AddAttribute(65, "x2", "128");
		builder.AddAttribute(66, "y2", "80");
		builder.CloseElement();
		builder.OpenElement(67, "line");
		builder.AddAttribute(68, "fill", "none");
		builder.AddAttribute(69, "stroke-linejoin", "round");
		builder.AddAttribute(70, "stroke-width", "32");
		builder.AddAttribute(71, "stroke-linecap", "round");
		builder.AddAttribute(72, "x1", "384");
		builder.AddAttribute(73, "y1", "48");
		builder.AddAttribute(74, "x2", "384");
		builder.AddAttribute(75, "y2", "80");
		builder.CloseElement();
		builder.OpenElement(76, "line");
		builder.AddAttribute(77, "fill", "none");
		builder.AddAttribute(78, "stroke-linejoin", "round");
		builder.AddAttribute(79, "stroke-width", "32");
		builder.AddAttribute(80, "x1", "464");
		builder.AddAttribute(81, "y1", "160");
		builder.AddAttribute(82, "x2", "48");
		builder.AddAttribute(83, "y2", "160");
		builder.CloseElement();
		builder.CloseElement();
    }
}
