// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFace5 : ComponentBase
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
		builder.AddAttribute(21, "d", "M12,2C6.48,2,2,6.48,2,12s4.48,10,10,10s10-4.48,10-10S17.52,2,12,2z M12,20c-4.41,0-8-3.59-8-8 c0-1.12,0.23-2.18,0.65-3.15C4.74,8.94,4.86,9,5,9c0.28,0,0.5-0.22,0.5-0.5c0-0.25-0.19-0.45-0.43-0.49 c0.15-0.26,0.32-0.51,0.49-0.75C5.53,7.34,5.5,7.41,5.5,7.5C5.5,7.78,5.72,8,6,8s0.5-0.22,0.5-0.5C6.5,7.22,6.28,7,6,7 C5.87,7,5.75,7.05,5.66,7.13c0.52-0.68,1.15-1.28,1.86-1.76C7.51,5.41,7.5,5.45,7.5,5.5C7.5,5.78,7.72,6,8,6s0.5-0.22,0.5-0.5 c0-0.24-0.17-0.43-0.4-0.48c0.16-0.09,0.32-0.17,0.49-0.25C8.68,4.91,8.83,5,9,5c0.28,0,0.5-0.22,0.5-0.5 c0-0.03-0.01-0.06-0.02-0.09c0.39-0.13,0.79-0.23,1.21-0.3C10.58,4.21,10.5,4.34,10.5,4.5C10.5,4.78,10.72,5,11,5 s0.5-0.22,0.5-0.5c0-0.21-0.13-0.38-0.3-0.46C11.46,4.01,11.73,4,12,4s0.54,0.01,0.8,0.04c-0.18,0.08-0.3,0.25-0.3,0.46 C12.5,4.78,12.72,5,13,5s0.5-0.22,0.5-0.5c0-0.16-0.08-0.29-0.19-0.38c0.41,0.07,0.82,0.17,1.21,0.3 C14.51,4.44,14.5,4.47,14.5,4.5C14.5,4.78,14.72,5,15,5c0.17,0,0.32-0.09,0.41-0.23c0.17,0.08,0.33,0.16,0.49,0.25 c-0.23,0.05-0.4,0.24-0.4,0.48C15.5,5.78,15.72,6,16,6s0.5-0.22,0.5-0.5c0-0.05-0.01-0.09-0.03-0.13 c0.71,0.48,1.34,1.08,1.86,1.76C18.25,7.05,18.13,7,18,7c-0.28,0-0.5,0.22-0.5,0.5C17.5,7.78,17.72,8,18,8s0.5-0.22,0.5-0.5 c0-0.09-0.03-0.16-0.07-0.23c0.18,0.24,0.34,0.49,0.49,0.75C18.69,8.05,18.5,8.25,18.5,8.5C18.5,8.78,18.72,9,19,9 c0.14,0,0.26-0.06,0.35-0.15C19.77,9.82,20,10.88,20,12C20,16.41,16.41,20,12,20z");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "9");
		builder.AddAttribute(24, "cy", "13");
		builder.AddAttribute(25, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "12");
		builder.AddAttribute(28, "cy", "5.5");
		builder.AddAttribute(29, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "14");
		builder.AddAttribute(32, "cy", "5.5");
		builder.AddAttribute(33, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "10");
		builder.AddAttribute(36, "cy", "5.5");
		builder.AddAttribute(37, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "17");
		builder.AddAttribute(40, "cy", "6.5");
		builder.AddAttribute(41, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "9");
		builder.AddAttribute(44, "cy", "6.5");
		builder.AddAttribute(45, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "7");
		builder.AddAttribute(48, "cy", "6.5");
		builder.AddAttribute(49, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(50, "circle");
		builder.AddAttribute(51, "cx", "11");
		builder.AddAttribute(52, "cy", "6.5");
		builder.AddAttribute(53, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(54, "circle");
		builder.AddAttribute(55, "cx", "13");
		builder.AddAttribute(56, "cy", "6.5");
		builder.AddAttribute(57, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(58, "circle");
		builder.AddAttribute(59, "cx", "15");
		builder.AddAttribute(60, "cy", "6.5");
		builder.AddAttribute(61, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(62, "circle");
		builder.AddAttribute(63, "cx", "12");
		builder.AddAttribute(64, "cy", "7.5");
		builder.AddAttribute(65, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(66, "circle");
		builder.AddAttribute(67, "cx", "14");
		builder.AddAttribute(68, "cy", "7.5");
		builder.AddAttribute(69, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(70, "circle");
		builder.AddAttribute(71, "cx", "16");
		builder.AddAttribute(72, "cy", "7.5");
		builder.AddAttribute(73, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(74, "circle");
		builder.AddAttribute(75, "cx", "10");
		builder.AddAttribute(76, "cy", "7.5");
		builder.AddAttribute(77, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(78, "circle");
		builder.AddAttribute(79, "cx", "8");
		builder.AddAttribute(80, "cy", "7.5");
		builder.AddAttribute(81, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(82, "circle");
		builder.AddAttribute(83, "cx", "9");
		builder.AddAttribute(84, "cy", "8.5");
		builder.AddAttribute(85, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(86, "circle");
		builder.AddAttribute(87, "cx", "7");
		builder.AddAttribute(88, "cy", "8.5");
		builder.AddAttribute(89, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(90, "circle");
		builder.AddAttribute(91, "cx", "11");
		builder.AddAttribute(92, "cy", "8.5");
		builder.AddAttribute(93, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(94, "circle");
		builder.AddAttribute(95, "cx", "13");
		builder.AddAttribute(96, "cy", "8.5");
		builder.AddAttribute(97, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(98, "circle");
		builder.AddAttribute(99, "cx", "15");
		builder.AddAttribute(100, "cy", "8.5");
		builder.AddAttribute(101, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(102, "circle");
		builder.AddAttribute(103, "cx", "17");
		builder.AddAttribute(104, "cy", "8.5");
		builder.AddAttribute(105, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(106, "circle");
		builder.AddAttribute(107, "cx", "15");
		builder.AddAttribute(108, "cy", "13");
		builder.AddAttribute(109, "r", "1.25");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
