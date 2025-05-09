// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiWinterGloves : ComponentBase
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
		builder.AddAttribute(14, "d", "M156.5 21.92c-1.3 0-2.5 0-3.8.1-16.8.86-35.7 7.64-53 18.52-27.82 17.42-50.42 44.95-54.61 67.66-14.5 78.7 9.32 146.2 44.82 210 46.99 3.4 90.89-1.2 132.99-11.2-3.2-14.4-5.7-33.9-3.7-51.5 1-8.8 3-17.2 7.5-24.4 4.4-7.1 12-12.9 21.4-14 5.8-.7 11.3.3 16.4 2.3 2.2-7.8 4.3-15.8 6-23.6 2.8-12.8 5-31.2 3.4-45.5-.8-7.1-2.6-13.1-4.9-16.8-2.3-3.7-4.3-5.2-8.2-5.7-5.3-.6-11.1 2-17.6 8-6.4 6.1-12.9 15.1-18.4 24.6-10.8 18.8-17.7 38.4-17.7 38.4l-17.1-5s9.3-36.9 12.2-76.6c1.4-19.97 1.2-40.55-2.3-57.02-3.5-16.47-10-27.95-19.7-32.99-7-3.59-15-5.26-23.7-5.27zM355 128.5c-8.7 0-16.8 1.7-23.8 5.3-9.8 5.1-16.3 16.6-19.8 33.1-3.5 16.6-3.7 37.2-2.3 57.2 2.9 40 12.3 77 12.3 77l-17.2 5.1s-6.9-19.7-17.8-38.6c-5.5-9.5-12-18.6-18.5-24.7-6.5-6-12.3-8.6-17.6-8-4 .5-6 2-8.3 5.7-2.3 3.7-4.1 9.7-4.9 16.9-1.6 14.3.6 32.8 3.4 45.7 10.5 47.7 33.1 99.2 37.5 109 45.4 11.9 92.9 17.6 143.9 13.9 35.7-64.1 59.5-131.9 45-210.9-4.2-22.8-26.9-50.4-54.8-67.9-17.4-11-36.4-17.8-53.3-18.7-1.3-.1-2.5-.1-3.8-.1zm-127.8 196c-5.5 1.3-10.9 2.4-16.4 3.6l8.4 45c7.3-1.2 14.7-2.6 22-4.1-4.9-13.8-9.9-29.1-14-44.5zm-34 6.8c-8.8 1.5-17.7 2.7-26.7 3.6l7.6 44.2c9.2-.9 18.4-2 27.4-3.3zm-101.57 5.1l.37 46.5c6.56 0 13-.1 19.5-.3l-2.5-45.4c-5.8-.2-11.55-.4-17.37-.8zm56.77 0c-7 .5-14.2.7-21.5.9l2.5 44.7c9.1-.3 17.9-.8 26.8-1.4zm129.3 94.4l-11.2 44.6c8.5 1.8 16.9 3.4 25.2 4.8l8.3-44.3c-7.5-1.5-14.9-3.2-22.3-5.1zm39.9 8.4l-8.2 43.7c9.1 1.3 18.3 2.4 27.4 3.3l7.5-43.4c-9-1-17.9-2.2-26.7-3.6zm44.7 5.2l-7.5 43.3c8.8.7 17.7 1.2 26.7 1.5l2.4-44c-7.2-.1-14.4-.4-21.6-.8zm57.1 0c-5.9.4-11.7.7-17.5.8l-2.4 44.6c6.4.2 12.9.3 19.5.3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
