// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFlexibleLamp : ComponentBase
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
		builder.AddAttribute(14, "d", "M309.9 23.04l-35.2 38.05 34.5 72.21 1.4 3.2-.9 3.3c-4.7 16-6.6 34.9-4.6 51.9 1.6 13 5.4 24.7 11.5 33.3l160-173.15c-9.1-5.45-21-8.3-34.1-8.84-17.1-.68-35.8 2.75-51.4 8.67l-3.2 1.19-78-29.83zM265.7 84.1L76.36 179.5c6.18 2.8 11.68 6.9 16.17 11.9l180.87-91.1-7.7-16.2zM441.8 116l-63.9 69.3c19.1 12 44.7 9 60.6-8.2 15.9-17.1 16.8-42.9 3.3-61.1zm-160.6.6l-179.3 90.3c2 5.3 3.1 11.1 3.1 17.1v1.5l183.9-92.7-7.7-16.2zM56 193c-17.23 0-31 13.8-31 31s13.77 31 31 31 31-13.8 31-31-13.77-31-31-31zm45.5 49.1c-2.41 6-6 11.5-10.49 16.1L198.2 407h22.1L101.5 242.1zm-25.24 26.5c-5.82 2.6-12.25 4.2-19 4.4l96.54 134H176L76.26 268.6zM313 389v18h18v-18h-18zm-180.7 36l-49.57 62H429.3l-49.6-62H132.3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
