// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSwipeLeft : ComponentBase
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
		builder.AddAttribute(20, "d", "M3.5,4.02V2.75C3.5,2.34,3.16,2,2.75,2S2,2.34,2,2.75V6c0,0.55,0.45,1,1,1h3.25C6.66,7,7,6.66,7,6.25S6.66,5.5,6.25,5.5 H4.09c2.11-1.86,4.88-3,7.91-3c4.42,0,7.27,2.19,8.25,4.1C20.37,6.85,20.63,7,20.91,7c0.56,0,0.93-0.59,0.67-1.08 C20.3,3.39,16.81,1,12,1C8.78,1,5.82,2.13,3.5,4.02z M5.2,17.43c0-0.65,0.6-1.13,1.24-0.99L10,17.24V6.5C10,5.67,10.67,5,11.5,5 S13,5.67,13,6.5v6h0.91c0.31,0,0.62,0.07,0.89,0.21l4.09,2.04c0.77,0.38,1.21,1.22,1.09,2.07l-0.63,4.46 C19.21,22.27,18.36,23,17.37,23h-6.16c-0.53,0-1.29-0.21-1.66-0.59l-4.07-4.29C5.3,17.94,5.2,17.69,5.2,17.43z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
