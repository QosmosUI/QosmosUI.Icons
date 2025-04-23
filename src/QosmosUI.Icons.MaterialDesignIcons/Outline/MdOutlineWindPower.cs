// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineWindPower : ComponentBase
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
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "height", "2");
		builder.AddAttribute(22, "width", "6");
		builder.AddAttribute(23, "x", "4");
		builder.AddAttribute(24, "y", "3");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "2");
		builder.AddAttribute(27, "width", "5");
		builder.AddAttribute(28, "x", "1");
		builder.AddAttribute(29, "y", "7");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "height", "2");
		builder.AddAttribute(32, "width", "5");
		builder.AddAttribute(33, "x", "3");
		builder.AddAttribute(34, "y", "19");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M22.21,18.61l-2.28-4.1c-0.27-0.48-0.73-0.83-1.26-0.97l-2.69-0.67c-0.02-0.47-0.14-0.92-0.37-1.33l3.96-6.59 c0.65-1.08,0.3-2.48-0.78-3.13c-0.36-0.22-0.77-0.32-1.17-0.32c-0.56,0-1.12,0.21-1.56,0.62l-3.43,3.21C12.23,5.7,12,6.23,12,6.78 v3.4c-0.47,0.17-0.89,0.45-1.23,0.82H3.28C2.02,11,1,12.02,1,13.28c0,1.02,0.67,1.91,1.65,2.19l4.51,1.29 c0.18,0.05,0.37,0.08,0.55,0.08c0.36,0,0.72-0.1,1.03-0.29l2.24-1.34c0.29,0.26,0.63,0.47,1.02,0.61V21c-1.1,0-2,0.9-2,2h6 c0-1.1-0.9-2-2-2v-4.28l4.61,4.61c0.45,0.45,1.03,0.67,1.61,0.67c0.58,0,1.17-0.22,1.61-0.67h0 C22.55,20.61,22.71,19.5,22.21,18.61z M7.72,14.84L3.2,13.55C3.08,13.52,3,13.4,3,13.28C3,13.13,3.13,13,3.28,13h6.73 c0,0.15,0.01,0.3,0.03,0.44L7.72,14.84z M13,14c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1C14,13.55,13.55,14,13,14z M14,10.14V6.78l3.43-3.21c0.05-0.05,0.19-0.12,0.34-0.04c0.13,0.08,0.18,0.25,0.1,0.38l-3.74,6.24L14,10.14z M20.42,19.92 c-0.05,0.05-0.24,0.16-0.4,0l-4.85-4.85c0.08-0.09,0.16-0.18,0.24-0.28l2.78,0.69l2.28,4.1C20.53,19.69,20.51,19.83,20.42,19.92z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
