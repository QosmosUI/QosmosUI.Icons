// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaProceduresSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 17.125 0.4375 L 14.375 6 L 9 6 L 9 8 L 15.625 8 L 16.875 5.4375 L 19.71875 13 L 23.5 8 L 28 8 L 28 6 L 22.5 6 L 20.28125 8.875 L 17.125 0.4375 z M 6.5 11 C 5.117 11 4 12.117 4 13.5 L 4 28 L 9 28 L 9 26 L 23 26 L 23 28 L 28 28 L 28 17 C 28 15.355 26.645 14 25 14 L 13 14 L 13 14.5625 C 12.406 14.2145 11.734 14 11 14 C 10.266 14 9.594 14.2145 9 14.5625 L 9 13.5 C 9 12.117 7.883 11 6.5 11 z M 6.5 13 C 6.715 13 7 13.285 7 13.5 L 7 22 L 26 22 L 26 26 L 25 26 L 25 24 L 7 24 L 7 26 L 6 26 L 6 13.5 C 6 13.285 6.285 13 6.5 13 z M 11 16 C 12.117 16 13 16.883 13 18 C 13 19.117 12.117 20 11 20 C 9.883 20 9 19.117 9 18 C 9 16.883 9.883 16 11 16 z M 15 16 L 25 16 C 25.555 16 26 16.445 26 17 L 26 20 L 15 20 L 15 16 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
