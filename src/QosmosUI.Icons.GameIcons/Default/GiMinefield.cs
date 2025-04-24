// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMinefield : ComponentBase
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
		builder.AddAttribute(14, "d", "M239 263h43v213h-43zM447 36v211H61V36zM299 197.33v-25.14l46-23.35-7.24-14.27L307.44 150A59.58 59.58 0 1 0 195 122.42a61.11 61.11 0 0 0 9.45 31.91l-32.75-14.9-6.63 14.57L210 174.43v25l-38.74 19.66 7.24 14.27L228.45 208h55.37l52.76 24 6.63-14.56zm-13.45-44l-2.55 2.31V192h-57v-36.36l-2.17-2.34a43.88 43.88 0 0 1 .17-61.76 43.59 43.59 0 1 1 61.54 61.75zm-46.76-1.23a11.12 11.12 0 1 0-11.12-11.12 11.12 11.12 0 0 0 11.12 11.08zm26 16.94l-9.93-17.15L245 169zm16.95-28.06a11.12 11.12 0 1 0-11.12 11.12 11.12 11.12 0 0 0 11.14-11.16zM155.18 384.75c-24.85 0-45 3.81-45 8.5 0 4.69 20.15 8.5 45 8.5s45-3.81 45-8.5c0-4.69-20.18-8.5-45-8.5zM446.55 332c-16.29 0-29.5 2.19-29.5 4.89 0 2.7 13.21 4.89 29.5 4.89s29.5-2.19 29.5-4.89c0-2.7-13.21-4.89-29.5-4.89zm-390.1-36.75c-11.32 0-20.5 1.34-20.5 3s9.18 3 20.5 3 20.5-1.34 20.5-3-9.18-3-20.5-3zm280.22-.42c-11.32 0-20.5 1.43-20.5 3.2 0 1.77 9.18 3.2 20.5 3.2s20.5-1.43 20.5-3.2c0-1.77-9.17-3.2-20.5-3.2zm62.69 122.41c-39.76 0-72 7.81-72 17.45s32.24 17.45 72 17.45 72-7.81 72-17.45-32.23-17.45-72-17.45z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
