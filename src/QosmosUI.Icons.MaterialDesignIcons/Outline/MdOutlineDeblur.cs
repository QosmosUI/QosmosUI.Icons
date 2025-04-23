// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineDeblur : ComponentBase
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
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "6");
		builder.AddAttribute(22, "cy", "14");
		builder.AddAttribute(23, "r", "1");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "6");
		builder.AddAttribute(26, "cy", "18");
		builder.AddAttribute(27, "r", "1");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "6");
		builder.AddAttribute(30, "cy", "10");
		builder.AddAttribute(31, "r", "1");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "3");
		builder.AddAttribute(34, "cy", "10");
		builder.AddAttribute(35, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(36, "circle");
		builder.AddAttribute(37, "cx", "6");
		builder.AddAttribute(38, "cy", "6");
		builder.AddAttribute(39, "r", "1");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "3");
		builder.AddAttribute(42, "cy", "14");
		builder.AddAttribute(43, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(44, "circle");
		builder.AddAttribute(45, "cx", "10");
		builder.AddAttribute(46, "cy", "21");
		builder.AddAttribute(47, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(48, "circle");
		builder.AddAttribute(49, "cx", "10");
		builder.AddAttribute(50, "cy", "3");
		builder.AddAttribute(51, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(52, "circle");
		builder.AddAttribute(53, "cx", "10");
		builder.AddAttribute(54, "cy", "6");
		builder.AddAttribute(55, "r", "1");
		builder.CloseElement();
		builder.OpenElement(56, "circle");
		builder.AddAttribute(57, "cx", "10");
		builder.AddAttribute(58, "cy", "14");
		builder.AddAttribute(59, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(60, "circle");
		builder.AddAttribute(61, "cx", "10");
		builder.AddAttribute(62, "cy", "10");
		builder.AddAttribute(63, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(64, "circle");
		builder.AddAttribute(65, "cx", "10");
		builder.AddAttribute(66, "cy", "18");
		builder.AddAttribute(67, "r", "1");
		builder.CloseElement();
		builder.OpenElement(68, "path");
		builder.AddAttribute(69, "d", "M12,3v2c3.86,0,7,3.14,7,7s-3.14,7-7,7v2c4.96,0,9-4.04,9-9S16.96,3,12,3z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
