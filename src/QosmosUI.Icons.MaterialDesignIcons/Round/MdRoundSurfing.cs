// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSurfing : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M17,1.5c-1.1,0-2,0.9-2,2s0.9,2,2,2s2-0.9,2-2S18.1,1.5,17,1.5z M22,22c0,0.55-0.45,1-1,1h0c-1.03,0-2.05-0.25-3-0.75 c-1.92,1.02-4.18,1-6.09-0.05c-1.79,0.87-3.92,0.98-5.58-0.14C5.3,22.69,4.15,23,3,23h0c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1h0 c0.87,0,1.73-0.24,2.53-0.7c0.29-0.16,0.65-0.17,0.94,0c1.59,0.9,3.48,0.9,5.06,0c0.29-0.16,0.65-0.16,0.94,0 c1.59,0.9,3.48,0.9,5.06,0c0.29-0.16,0.65-0.16,0.94,0C19.27,20.76,20.13,21,21,21h0C21.55,21,22,21.45,22,22z M8.04,18.86 C8.35,18.95,8.67,19,9,19c0.9,0,1.72-0.37,2.39-0.91c0.35-0.28,0.87-0.28,1.22,0C13.28,18.63,14.1,19,15,19s1.72-0.37,2.39-0.91 c0.03-0.03,0.07-0.05,0.11-0.07c-0.46-0.39-0.97-0.79-1.5-1.17v-2.87c0-0.61-0.28-1.19-0.77-1.57L12.17,10l2.25-1.52 c1.03,1.79,2.82,3.08,4.93,3.43c0.6,0.1,1.14-0.39,1.14-1c0-0.49-0.36-0.9-0.84-0.98c-1.5-0.25-2.78-1.18-3.51-2.46l-0.88-1.55 c-0.29-0.52-0.77-0.8-1.22-0.89L9.31,4.15c-0.52-0.1-1.06,0.02-1.5,0.32L5.82,5.83C5.37,6.15,5.25,6.77,5.56,7.22 C5.88,7.68,6.5,7.8,6.96,7.49l1.99-1.37l2,0.37L8.8,7.94C8.2,8.35,7.91,9.06,8.03,9.73l0.52,3.1C7.13,12.31,5.83,12,4.85,12 C4.01,12,3,12.25,3,13.28C3,14.72,5.19,16.9,8.04,18.86z M14,14v1.5c-0.78-0.48-2.34-1.33-3.26-1.75L10.3,11.1L14,14z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
