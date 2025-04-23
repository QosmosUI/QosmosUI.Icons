// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiChessKing : ComponentBase
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
		builder.AddAttribute(14, "d", "M405.995 477.15h-300v-60h300v60zm-10.3-107.13h-279.4a96.88 96.88 0 0 1 6.65 31.12h266.1a96.88 96.88 0 0 1 6.65-31.12zm-139.7-241.06a35.76 35.76 0 0 0-35.76 35.76c0 50.16 35.76 99.34 35.76 99.34s35.76-49.18 35.76-99.34a35.76 35.76 0 0 0-35.76-35.76zm8-15.38V94.24h18.36v-16h-18.36V54.85h-16v23.39h-18.36v16h18.36v19.38a51.9 51.9 0 0 1 16-.04zm81.64 51.36a98.74 98.74 0 0 0-38.13 7.61c-3.23 51.75-37.07 98.85-38.58 100.93l-4.93 6.76V354h140c16.57-26.15 40.78-42.41 40.78-90a99.13 99.13 0 0 0-99.14-99.07zm-141.16 7.61a99.16 99.16 0 0 0-137.25 91.51c0 47.55 24.21 63.82 40.78 90h139.99v-73.82l-4.94-6.79c-1.51-2.05-35.34-49.15-38.58-100.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
