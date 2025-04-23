// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaToiletSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 6 4 C 5.476563 4 4.941406 4.183594 4.5625 4.5625 C 4.183594 4.941406 4 5.476563 4 6 L 4 17 C 4 19.789063 5.652344 22.117188 8 23.59375 L 8 28 L 23 28 L 23 23.59375 C 25.347656 22.117188 27 19.789063 27 17 L 27 16 L 14 16 L 14 6 C 14 5.476563 13.816406 4.941406 13.4375 4.5625 C 13.058594 4.183594 12.523438 4 12 4 Z M 6 6 L 12 6 L 12 16 L 6 16 Z M 8 8 L 8 11 L 10 11 L 10 8 Z M 6.3125 18 L 24.6875 18 C 24.332031 19.726563 23.320313 21.25 21.53125 22.21875 L 21 22.5 L 21 26 L 10 26 L 10 22.5 L 9.46875 22.21875 C 7.679688 21.25 6.667969 19.726563 6.3125 18 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
