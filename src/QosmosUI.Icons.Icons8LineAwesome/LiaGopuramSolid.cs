// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaGopuramSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 9 5 L 9 10 L 8 10 L 8 14 L 6 14 L 6 20 L 4 20 L 4 27 L 9 27 L 9 20 L 10 20 L 10 14 L 11 14 L 11 10 L 13 10 L 13 14 L 12 14 L 12 20 L 11 20 L 11 27 L 13 27 L 13 25 C 13 23.343 14.343 22 16 22 C 17.657 22 19 23.343 19 25 L 19 27 L 21 27 L 21 20 L 20 20 L 20 14 L 19 14 L 19 10 L 21 10 L 21 14 L 22 14 L 22 20 L 23 20 L 23 27 L 28 27 L 28 20 L 26 20 L 26 14 L 24 14 L 24 10 L 23 10 L 23 5 L 21 5 L 21 7 L 19 7 L 19 5 L 17 5 L 17 7 L 15 7 L 15 5 L 13 5 L 13 7 L 11 7 L 11 5 L 9 5 z M 16 11 C 16.552 11 17 11.448 17 12 L 17 14 L 15 14 L 15 12 C 15 11.448 15.448 11 16 11 z M 16 16 C 17.105 16 18 16.895 18 18 L 18 20 L 14 20 L 14 18 C 14 16.895 14.895 16 16 16 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
