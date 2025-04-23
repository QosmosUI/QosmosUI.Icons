// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSwipeVertical : ComponentBase
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
		builder.AddAttribute(20, "d", "M21.49,17.34L15.5,20l-4.92-1.96l4.18-0.88l-4.3-9.7c-0.11-0.25,0-0.55,0.25-0.66 c0.25-0.11,0.55,0,0.66,0.25l2.5,5.65l1.61-0.71L20.13,12L21.49,17.34z");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M1,2h3.5H6v1.5V7H4.5V4.09c-1.86,2.11-3,4.88-3,7.91s1.14,5.79,3,7.91V17H6v3.5V22H4.5H1v-1.5h2.02 C1.13,18.18,0,15.22,0,12s1.13-6.18,3.02-8.5H1V2z M20.22,10l-4.15,0.01c-0.16-0.01-0.31,0.02-0.45,0.08l-0.59,0.26L13.2,6.25 c-0.56-1.26-2.04-1.83-3.3-1.27s-1.83,2.04-1.27,3.3l3.3,7.45l-1.87,0.39c-0.19,0.05-0.99,0.27-1.36,1.21L8,19.19l6.78,2.67 c0.49,0.19,1.05,0.18,1.53-0.04l5.99-2.65c0.89-0.4,1.37-1.38,1.13-2.32l-1.36-5.34C21.85,10.65,21.1,10.04,20.22,10z M21.49,17.34 L15.5,20l-4.92-1.96l4.18-0.88l-4.3-9.7c-0.11-0.25,0-0.55,0.25-0.66c0.25-0.11,0.55,0,0.66,0.25l2.5,5.65l1.61-0.71L20.13,12 L21.49,17.34z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
