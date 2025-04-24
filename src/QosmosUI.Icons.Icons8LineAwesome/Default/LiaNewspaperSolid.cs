// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaNewspaperSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 3 5 L 3 23 C 3 25.210938 4.789063 27 7 27 L 25 27 C 27.210938 27 29 25.210938 29 23 L 29 12 L 23 12 L 23 5 Z M 5 7 L 21 7 L 21 23 C 21 23.730469 21.222656 24.410156 21.5625 25 L 7 25 C 5.808594 25 5 24.191406 5 23 Z M 7 9 L 7 14 L 19 14 L 19 9 Z M 9 11 L 17 11 L 17 12 L 9 12 Z M 23 14 L 27 14 L 27 23 C 27 24.191406 26.191406 25 25 25 C 23.808594 25 23 24.191406 23 23 Z M 7 15 L 7 17 L 12 17 L 12 15 Z M 14 15 L 14 17 L 19 17 L 19 15 Z M 7 18 L 7 20 L 12 20 L 12 18 Z M 14 18 L 14 20 L 19 20 L 19 18 Z M 7 21 L 7 23 L 12 23 L 12 21 Z M 14 21 L 14 23 L 19 23 L 19 21 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
