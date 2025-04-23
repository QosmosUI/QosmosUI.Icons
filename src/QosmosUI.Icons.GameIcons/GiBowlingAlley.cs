// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBowlingAlley : ComponentBase
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
		builder.AddAttribute(14, "d", "M192 26c-4.5.1-6.6 1.52-7.9 3.87-1.2 2.35-1.5 5.96-1.2 9.99.3 4.1 1.2 8.47 1.9 12.5.3 1.61.6 3.1.8 4.54l.2 3.59h.1c-.1.78-.1 1.5-.2 2.1-.3 1.61-.6 3.1-1.1 4.54l-3 7.24c-2.1 4.48-4.4 8.79-5.7 14.1-2.3 9.35-1.5 22.23 9.9 45.03 5.4.4 3.9.3 6.7.3 2.8 0 1.2.1 6.7-.3 4.6-9.1 7.4-16.7 9-23 1.7 6.3 4.5 13.9 9.1 23 5.4.4 3.9.3 6.7.3 2.8 0 1.2.1 6.7-.3 4.8-9.6 7.7-17.5 9.3-24 1.6 6.5 4.5 14.4 9.3 24 5.4.4 3.9.3 6.7.3 2.8 0 1.2.1 6.7-.3 5.1-10.1 8-18.3 9.5-25.1 1.6 6.8 4.5 15 9.6 25.1 5.4.4 3.9.3 6.7.3 2.8 0 1.2.1 6.7-.3 4.8-9.6 7.7-17.5 9.3-24 1.6 6.5 4.5 14.4 9.3 24 5.4.4 3.9.3 6.7.3 2.8 0 1.2.1 6.7-.3 11.4-22.8 12.1-35.68 9.9-45.03-1.3-5.31-3.6-9.62-5.8-14.1l-3-7.24c-.4-1.44-.7-2.93-1-4.54-.1-.6-.2-1.32-.2-2.1l.3-3.59c.2-1.44.5-2.99.8-4.65.7-4.03 1.6-8.51 1.9-12.55.3-4.04-.1-7.66-1.4-9.99-1.4-2.33-3.5-3.75-8.2-3.71h-.5c-4.5.1-6.6 1.52-7.9 3.87-1.2 2.35-1.5 5.96-1.2 9.99.3 4.1 1.2 8.47 1.9 12.5.3 1.61.6 3.1.8 4.54l.2 3.59h.1c-.1.78-.1 1.5-.2 2.1-.3 1.61-.6 3.1-1.1 4.54l-3 7.24c-1.8 3.86-3.8 7.59-5.1 11.94-1.3-4.35-3.3-8.08-5.2-11.94l-3-7.24c-.4-1.44-.7-2.93-1-4.54-.1-.6-.2-1.32-.2-2.1l.3-3.59c.2-1.44.5-2.99.8-4.65.7-4.03 1.6-8.51 1.9-12.55.3-4.04-.1-7.66-1.4-9.99-1.4-2.33-3.5-3.75-8.2-3.71h-.5c-4.5.1-6.6 1.52-7.9 3.87-1.2 2.35-1.5 5.96-1.2 9.99.3 4.1 1.2 8.47 1.9 12.5.3 1.61.6 3.1.8 4.54l.2 3.59h.1c-.1.78-.1 1.5-.2 2.1-.3 1.61-.6 3.1-1.1 4.54l-3 7.24c-1.9 4.11-4 8.09-5.4 12.82-1.3-4.73-3.4-8.71-5.4-12.82l-3-7.24c-.4-1.44-.7-2.93-1-4.54-.1-.6-.2-1.32-.2-2.1l.3-3.59c.2-1.44.5-2.99.8-4.65.7-4.03 1.6-8.51 1.9-12.55.3-4.04-.1-7.66-1.4-9.99-1.4-2.33-3.5-3.75-8.2-3.71h-.5c-4.5.1-6.6 1.52-7.9 3.87-1.2 2.35-1.5 5.96-1.2 9.99.3 4.1 1.2 8.47 1.9 12.5.3 1.61.6 3.1.8 4.54l.2 3.59h.1c-.1.78-.1 1.5-.2 2.1-.3 1.61-.6 3.1-1.1 4.54l-3 7.24c-1.8 3.86-3.8 7.59-5.1 11.94-1.3-4.35-3.3-8.08-5.2-11.94l-3-7.24c-.4-1.44-.7-2.93-1-4.54-.1-.6-.2-1.32-.2-2.1l.3-3.59c.2-1.44.5-2.99.8-4.65.7-4.03 1.6-8.51 1.9-12.55.3-4.04-.1-7.66-1.4-9.99-1.4-2.33-3.5-3.75-8.2-3.71h-.5c-4.5.1-6.6 1.52-7.9 3.87-1.2 2.35-1.5 5.96-1.2 9.99.3 4.1 1.2 8.47 1.9 12.5.3 1.61.6 3.1.8 4.54l.2 3.59h.1c-.1.78-.1 1.5-.2 2.1-.3 1.61-.6 3.1-1.1 4.54l-3 7.24c-1.7 3.63-3.5 7.16-4.9 11.18-1.3-4.02-3.1-7.55-4.9-11.18l-3-7.24c-.4-1.44-.7-2.93-1-4.54-.1-.6-.2-1.32-.2-2.1l.3-3.59c.2-1.44.5-2.99.8-4.65.7-4.03 1.6-8.51 1.9-12.55.3-4.04-.1-7.66-1.4-9.99-1.4-2.33-3.5-3.75-8.2-3.71zm-10.1 127L45.65 489h75.85l64.9-219.7L136 489h206.4l-5.8-97.3 19.8 97.3h110L330.1 153zm137.9 103h.2c26.5 0 48 21.5 48 48s-21.5 48-48 48-48-21.5-48-48c0-26.4 21.4-47.9 47.8-48zm-1.9 8.7c-31.8 0-43 40.6-35.2 51.7-2.2-13.7 16.7-45.4 41.8-51.1-2.3-.4-4.5-.6-6.6-.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
