// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaStackExchange : ComponentBase
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
		builder.AddAttribute(14, "d", "M 9 4 C 6.800781 4 5 5.800781 5 8 L 5 22 C 5 24.199219 6.800781 26 9 26 L 17 26 L 17 30.21875 L 18.5625 30.21875 L 18.875 29.90625 L 22.5625 26 L 23 26 C 25.199219 26 27 24.199219 27 22 L 27 8 C 27 5.800781 25.199219 4 23 4 Z M 9 6 L 23 6 C 24.117188 6 25 6.882813 25 8 L 25 9 L 7 9 L 7 8 C 7 6.882813 7.882813 6 9 6 Z M 7 11 L 25 11 L 25 14 L 7 14 Z M 7 16 L 25 16 L 25 19 L 7 19 Z M 7 21 L 25 21 L 25 22 C 25 23.117188 24.117188 24 23 24 L 21.6875 24 L 21.40625 24.3125 L 19 26.84375 L 19 24 L 9 24 C 7.882813 24 7 23.117188 7 22 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
