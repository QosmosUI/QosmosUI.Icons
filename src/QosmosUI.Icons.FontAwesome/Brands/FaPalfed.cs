// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaPalfed : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 576 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M384.9 193.9c0-47.4-55.2-44.2-95.4-29.8-1.3 39.4-2.5 80.7-3 119.8.7 2.8 2.6 6.2 15.1 6.2 36.8 0 83.4-42.8 83.3-96.2zm-194.5 72.2c.2 0 6.5-2.7 11.2-2.7 26.6 0 20.7 44.1-14.4 44.1-21.5 0-37.1-18.1-37.1-43 0-42 42.9-95.6 100.7-126.5 1-12.4 3-22 10.5-28.2 11.2-9 26.6-3.5 29.5 11.1 72.2-22.2 135.2 1 135.2 72 0 77.9-79.3 152.6-140.1 138.2-.1 39.4.9 74.4 2.7 100v.2c.2 3.4.6 12.5-5.3 19.1-9.6 10.6-33.4 10-36.4-22.3-4.1-44.4.2-206.1 1.4-242.5-21.5 15-58.5 50.3-58.5 75.9.2 2.5.4 4 .6 4.6zM8 181.1s-.1 37.4 38.4 37.4h30l22.4 217.2s0 44.3 44.7 44.3h288.9s44.7-.4 44.7-44.3l22.4-217.2h30s38.4 1.2 38.4-37.4c0 0 .1-37.4-38.4-37.4h-30.1c-7.3-25.6-30.2-74.3-119.4-74.3h-28V50.3s-2.7-18.4-21.1-18.4h-85.8s-21.1 0-21.1 18.4v19.1h-28.1s-105 4.2-120.5 74.3h-29S8 142.5 8 181.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
