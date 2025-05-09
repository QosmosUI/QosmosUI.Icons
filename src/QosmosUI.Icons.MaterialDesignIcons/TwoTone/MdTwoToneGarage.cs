// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneGarage : ComponentBase
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
		builder.AddAttribute(20, "d", "M17,11.51V11.5H7v0.01v2.99h10V11.51z M9,14c-0.55,0-1-0.45-1-1s0.45-1,1-1c0.55,0,1,0.45,1,1S9.55,14,9,14 z M15,14c-0.55,0-1-0.45-1-1s0.45-1,1-1c0.55,0,1,0.45,1,1S15.55,14,15,14z");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M4,20h16V4H4V20z M5,11.19C5.82,8.72,6.34,7.16,6.56,6.5c0.05-0.16,0.12-0.29,0.19-0.4 C6.77,6.08,6.78,6.06,6.8,6.04C7.18,5.51,7.72,5.5,7.72,5.5h8.56c0,0,0.54,0.01,0.92,0.53c0.02,0.03,0.03,0.05,0.05,0.07 c0.07,0.11,0.14,0.24,0.19,0.4c0.22,0.66,0.74,2.23,1.56,4.69v6.5c0,0.45-0.35,0.81-0.78,0.81h-0.44c-0.44,0-0.78-0.36-0.78-0.81 V16.5H7v1.19c0,0.45-0.35,0.81-0.78,0.81H5.78C5.35,18.5,5,18.14,5,17.69V11.19z");
		builder.AddAttribute(24, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M20,2H4C2.9,2,2,2.9,2,4v16c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V4C22,2.9,21.1,2,20,2z M20,20H4V4h16V20z");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "9");
		builder.AddAttribute(29, "cy", "13");
		builder.AddAttribute(30, "r", "1");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "15");
		builder.AddAttribute(33, "cy", "13");
		builder.AddAttribute(34, "r", "1");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M5.78,18.5h0.44C6.65,18.5,7,18.14,7,17.69V16.5h10v1.19c0,0.45,0.34,0.81,0.78,0.81h0.44c0.43,0,0.78-0.36,0.78-0.81 v-6.5c-0.82-2.46-1.34-4.03-1.56-4.69c-0.05-0.16-0.12-0.29-0.19-0.4c-0.02-0.02-0.03-0.04-0.05-0.07 c-0.38-0.52-0.92-0.53-0.92-0.53H7.72c0,0-0.54,0.01-0.92,0.54C6.78,6.06,6.77,6.08,6.75,6.1C6.68,6.21,6.61,6.34,6.56,6.5 C6.34,7.16,5.82,8.72,5,11.19v6.5C5,18.14,5.35,18.5,5.78,18.5z M8.33,7.5h7.34l0.23,0.69l0.43,1.31H7.67L8.33,7.5z M7,11.51V11.5 h10v0.01v2.99H7V11.51z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
