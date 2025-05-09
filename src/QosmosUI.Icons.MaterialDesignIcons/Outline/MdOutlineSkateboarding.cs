// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineSkateboarding : ComponentBase
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
		builder.AddAttribute(18, "d", "M13,3c0-1.1,0.9-2,2-2s2,0.9,2,2c0,1.1-0.9,2-2,2S13,4.1,13,3z M7.25,22.5c-0.41,0-0.75,0.34-0.75,0.75S6.84,24,7.25,24 S8,23.66,8,23.25S7.66,22.5,7.25,22.5z M15.75,22.5c-0.41,0-0.75,0.34-0.75,0.75S15.34,24,15.75,24s0.75-0.34,0.75-0.75 S16.16,22.5,15.75,22.5z M19.24,19c-0.24,0-0.45,0.11-0.59,0.3c-0.55,0.73-1.42,1.2-2.4,1.2H16v-6l-4.32-2.67l1.8-2.89 C14.63,10.78,16.68,12,19,12v-2c-1.85,0-3.44-1.12-4.13-2.72l-0.52-1.21C14.16,5.64,13.61,5,12.7,5H7L4.5,9l1.7,1.06L8.1,7h2.35 l-2.4,3.84c-0.31,0.5-0.39,1.11-0.21,1.67l1.34,4.15l-3.12,3.76c-0.7-0.16-1.3-0.57-1.71-1.12C4.21,19.11,3.99,19,3.75,19 C3.31,19,3,19.36,3,19.75c0,0.15,0.05,0.31,0.15,0.45c0.82,1.1,2.13,1.8,3.6,1.8h9.5c1.47,0,2.78-0.7,3.6-1.8 c0.1-0.14,0.15-0.3,0.15-0.45C20,19.36,19.68,19,19.24,19z M14,20.5H8.6l2.9-3.5l-1-3.3l3.5,2.2V20.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
