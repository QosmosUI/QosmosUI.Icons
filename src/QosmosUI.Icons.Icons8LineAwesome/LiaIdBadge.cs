// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaIdBadge : ComponentBase
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
		builder.AddAttribute(14, "d", "M 15 3 C 13.90625 3 13 3.90625 13 5 L 7 5 L 7 28 L 25 28 L 25 5 L 19 5 C 19 3.90625 18.09375 3 17 3 Z M 15 5 L 17 5 L 17 7 L 15 7 Z M 9 7 L 13 7 L 13 9 L 19 9 L 19 7 L 23 7 L 23 26 L 9 26 Z M 16 11 C 13.800781 11 12 12.800781 12 15 C 12 16.113281 12.476563 17.117188 13.21875 17.84375 C 11.886719 18.746094 11 20.28125 11 22 L 13 22 C 13 20.332031 14.332031 19 16 19 C 17.667969 19 19 20.332031 19 22 L 21 22 C 21 20.28125 20.113281 18.746094 18.78125 17.84375 C 19.523438 17.117188 20 16.113281 20 15 C 20 12.800781 18.199219 11 16 11 Z M 16 13 C 17.117188 13 18 13.882813 18 15 C 18 16.117188 17.117188 17 16 17 C 14.882813 17 14 16.117188 14 15 C 14 13.882813 14.882813 13 16 13 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
