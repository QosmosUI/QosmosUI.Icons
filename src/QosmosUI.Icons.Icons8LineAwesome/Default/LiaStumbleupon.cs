// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaStumbleupon : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 C 12.141 4 9 7.14 9 11 L 9 20.5 C 9 21.327 8.327 22 7.5 22 C 6.673 22 6 21.327 6 20.5 L 6 16 L 1 16 L 1 20.5 C 1 24.084 3.916 27 7.5 27 C 11.084 27 14 24.084 14 20.5 L 14 11 C 14 9.897 14.897 9 16 9 C 17.103 9 18 9.897 18 11 L 18 12.921875 L 19.888672 13.800781 L 23 12.876953 L 23 11 C 23 7.14 19.859 4 16 4 z M 26 16 L 26 20.5 C 26 21.327 25.327 22 24.5 22 C 23.673 22 23 21.327 23 20.5 L 23 16.005859 L 19.652344 17.001953 L 18 16.230469 L 18 20.5 C 18 24.084 20.916 27 24.5 27 C 28.084 27 31 24.084 31 20.5 L 31 16 L 26 16 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
