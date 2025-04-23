// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneKeyboardAlt : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M3,19h18V6H3V19z M17,8h2v2h-2V8z M17,12h2v2h-2V12z M13,8h2v2h-2V8z M13,12h2 v2h-2V12z M9,8h2v2H9V8z M9,12h2v2H9V12z M8,16h8v1H8V16z M5,8h2v2H5V8z M5,12h2v2H5V12z");
		builder.AddAttribute(23, "enable-background", "new");
		builder.AddAttribute(24, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M21,4H3C1.9,4,1,4.9,1,6v13c0,1.1,0.9,2,2,2h18c1.1,0,2-0.9,2-2V6C23,4.9,22.1,4,21,4z M21,19H3V6h18V19z");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "2");
		builder.AddAttribute(29, "width", "2");
		builder.AddAttribute(30, "x", "9");
		builder.AddAttribute(31, "y", "8");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "2");
		builder.AddAttribute(34, "width", "2");
		builder.AddAttribute(35, "x", "5");
		builder.AddAttribute(36, "y", "8");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "height", "1");
		builder.AddAttribute(39, "width", "8");
		builder.AddAttribute(40, "x", "8");
		builder.AddAttribute(41, "y", "16");
		builder.CloseElement();
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "height", "2");
		builder.AddAttribute(44, "width", "2");
		builder.AddAttribute(45, "x", "13");
		builder.AddAttribute(46, "y", "8");
		builder.CloseElement();
		builder.OpenElement(47, "rect");
		builder.AddAttribute(48, "height", "2");
		builder.AddAttribute(49, "width", "2");
		builder.AddAttribute(50, "x", "9");
		builder.AddAttribute(51, "y", "12");
		builder.CloseElement();
		builder.OpenElement(52, "rect");
		builder.AddAttribute(53, "height", "2");
		builder.AddAttribute(54, "width", "2");
		builder.AddAttribute(55, "x", "5");
		builder.AddAttribute(56, "y", "12");
		builder.CloseElement();
		builder.OpenElement(57, "rect");
		builder.AddAttribute(58, "height", "2");
		builder.AddAttribute(59, "width", "2");
		builder.AddAttribute(60, "x", "13");
		builder.AddAttribute(61, "y", "12");
		builder.CloseElement();
		builder.OpenElement(62, "rect");
		builder.AddAttribute(63, "height", "2");
		builder.AddAttribute(64, "width", "2");
		builder.AddAttribute(65, "x", "17");
		builder.AddAttribute(66, "y", "8");
		builder.CloseElement();
		builder.OpenElement(67, "rect");
		builder.AddAttribute(68, "height", "2");
		builder.AddAttribute(69, "width", "2");
		builder.AddAttribute(70, "x", "17");
		builder.AddAttribute(71, "y", "12");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
