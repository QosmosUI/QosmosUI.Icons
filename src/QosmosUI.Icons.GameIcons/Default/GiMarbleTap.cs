// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMarbleTap : ComponentBase
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
		builder.AddAttribute(14, "d", "M267.3 70.94C202.7 125.7 156 165.3 123.2 223.3l-15.6-8.8c3.4-6.1 7-12 10.7-17.7-21.47 1.2-42.56 3.5-58.36 7.6-20.2 11.6-31.89 29.1-42.36 49.6v213.9c63.72-19.4 125.92-44 181.32-53.9 19.7-8.5 39.7-14.7 55.6-24.6 14.4-18.6 21.6-43.1 24.7-61.8-1.9-.7-5.2-1.3-9.2-1.2-7.8.3-18 3.2-26.8 10.2-7.6 5.1-14.4 18.3-22.8 21.1-30.1 6.7-57.7 9.9-85 5-11.1-30.2-13.9-68 0-94.3 54.2-38.7 124.1-137.2 168.7-195.78-6.5-20.28-28.6-8.48-36.8-1.68zm-84.9-.4C142.2 106.4 120 141.1 90.22 180.9c13.38-1.5 27.38-2.4 41.08-2.8 25.2-28.7 44-52.8 66.9-84.54 0-11.53-6.2-19.04-15.8-23.02zm116.2 70.26L265 153.2c-8.9 11.5-17.9 22.7-27.1 34.1 4.6 1.6 9.4 3.1 13.3 4.5 19.9-9.4 39.4-19.5 59.3-28.8 6.7-2.3 9.9-9.9 8.8-15.2-3.1-9.1-13-8.2-20.7-7zm-72.9 61.3c-12.6 15.1-25.9 30.6-40.6 47 19.8 2.3 33.5.7 51.8-.9-.1 12.1-2.1 25.2-.7 36.3.8 6.3 2.9 11.7 8.1 19.3 8.6 4.8 17.9 3.8 26.7 1.2 2.1-15.4 4.6-31.9 4.6-46.9 0-16.8-3.1-31-11.3-40-2.4-2.5-9.5-6-19.2-9.4-5.8-2-12.5-4.2-19.4-6.6zM352 249c-17.2 0-31 13.8-31 31s13.8 31 31 31 31-13.8 31-31-13.8-31-31-31z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
