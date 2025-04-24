// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaMix : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 25 C 5 26.654 6.346 28 8 28 C 9.654 28 11 26.654 11 25 L 11 13 C 11 12.448 11.448 12 12 12 C 12.552 12 13 12.448 13 13 L 13 21 C 13 22.654 14.346 24 16 24 C 17.654 24 19 22.654 19 21 L 19 15 C 19 14.448 19.448 14 20 14 C 20.552 14 21 14.448 21 15 L 21 17 C 21 18.654 22.346 20 24 20 C 25.654 20 27 18.654 27 17 L 27 5 L 5 5 z M 7 7 L 25 7 L 25 17 C 25 17.552 24.552 18 24 18 C 23.448 18 23 17.552 23 17 L 23 15 C 23 13.346 21.654 12 20 12 C 18.346 12 17 13.346 17 15 L 17 21 C 17 21.552 16.552 22 16 22 C 15.448 22 15 21.552 15 21 L 15 13 C 15 11.346 13.654 10 12 10 C 10.346 10 9 11.346 9 13 L 9 25 C 9 25.552 8.552 26 8 26 C 7.448 26 7 25.552 7 25 L 7 7 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
