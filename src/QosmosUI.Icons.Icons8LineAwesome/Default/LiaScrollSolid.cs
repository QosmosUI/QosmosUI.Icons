// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaScrollSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 10 4 C 8.355 4 7 5.355 7 7 L 7 21 L 4 21 L 4 25 C 4 26.645 5.355 28 7 28 L 21 28 L 21.03125 28 C 22.66025 27.984 24 26.633 24 25 L 24 11 L 28 11 L 28 7 C 28 5.355 26.645 4 25 4 L 10 4 z M 10 6 L 22.1875 6 C 22.0745 6.316 22 6.648 22 7 L 22 25 C 22 25.566 21.566 26 21 26 C 20.437 26.008 20.008 25.562 20 25 L 19.96875 21 L 9 21 L 9 7 C 9 6.434 9.434 6 10 6 z M 25 6 C 25.566 6 26 6.434 26 7 L 26 9 L 24 9 L 24 7 C 24 6.434 24.434 6 25 6 z M 6 23 L 14 23 L 17.96875 23 L 18 23 L 18 25 L 18 25.03125 C 18.004 25.37525 18.0745 25.691 18.1875 26 L 7 26 C 6.434 26 6 25.566 6 25 L 6 23 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
