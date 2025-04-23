// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiUndergroundCave : ComponentBase
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
		builder.AddAttribute(14, "d", "M25 25v94.1c29.99.1 62.76-.7 90.3 21.3l2.6 2 24.7 122.3 31.7-151.4 11 7.2c23.2 15.1 41.4 9.7 58.8-.3l11.4-6.6 15.8 103.9 19.5-92.2 17.6-.2 17.8 74.9 12.7-112.32 13.6 19.92c8.3 12.1 14.5 21.1 20.6 26.7 5.4 5 10.6 7.7 18.9 8.7 13.4-8.4 27.8-20.7 44.4-30.1 14.6-8.4 31.7-14.23 50.6-11.9V25H25zm417.6 338.7c-12 10.6-25.5 26.2-39.7 41.6-16.5 17.8-33.7 35.2-53.9 42.3l-3.2 1.1-3.2-1.3c-32.5-13.1-72.9-11.6-115.6-6.5l-2.5.3-2.3-1c-26.1-11.8-42.9-23-75.3-34.2-7 12.3-16.4 23.4-27.2 30.8-6.4 4.4-13.4 7.6-20.86 8.5-7.47 1-15.51-.7-22.15-5.5-10.43-7.5-20.87-18-31.23-25.6-7.49-5.4-14.3-8.8-20.46-9.7V487h462v-37.2c-5.1-12.7-12.2-31.1-20.8-48.7-7.2-14.9-15.8-28.8-23.6-37.4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
