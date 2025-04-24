// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPrintSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 9 4 L 9 11 L 7 11 C 5.355469 11 4 12.355469 4 14 L 4 24 L 9 24 L 9 28 L 23 28 L 23 24 L 28 24 L 28 14 C 28 12.355469 26.644531 11 25 11 L 23 11 L 23 4 Z M 11 6 L 21 6 L 21 11 L 11 11 Z M 7 13 L 25 13 C 25.566406 13 26 13.433594 26 14 L 26 22 L 23 22 L 23 18 L 9 18 L 9 22 L 6 22 L 6 14 C 6 13.433594 6.433594 13 7 13 Z M 8 14 C 7.449219 14 7 14.449219 7 15 C 7 15.550781 7.449219 16 8 16 C 8.550781 16 9 15.550781 9 15 C 9 14.449219 8.550781 14 8 14 Z M 11 20 L 21 20 L 21 26 L 11 26 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
