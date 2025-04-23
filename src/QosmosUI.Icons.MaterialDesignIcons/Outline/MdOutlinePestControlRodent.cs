// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlinePestControlRodent : ComponentBase
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
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "17");
		builder.AddAttribute(22, "cy", "17");
		builder.AddAttribute(23, "r", "1");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M20.86,14.97l-0.93-0.84c0.48-3.45-2.87-6.04-6.05-4.82C13.3,9.11,12.66,9,12,9c-4.26,0-5.65,3.58-5.89,4.85 C4.89,13.47,4,12.35,4,11c0-1.66,1.34-3,3-3h2.5C10.88,8,12,6.88,12,5.5C12,4.12,10.88,3,9.5,3H8C7.45,3,7,3.45,7,4 c0,0.55,0.45,1,1,1h1.5C9.78,5,10,5.22,10,5.5C10,5.78,9.78,6,9.5,6H7c-2.76,0-5,2.24-5,5c0,2.44,1.76,4.47,4.07,4.91 C6.51,18.79,8.99,21,12,21h6.53C21.64,21,23.23,17.11,20.86,14.97z M18.53,19H12c-1.21,0-2.34-0.54-3.11-1.48 c-0.78-0.95-1.06-2.16-0.8-3.41c0.31-1.48,1.51-2.69,2.99-3.01c0.22-0.05,0.45-0.06,0.67-0.07C11.28,11.74,11,12.58,11,13.5 c0,1.24,0.5,2.37,1.32,3.18l1.41-1.41C13.28,14.82,13,14.19,13,13.5c0-1.42,1.2-2.5,2.5-2.5c1.38,0,2.5,1.12,2.5,2.5 c0,0.46-0.13,0.88-0.35,1.25l1.87,1.7c0.31,0.28,0.48,0.67,0.48,1.09C20,18.34,19.34,19,18.53,19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
