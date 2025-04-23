// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdDeblur : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M12,3v18c4.97,0,9-4.03,9-9C21,7.03,16.97,3,12,3z");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "6");
		builder.AddAttribute(24, "cy", "14");
		builder.AddAttribute(25, "r", "1");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "6");
		builder.AddAttribute(28, "cy", "18");
		builder.AddAttribute(29, "r", "1");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "6");
		builder.AddAttribute(32, "cy", "10");
		builder.AddAttribute(33, "r", "1");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "3");
		builder.AddAttribute(36, "cy", "10");
		builder.AddAttribute(37, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "6");
		builder.AddAttribute(40, "cy", "6");
		builder.AddAttribute(41, "r", "1");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "3");
		builder.AddAttribute(44, "cy", "14");
		builder.AddAttribute(45, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "10");
		builder.AddAttribute(48, "cy", "21");
		builder.AddAttribute(49, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(50, "circle");
		builder.AddAttribute(51, "cx", "10");
		builder.AddAttribute(52, "cy", "3");
		builder.AddAttribute(53, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(54, "circle");
		builder.AddAttribute(55, "cx", "10");
		builder.AddAttribute(56, "cy", "6");
		builder.AddAttribute(57, "r", "1");
		builder.CloseElement();
		builder.OpenElement(58, "circle");
		builder.AddAttribute(59, "cx", "10");
		builder.AddAttribute(60, "cy", "14");
		builder.AddAttribute(61, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(62, "circle");
		builder.AddAttribute(63, "cx", "10");
		builder.AddAttribute(64, "cy", "10");
		builder.AddAttribute(65, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(66, "circle");
		builder.AddAttribute(67, "cx", "10");
		builder.AddAttribute(68, "cy", "18");
		builder.AddAttribute(69, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
