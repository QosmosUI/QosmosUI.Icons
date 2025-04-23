// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFace3 : ComponentBase
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
		builder.AddAttribute(21, "d", "M16.5,8c0.73,0,1.41-0.25,1.99-0.65C17.22,5.58,15.26,4.35,13,4.07V4.5C13,6.43,14.57,8,16.5,8z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M11,4.5V4.07C8.74,4.35,6.78,5.58,5.51,7.35C6.09,7.75,6.77,8,7.5,8C9.43,8,11,6.43,11,4.5z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M2.75,15.8L2.19,22H12C7.82,22,4.25,19.44,2.75,15.8z");
		builder.AddAttribute(28, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M12,22h9.81l-0.56-6.2C19.75,19.44,16.18,22,12,22z");
		builder.AddAttribute(31, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "9");
		builder.AddAttribute(34, "cy", "13");
		builder.AddAttribute(35, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(36, "circle");
		builder.AddAttribute(37, "cx", "15");
		builder.AddAttribute(38, "cy", "13");
		builder.AddAttribute(39, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M22.91,11.96C22.39,6.32,17.66,2,12,2S1.61,6.32,1.09,11.96l-0.9,9.86C0.09,22.99,1.01,24,2.19,24h19.62 c1.18,0,2.1-1.01,1.99-2.18L22.91,11.96z M13,4.07c2.26,0.28,4.22,1.51,5.49,3.28C17.91,7.75,17.23,8,16.5,8 C14.57,8,13,6.43,13,4.5V4.07z M11,4.07V4.5C11,6.43,9.43,8,7.5,8C6.77,8,6.09,7.75,5.51,7.35C6.78,5.58,8.74,4.35,11,4.07z M4.54,9.13C5.41,9.68,6.43,10,7.5,10C9.36,10,11,9.07,12,7.65C13,9.07,14.64,10,16.5,10c1.07,0,2.09-0.32,2.96-0.87 C19.8,10.02,20,10.99,20,12c0,4.41-3.59,8-8,8s-8-3.59-8-8C4,10.99,4.2,10.02,4.54,9.13z M12,22H2.19l0.56-6.2 C4.25,19.44,7.82,22,12,22s7.75-2.56,9.25-6.2l0.56,6.2H12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
