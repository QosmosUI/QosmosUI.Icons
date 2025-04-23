// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneRememberMe : ComponentBase
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
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "height", "1");
		builder.AddAttribute(21, "opacity", ".3");
		builder.AddAttribute(22, "width", "10");
		builder.AddAttribute(23, "x", "7");
		builder.AddAttribute(24, "y", "20");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M7,17.52V18h10v-0.48C15.53,16.53,13.78,16,12,16S8.47,16.53,7,17.52z");
		builder.AddAttribute(27, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "12");
		builder.AddAttribute(30, "cy", "10");
		builder.AddAttribute(31, "opacity", ".3");
		builder.AddAttribute(32, "r", "1");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "height", "1");
		builder.AddAttribute(35, "opacity", ".3");
		builder.AddAttribute(36, "width", "10");
		builder.AddAttribute(37, "x", "7");
		builder.AddAttribute(38, "y", "3");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M17,1H7C5.9,1,5,1.9,5,3v18c0,1.1,0.9,2,2,2h10c1.1,0,2-0.9,2-2V3C19,1.9,18.1,1,17,1z M17,21H7v-1h10V21z M17,18H7v-0.48 C8.47,16.53,10.22,16,12,16s3.53,0.53,5,1.52V18z M17,15.21C15.5,14.44,13.8,14,12,14s-3.5,0.44-5,1.21V6h10V15.21z M17,4H7V3h10 V4z");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M12,13c1.66,0,3-1.34,3-3s-1.34-3-3-3s-3,1.34-3,3S10.34,13,12,13z M12,9c0.55,0,1,0.45,1,1s-0.45,1-1,1s-1-0.45-1-1 S11.45,9,12,9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
