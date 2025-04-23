// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCurrencyPound : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M17.21,17.61c-0.47-0.24-1.03-0.05-1.31,0.4C15.54,18.61,14.93,19,14,19l-4.9,0c0.83-1,1.5-2.34,1.5-4 c0-0.35-0.03-0.69-0.08-1L13,14c0.55,0,1-0.45,1-1s-0.45-1-1-1l-3.18,0C9,10.42,8,9.6,8,8c0-1.93,1.57-3.5,3.5-3.5 c1.2,0,2.26,0.61,2.89,1.53c0.27,0.4,0.77,0.59,1.22,0.4c0.6-0.25,0.8-0.99,0.43-1.53c-0.99-1.45-2.66-2.4-4.54-2.4 C8.46,2.5,6,4.96,6,8c0,1.78,0.79,2.9,1.49,4L7,12c-0.55,0-1,0.45-1,1s0.45,1,1,1l1.47,0c0.08,0.31,0.13,0.64,0.13,1 c0,1.9-1.29,3.11-2.06,3.66C6.2,18.9,6,19.29,6,19.71v0C6,20.42,6.58,21,7.29,21H14c1.55,0,2.95-0.76,3.63-2 C17.91,18.49,17.72,17.86,17.21,17.61z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
