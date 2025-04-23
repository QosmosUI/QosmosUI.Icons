// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaGoodreadsG : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 384 512";

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
		builder.AddAttribute(14, "d", "M42.6 403.3h2.8c12.7 0 25.5 0 38.2.1 1.6 0 3.1-.4 3.6 2.1 7.1 34.9 30 54.6 62.9 63.9 26.9 7.6 54.1 7.8 81.3 1.8 33.8-7.4 56-28.3 68-60.4 8-21.5 10.7-43.8 11-66.5.1-5.8.3-47-.2-52.8l-.9-.3c-.8 1.5-1.7 2.9-2.5 4.4-22.1 43.1-61.3 67.4-105.4 69.1-103 4-169.4-57-172-176.2-.5-23.7 1.8-46.9 8.3-69.7C58.3 47.7 112.3.6 191.6 0c61.3-.4 101.5 38.7 116.2 70.3.5 1.1 1.3 2.3 2.4 1.9V10.6h44.3c0 280.3.1 332.2.1 332.2-.1 78.5-26.7 143.7-103 162.2-69.5 16.9-159 4.8-196-57.2-8-13.5-11.8-28.3-13-44.5zM188.9 36.5c-52.5-.5-108.5 40.7-115 133.8-4.1 59 14.8 122.2 71.5 148.6 27.6 12.9 74.3 15 108.3-8.7 47.6-33.2 62.7-97 54.8-154-9.7-71.1-47.8-120-119.6-119.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
