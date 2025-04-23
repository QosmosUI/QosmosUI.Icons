// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaHourglassHalfSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 7 4 L 7 6 L 9 6 L 9 10 C 9 12.542969 10.367188 14.773438 12.40625 16 C 10.367188 17.226563 9 19.457031 9 22 L 9 26 L 7 26 L 7 28 L 25 28 L 25 26 L 23 26 L 23 22 C 23 19.457031 21.632813 17.226563 19.59375 16 C 21.632813 14.773438 23 12.542969 23 10 L 23 6 L 25 6 L 25 4 Z M 11 6 L 21 6 L 21 10 C 21 12.773438 18.773438 15 16 15 C 13.226563 15 11 12.773438 11 10 Z M 12.15625 11 C 12.601563 12.722656 14.136719 14 16 14 C 17.863281 14 19.398438 12.722656 19.84375 11 Z M 16 17 C 18.773438 17 21 19.226563 21 22 L 21 26 L 20 26 C 20 23.789063 18.210938 22 16 22 C 13.789063 22 12 23.789063 12 26 L 11 26 L 11 22 C 11 19.226563 13.226563 17 16 17 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
