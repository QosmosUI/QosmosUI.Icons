// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMasks : ComponentBase
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
		builder.AddAttribute(18, "d", "M19.5,6c-1.31,0-2.37,1.01-2.48,2.3C15.14,7.8,14.18,6.5,12,6.5c-2.19,0-3.14,1.3-5.02,1.8C6.87,7.02,5.81,6,4.5,6 C3.12,6,2,7.12,2,8.5V9c0,6,3.6,7.81,6.52,7.98C9.53,17.62,10.72,18,12,18s2.47-0.38,3.48-1.02C18.4,16.81,22,15,22,9V8.5 C22,7.12,20.88,6,19.5,6z M3.5,9V8.5c0-0.55,0.45-1,1-1s1,0.45,1,1v3c0,1.28,0.38,2.47,1.01,3.48C4.99,14.27,3.5,12.65,3.5,9z M14.3,11.01c-0.4-0.17-0.72-0.36-1.01-0.53C12.83,10.2,12.49,10,12,10c-0.49,0-0.84,0.2-1.31,0.48c-0.28,0.17-0.6,0.35-0.98,0.51 C9.37,11.14,9,10.91,9,10.54v0c0-0.2,0.11-0.38,0.29-0.45c0.34-0.14,0.62-0.31,0.88-0.46C10.72,9.3,11.23,9,12,9s1.27,0.3,1.8,0.62 c0.27,0.16,0.55,0.33,0.9,0.48c0.18,0.08,0.29,0.26,0.29,0.45C15,10.91,14.63,11.15,14.3,11.01z M20.5,9c0,3.65-1.49,5.27-3.01,5.98 c0.64-1.01,1.01-2.2,1.01-3.48v-3c0-0.55,0.45-1,1-1s1,0.45,1,1V9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
