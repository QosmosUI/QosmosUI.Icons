// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPaperBagCrumpled : ComponentBase
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
		builder.AddAttribute(14, "d", "m323 56-87 8 41 15-11 11 27 73-107 69 6 46v1l17-11-5-21 117-70 8-8-10-64 33-6 29-20 5-10h-21l-42-13zm-4 7 42 12-44 2 39 7-32 6h-41l11-13-28-9 53-5zm-94.1 7.63 41.9 79.47-69.4 52.2 80.7-48.4-27.6-63.85 11.4-7.92-37-11.5zm139.5 40.27-25.6 23.5 9.5 39.1-30.7 52.7 30.2 48.3-18.4-46.6 37-51.3-15.4-39.3 13.4-26.4zM327 188.6 222.3 252l3.6 20.1-74.1 52.8.8-19.5 21.7-17.6-2.4-22-59.1 63.1 21.1 47.9 96.4-20.6 63.8 35.7-68.6-20.8-104.9 20.8-17.8-51.2 9.3 65.4-9.5 21.7 46.5 8.4 56.9-16 66.1 35.7 47.7-51.6-19.4-72.6 45.2-36.2-52.5-74.5 33.9-32.4zm39.8 6.1-14.6 35.7 37.8 74-29.8 87.4 42.5 44.7 6.6-11.3-15.4-15 9.8-33.4v-74.7l-38.6-73.2 1.7-34.2zm2.2 108.5-41.3 33.6 10.8 54.1 30.5-87.7zm-21.7 105.6-55 47.2 28.2-.3 61.6-18.4-34.8-28.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
