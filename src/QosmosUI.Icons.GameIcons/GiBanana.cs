// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBanana : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M390 28.11c0 6.53-.1 12.92-.4 19.21 1.4-.1 2.7-.14 3.9-.16 9.7-.17 18.4 1.19 26.7 3 1.5-5.66 3.5-11.65 6.2-18.06-12.7.76-24.8-.73-36.4-3.99zm4 37.02c-1.7 0-3.5.15-5.4.32-5.4 72.95-26.6 128.45-56.7 171.25-36.5 52-85.5 85.2-132.7 109.6-47.1 24.6-92.7 40.7-122.34 57.8-14.79 8.6-25.29 17.4-30.55 26.3-3.3 5.6-4.98 11.3-4.54 18.3l23.93 8.1c61-12.1 145.2-42.8 215.1-89.1 40.7-26.9 76.6-59 100.5-95.2 23.9-36.3 36.1-76.4 30.2-120.8l17.9-2.3c6.4 49-7.4 93.9-33.1 133-25.8 39-63.4 72.5-105.6 100.4-70.4 46.6-153.4 77.6-216.72 90.8l-5.85 11c4.4 1.9 9.38 3.4 14.96 4.6 20.81 4.4 49.01 3.6 80.31-2.9 62.8-12.8 138.1-47.4 197.2-101 54-48.8 92.3-105.8 104.9-157 12.7-51.3 1.3-95.7-45.2-126.5l-3.9-2.51-.2-4.51c-.4-8.19-.6-17.02.5-26.95-7.4-1.67-14.8-2.84-22.7-2.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
