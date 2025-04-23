// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSnowboarding : ComponentBase
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
		builder.AddAttribute(18, "d", "M14,3c0-1.1,0.9-2,2-2s2,0.9,2,2c0,1.1-0.9,2-2,2S14,4.1,14,3z M21.4,20.09c-0.23-0.05-0.46,0.02-0.64,0.17 c-0.69,0.6-1.64,0.88-2.6,0.67L17,20.69l-1-6.19l-3.32-2.67l1.8-2.89C15.63,10.78,17.68,12,20,12v-2c-1.85,0-3.44-1.12-4.13-2.72 l-0.52-1.21C15.16,5.64,14.61,5,13.7,5H8L5.5,9l1.7,1.06L9.1,7h2.35l-2.51,3.99c-0.28,0.45-0.37,1-0.25,1.52L9.5,16L6,18.35 l-0.47-0.1c-0.96-0.2-1.71-0.85-2.1-1.67c-0.1-0.21-0.28-0.37-0.51-0.42c-0.43-0.09-0.82,0.2-0.9,0.58C1.98,16.88,2,17.05,2.07,17.2 c0.58,1.24,1.71,2.2,3.15,2.51l12.63,2.69c1.44,0.31,2.86-0.11,3.9-1.01c0.13-0.11,0.21-0.26,0.24-0.41 C22.06,20.6,21.83,20.18,21.4,20.09z M8.73,18.93l3.02-2.03l-0.44-3.32l2.84,2.02l0.75,4.64L8.73,18.93z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
