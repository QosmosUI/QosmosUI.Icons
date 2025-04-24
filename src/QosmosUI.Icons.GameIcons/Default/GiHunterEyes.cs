// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiHunterEyes : ComponentBase
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
		builder.AddAttribute(14, "d", "M430.8 28.36c-36.5-.71-144 71.74-134 89.74 10.6 19.2 44.3 36.9 55.1 33.2 85.4-29.4 94.7-116.16 86.5-121.11-2-1.19-4.5-1.78-7.6-1.83zm-349.64 0c-3.1 0-5.6.6-7.6 1.8-8.2 4.9 1.1 91.74 86.34 121.14 10.8 3.7 44.5-14 55.1-33.2 10-18-97.4-90.54-133.84-89.74zM36.85 193c-12 80.3 47.31 135.2 106.45 147.1 47.8 9.5 86-28.5 83.3-38.6-6.8-25.7-134.94-100-189.75-108.5zm438.25 0c-54.8 8.5-183.1 82.8-189.9 108.5-2.7 10.1 35.5 48.1 83.3 38.6 59.3-11.9 118.6-66.8 106.6-147.1zM93.16 378.8c-2.9.1-5.4.5-7.3 1.2 2.8 61.4 74.04 103.8 88.14 103.6 23.3-.3 46.1-22.4 46.5-38.5.6-23-93.4-66.9-127.34-66.3zm325.64 0c-34.1-.6-128.1 43.3-127.5 66.3.4 16.1 23.2 38.2 46.5 38.5 14.1.2 85.5-42.2 88.3-103.6-1.9-.7-4.4-1.1-7.3-1.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
