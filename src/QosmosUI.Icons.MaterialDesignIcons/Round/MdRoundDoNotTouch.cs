// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDoNotTouch : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M13,10.17l-2.5-2.5V2.25C10.5,1.56,11.06,1,11.75,1C12.44,1,13,1.56,13,2.25V10.17z M20,5.32c0-0.65-0.47-1.25-1.12-1.32 c-0.75-0.08-1.38,0.51-1.38,1.24v5.25c0,0.28-0.22,0.5-0.5,0.5h0c-0.28,0-0.5-0.22-0.5-0.5l0-7.18c0-0.65-0.47-1.25-1.12-1.32 C14.63,1.93,14,2.52,14,3.25v7.92l6,6L20,5.32z M9.5,4.25C9.5,3.56,8.94,3,8.25,3c-0.67,0-1.2,0.53-1.24,1.18L9.5,6.67V4.25z M17,22c0.62,0,1.18-0.19,1.65-0.52l-0.02-0.02l0.44,0.44c0.39,0.39,1.02,0.39,1.41,0l0,0c0.39-0.39,0.39-1.02,0-1.41L3.51,3.51 c-0.39-0.39-1.02-0.39-1.41,0l0,0c-0.39,0.39-0.39,1.02,0,1.41l4.92,4.92L7,9.83v4.3l-2.6-1.48c-0.17-0.09-0.34-0.14-0.54-0.14 c-0.26,0-0.5,0.09-0.7,0.26L2,13.88l0,0l6.8,7.18c0.57,0.6,1.35,0.94,2.18,0.94L17,22L17,22z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
