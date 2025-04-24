// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaUserTagSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 16 5 C 12.1 5 9 8.1 9 12 C 9 14.4375 10.209961 16.561523 12.070312 17.8125 C 8.5100119 19.34733 6 22.893578 6 27 L 8 27 C 8 22.6 11.6 19 16 19 C 19.9 19 23 15.9 23 12 C 23 8.1 19.9 5 16 5 z M 16 7 C 18.8 7 21 9.2 21 12 C 21 14.8 18.8 17 16 17 C 13.2 17 11 14.8 11 12 C 11 9.2 13.2 7 16 7 z M 21 19 C 19.9 19 19 19.9 19 21 L 19 25.400391 L 25 31.400391 C 25.4 31.800391 25.900391 32 26.400391 32 C 26.900391 32 27.400781 31.800391 27.800781 31.400391 L 31.400391 27.800781 C 31.800391 27.400781 32 26.900391 32 26.400391 C 32 25.900391 31.800391 25.4 31.400391 25 L 25.400391 19 L 21 19 z M 21 21 L 24.599609 21 L 30 26.400391 L 26.400391 30 L 21 24.599609 L 21 21 z M 23 22 A 1 1 0 0 0 23 24 A 1 1 0 0 0 23 22 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
