// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaBusSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 9 4 C 6.800781 4 5 5.800781 5 8 L 5 13 L 3 13 L 3 16 L 5 16 L 5 27 C 5 27.550781 5.449219 28 6 28 L 9 28 L 9.34375 27 L 22.65625 27 L 23 28 L 26 28 C 26.550781 28 27 27.550781 27 27 L 27 16 L 29 16 L 29 13 L 27 13 L 27 8 C 27 5.800781 25.199219 4 23 4 Z M 9 6 L 23 6 C 24.117188 6 25 6.882813 25 8 L 7 8 C 7 6.882813 7.882813 6 9 6 Z M 7 10 L 15 10 L 15 17 L 7 17 Z M 17 10 L 25 10 L 25 17 L 17 17 Z M 7 19 L 25 19 L 25 25 L 7 25 Z M 8 21 L 8 23 L 12 23 L 12 21 Z M 20 21 L 20 23 L 24 23 L 24 21 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
