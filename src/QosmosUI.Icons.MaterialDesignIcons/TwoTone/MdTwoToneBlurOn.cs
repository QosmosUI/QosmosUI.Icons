// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneBlurOn : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "cx", "14");
		builder.AddAttribute(18, "cy", "10");
		builder.AddAttribute(19, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "14");
		builder.AddAttribute(22, "cy", "18");
		builder.AddAttribute(23, "r", "1");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "14");
		builder.AddAttribute(26, "cy", "14");
		builder.AddAttribute(27, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "14");
		builder.AddAttribute(30, "cy", "6");
		builder.AddAttribute(31, "r", "1");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M3 9.5c-.28 0-.5.22-.5.5s.22.5.5.5.5-.22.5-.5-.22-.5-.5-.5zM14.5 3c0-.28-.22-.5-.5-.5s-.5.22-.5.5.22.5.5.5.5-.22.5-.5zM21 14.5c.28 0 .5-.22.5-.5s-.22-.5-.5-.5-.5.22-.5.5.22.5.5.5z");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "18");
		builder.AddAttribute(36, "cy", "18");
		builder.AddAttribute(37, "r", "1");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M13.5 21c0 .28.22.5.5.5s.5-.22.5-.5-.22-.5-.5-.5-.5.22-.5.5zM21 10.5c.28 0 .5-.22.5-.5s-.22-.5-.5-.5-.5.22-.5.5.22.5.5.5z");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "18");
		builder.AddAttribute(42, "cy", "14");
		builder.AddAttribute(43, "r", "1");
		builder.CloseElement();
		builder.OpenElement(44, "circle");
		builder.AddAttribute(45, "cx", "18");
		builder.AddAttribute(46, "cy", "6");
		builder.AddAttribute(47, "r", "1");
		builder.CloseElement();
		builder.OpenElement(48, "circle");
		builder.AddAttribute(49, "cx", "6");
		builder.AddAttribute(50, "cy", "18");
		builder.AddAttribute(51, "r", "1");
		builder.CloseElement();
		builder.OpenElement(52, "circle");
		builder.AddAttribute(53, "cx", "6");
		builder.AddAttribute(54, "cy", "14");
		builder.AddAttribute(55, "r", "1");
		builder.CloseElement();
		builder.OpenElement(56, "path");
		builder.AddAttribute(57, "d", "M3.5 14c0-.28-.22-.5-.5-.5s-.5.22-.5.5.22.5.5.5.5-.22.5-.5z");
		builder.CloseElement();
		builder.OpenElement(58, "circle");
		builder.AddAttribute(59, "cx", "10");
		builder.AddAttribute(60, "cy", "6");
		builder.AddAttribute(61, "r", "1");
		builder.CloseElement();
		builder.OpenElement(62, "circle");
		builder.AddAttribute(63, "cx", "6");
		builder.AddAttribute(64, "cy", "10");
		builder.AddAttribute(65, "r", "1");
		builder.CloseElement();
		builder.OpenElement(66, "circle");
		builder.AddAttribute(67, "cx", "6");
		builder.AddAttribute(68, "cy", "6");
		builder.AddAttribute(69, "r", "1");
		builder.CloseElement();
		builder.OpenElement(70, "path");
		builder.AddAttribute(71, "d", "M9.5 21c0 .28.22.5.5.5s.5-.22.5-.5-.22-.5-.5-.5-.5.22-.5.5z");
		builder.CloseElement();
		builder.OpenElement(72, "circle");
		builder.AddAttribute(73, "cx", "10");
		builder.AddAttribute(74, "cy", "18");
		builder.AddAttribute(75, "r", "1");
		builder.CloseElement();
		builder.OpenElement(76, "path");
		builder.AddAttribute(77, "d", "M10.5 3c0-.28-.22-.5-.5-.5s-.5.22-.5.5.22.5.5.5.5-.22.5-.5z");
		builder.CloseElement();
		builder.OpenElement(78, "circle");
		builder.AddAttribute(79, "cx", "10");
		builder.AddAttribute(80, "cy", "14");
		builder.AddAttribute(81, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(82, "circle");
		builder.AddAttribute(83, "cx", "10");
		builder.AddAttribute(84, "cy", "10");
		builder.AddAttribute(85, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(86, "circle");
		builder.AddAttribute(87, "cx", "18");
		builder.AddAttribute(88, "cy", "10");
		builder.AddAttribute(89, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
