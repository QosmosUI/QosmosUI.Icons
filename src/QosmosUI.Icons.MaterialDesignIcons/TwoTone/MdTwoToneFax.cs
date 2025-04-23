// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFax : ComponentBase
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
		builder.AddAttribute(21, "d", "M5,10c-0.55,0-1,0.45-1,1v7c0,0.55,0.45,1,1,1s1-0.45,1-1v-7C6,10.45,5.55,10,5,10z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "height", "3");
		builder.AddAttribute(25, "opacity", ".3");
		builder.AddAttribute(26, "width", "6");
		builder.AddAttribute(27, "x", "10");
		builder.AddAttribute(28, "y", "6");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M19,11H8v7h12v-6C20,11.45,19.55,11,19,11z M13,17H9v-5h4V17z M15,17c-0.55,0-1-0.45-1-1s0.45-1,1-1 s1,0.45,1,1S15.55,17,15,17z M15,14c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S15.55,14,15,14z M18,17c-0.55,0-1-0.45-1-1 s0.45-1,1-1s1,0.45,1,1S18.55,17,18,17z M18,14c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S18.55,14,18,14z");
		builder.AddAttribute(31, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M19,9h-1V4H8v5H7.22C6.67,8.39,5.89,8,5,8c-1.66,0-3,1.34-3,3v7c0,1.66,1.34,3,3,3c0.89,0,1.67-0.39,2.22-1H22v-8 C22,10.34,20.66,9,19,9z M6,18c0,0.55-0.45,1-1,1s-1-0.45-1-1v-7c0-0.55,0.45-1,1-1s1,0.45,1,1V18z M10,6h6v3h-6V6z M20,18H8v-7 h11c0.55,0,1,0.45,1,1V18z");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "15");
		builder.AddAttribute(36, "cy", "13");
		builder.AddAttribute(37, "r", "1");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "18");
		builder.AddAttribute(40, "cy", "13");
		builder.AddAttribute(41, "r", "1");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "15");
		builder.AddAttribute(44, "cy", "16");
		builder.AddAttribute(45, "r", "1");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "18");
		builder.AddAttribute(48, "cy", "16");
		builder.AddAttribute(49, "r", "1");
		builder.CloseElement();
		builder.OpenElement(50, "g");
		builder.OpenElement(51, "rect");
		builder.AddAttribute(52, "height", "5");
		builder.AddAttribute(53, "width", "4");
		builder.AddAttribute(54, "x", "9");
		builder.AddAttribute(55, "y", "12");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
