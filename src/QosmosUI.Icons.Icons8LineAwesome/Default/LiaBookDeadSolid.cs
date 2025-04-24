// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaBookDeadSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 9 4 C 7.355 4 6 5.355 6 7 L 6 25 C 6 26.645 7.355 28 9 28 L 26 28 L 26 4 L 9 4 z M 9 6 L 24 6 L 24 22 L 9 22 C 8.648 22 8.316 22.0735 8 22.1875 L 8 7 C 8 6.434 8.434 6 9 6 z M 16 9 C 10.074 9 11.0625 17 11.0625 17 L 13 17 L 13 19 L 19 19 L 19 17 L 20.9375 17 C 20.9375 17 21.926 9 16 9 z M 14 13 C 14.55 13 15 13.45 15 14 C 15 14.55 14.55 15 14 15 C 13.45 15 13 14.55 13 14 C 13 13.45 13.45 13 14 13 z M 18 13 C 18.55 13 19 13.45 19 14 C 19 14.55 18.55 15 18 15 C 17.45 15 17 14.55 17 14 C 17 13.45 17.45 13 18 13 z M 16 15 L 17 17 L 15 17 L 16 15 z M 9 24 L 24 24 L 24 26 L 9 26 C 8.434 26 8 25.566 8 25 C 8 24.434 8.434 24 9 24 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
