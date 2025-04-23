// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFaceRetouchingNatural : ComponentBase
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
		builder.AddAttribute(21, "d", "M10.66,4.12c2.55,4.23,7.03,3.87,7.18,3.86l-0.57-1.25L12.4,4.5l0.85-0.39C12.84,4.04,12.43,4,12,4 C11.54,4,11.09,4.05,10.66,4.12z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M8.08,5.03C6.37,6,5.05,7.58,4.42,9.47C6.13,8.5,7.45,6.92,8.08,5.03z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M19.89,10.75C19.96,11.16,20,11.57,20,12c0,4.41-3.59,8-8,8s-8-3.59-8-8c0-0.05,0.01-0.1,0-0.14 c2.6-0.98,4.69-2.99,5.74-5.55c3.38,4.14,7.97,3.73,8.99,3.61l-0.89-1.93c-0.13,0.01-4.62,0.38-7.18-3.86 c1.01-0.16,1.71-0.15,2.59-0.01l2.12-0.97l0.64-0.29C14.78,2.3,13.43,2,12,2C6.48,2,2,6.48,2,12s4.48,10,10,10s10-4.48,10-10 c0-1.43-0.3-2.78-0.84-4.01L19.89,10.75z M8.08,5.03C7.45,6.92,6.13,8.5,4.42,9.47C5.05,7.58,6.37,6,8.08,5.03z");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "9");
		builder.AddAttribute(30, "cy", "13");
		builder.AddAttribute(31, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "15");
		builder.AddAttribute(34, "cy", "13");
		builder.AddAttribute(35, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(36, "polygon");
		builder.AddAttribute(37, "points", "20.6,3.4 19.5,1 18.4,3.4 16,4.5 18.4,5.6 19.5,8 20.6,5.6 23,4.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
