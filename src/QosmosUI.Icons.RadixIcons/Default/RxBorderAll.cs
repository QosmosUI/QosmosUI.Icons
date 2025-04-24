// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxBorderAll : ComponentBase
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
		builder.AddAttribute(16, "d", "M0.25 1C0.25 0.585786 0.585786 0.25 1 0.25H14C14.4142 0.25 14.75 0.585786 14.75 1V14C14.75 14.4142 14.4142 14.75 14 14.75H1C0.585786 14.75 0.25 14.4142 0.25 14V1ZM1.75 1.75V13.25H13.25V1.75H1.75Z");
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
		builder.AddAttribute(26, "x", "7");
		builder.AddAttribute(27, "y", "3");
		builder.AddAttribute(28, "width", "1");
		builder.AddAttribute(29, "height", "1");
		builder.AddAttribute(30, "rx", ".5");
		builder.AddAttribute(31, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "7");
		builder.AddAttribute(34, "y", "7");
		builder.AddAttribute(35, "width", "1");
		builder.AddAttribute(36, "height", "1");
		builder.AddAttribute(37, "rx", ".5");
		builder.AddAttribute(38, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "5");
		builder.AddAttribute(41, "y", "7");
		builder.AddAttribute(42, "width", "1");
		builder.AddAttribute(43, "height", "1");
		builder.AddAttribute(44, "rx", ".5");
		builder.AddAttribute(45, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "x", "3");
		builder.AddAttribute(48, "y", "7");
		builder.AddAttribute(49, "width", "1");
		builder.AddAttribute(50, "height", "1");
		builder.AddAttribute(51, "rx", ".5");
		builder.AddAttribute(52, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(53, "rect");
		builder.AddAttribute(54, "x", "9");
		builder.AddAttribute(55, "y", "7");
		builder.AddAttribute(56, "width", "1");
		builder.AddAttribute(57, "height", "1");
		builder.AddAttribute(58, "rx", ".5");
		builder.AddAttribute(59, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(60, "rect");
		builder.AddAttribute(61, "x", "11");
		builder.AddAttribute(62, "y", "7");
		builder.AddAttribute(63, "width", "1");
		builder.AddAttribute(64, "height", "1");
		builder.AddAttribute(65, "rx", ".5");
		builder.AddAttribute(66, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(67, "rect");
		builder.AddAttribute(68, "x", "7");
		builder.AddAttribute(69, "y", "9");
		builder.AddAttribute(70, "width", "1");
		builder.AddAttribute(71, "height", "1");
		builder.AddAttribute(72, "rx", ".5");
		builder.AddAttribute(73, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(74, "rect");
		builder.AddAttribute(75, "x", "7");
		builder.AddAttribute(76, "y", "11");
		builder.AddAttribute(77, "width", "1");
		builder.AddAttribute(78, "height", "1");
		builder.AddAttribute(79, "rx", ".5");
		builder.AddAttribute(80, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
