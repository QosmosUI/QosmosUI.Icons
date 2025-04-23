// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiChopsticks : ComponentBase
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
		builder.AddAttribute(14, "d", "M253.8 19.46h-1.1c-1.8.1-3.5.34-5.1.85-4.2 1.3-7.4 3.84-9.6 9.49l-14.5 39.6 33.8 12.74 16.4-38.93c2.2-5.65 1.6-9.64-.6-13.3-2.2-3.8-6.3-7.04-11.2-8.87-2.6-1-5.4-1.53-8.1-1.59zM217.4 86.2 82.21 455.4l15.84 5.9L250.4 98.63zm189.8 11.6c-4.3.2-8.1 1.85-11.8 6.7l-24.5 34.6 29.3 20.8 26.1-33.4c3.7-4.8 4.1-8.9 3-12.9-1.2-4.3-4.2-8.4-8.5-11.4-3.7-2.67-8-4.21-11.9-4.4h-1.7zm-46.7 55.9L132.1 476l13.7 9.7 243.3-311.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
