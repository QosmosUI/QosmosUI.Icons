// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneBathroom : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M4,20h16V4H4V20z M9,18c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S9.55,18,9,18z M9,15c-0.55,0-1-0.45-1-1 s0.45-1,1-1s1,0.45,1,1S9.55,15,9,15z M12,18c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S12.55,18,12,18z M12,15 c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S12.55,15,12,15z M15,18c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S15.55,18,15,18z M15,15c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S15.55,15,15,15z M7,11c0-2.76,2.24-5,5-5s5,2.24,5,5v1H7V11z");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "15");
		builder.AddAttribute(24, "cy", "14");
		builder.AddAttribute(25, "r", "1");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "12");
		builder.AddAttribute(28, "cy", "14");
		builder.AddAttribute(29, "r", "1");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "15");
		builder.AddAttribute(32, "cy", "17");
		builder.AddAttribute(33, "r", "1");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M20,2H4C2.9,2,2,2.9,2,4v16c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V4C22,2.9,21.1,2,20,2z M20,20H4V4h16V20z");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M17,11c0-2.76-2.24-5-5-5s-5,2.24-5,5v1h10V11z M8.54,10.5c0.24-1.69,1.7-3,3.46-3s3.22,1.31,3.47,3H8.54z");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "9");
		builder.AddAttribute(40, "cy", "17");
		builder.AddAttribute(41, "r", "1");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "9");
		builder.AddAttribute(44, "cy", "14");
		builder.AddAttribute(45, "r", "1");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "12");
		builder.AddAttribute(48, "cy", "17");
		builder.AddAttribute(49, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
