// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiUluru : ComponentBase
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
		builder.AddAttribute(14, "d", "M416 64a32 32 0 0 0-32 32 32 32 0 0 0 32 32 32 32 0 0 0 32-32 32 32 0 0 0-32-32zM273.3 272.7l-64.5 15-44.2-7.9-116.98 25.1c-17.32 29.7-23.45 42.6-27.12 56.2h32.96c7.76-16.7 15.5-33.5 30.52-50.9l15.37-4.1c-12.15 18.2-24.3 36.2-29.52 55H126c4.5-22.7 22.4-44.5 36.3-66.7l16.2 1.2c-10.7 11.6-18.7 25.5-23.2 36l13-4.9c7.4-11.8 11.5-16.5 16.8-21.8l6.9 3.4c-10.1 11.4-9.9 17-14.6 29.8l7.1 8.1c8.5-19.2 23.7-34.7 36.7-51.3l12.2-3.7c-17.4 22.7-27.9 46.6-41.3 69.9h54.6c9.4-25.4 23.9-55.2 39.7-74.3l6.4 4.3c-8.6 16-14.4 31.7-20 47.4 35.7-25 53.3-28.3 76.7-38.5-11.1 20.3-21.7 40.8-25.7 61.1h87.3c-3.9-10.7-12.8-32.5-16.7-40.4l13.5-8.3c6.6 10.6 13.9 19.6 22.5 26.7l-13.8 22h73.2L466 312.4l-192.7-39.7zM18 381.1v17.8h476v-17.8H18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
