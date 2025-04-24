// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBrasero : ComponentBase
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
		builder.AddAttribute(14, "d", "M246 17.85C229.7 66.3 146.1 103 208.9 165.2c-30.3 61-84.2-16.6-83.3-84.8-25 51.6-73.09 114.7-32.26 177.2 32.46 6.9 65.66 11.7 98.96 14.5 3.8-20.8-4.7-39.8-9.4-59.1 22.3 13 40.3 17.8 49.8 39 3.8-26.6-5.8-59.6 19.3-80-.6 24.6 8.1 47.9 20.6 49.4 34 4.1 33.9-49.8 50.2-75.3-6.8 45 26.3 95.4-9.6 127.4 38-2.5 74.6-7.8 108.7-15.9 30.1-28.1.3-70.1 19.1-105-22.8 22-27 37.1-63 34.9 20-46.2-5.9-104.2-66.3-142.09 0 0 8.7 35.02-3.8 39.23-28.7 9.72-59.2-32.04-61.9-66.79zm186.5 29.68c3.4 30.74 2 61.47-7.4 92.17 0 0 24.3-17.3 27.1-30.7 4.4-21.02-19.7-61.47-19.7-61.47zM74.77 271.8c1.06 3.8 2.61 7.7 4.61 11.5L64 460.1l16 8 45.8-137.3c4.7 3.3 9.7 6.5 14.8 9.7 28.2 17 61.1 29.6 88.1 35.3L240 494.1h32l11.3-118.3c27-5.7 59.9-18.3 88.1-35.3 5.1-3.2 10.1-6.4 14.8-9.7L432 468.1l16-8-15.4-176.8c1.9-3.7 3.4-7.3 4.5-10.9-108 27.9-241.1 27.6-362.33-.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
