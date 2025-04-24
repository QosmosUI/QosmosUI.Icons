// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaDumpsterSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 6 L 3 14 L 4.3339844 14 L 4.6660156 16 L 3 16 L 3 18 L 5 18 L 6 24 L 6 26 L 8 26 L 8 24 L 24 24 L 24 26 L 26 26 L 26 24 L 27 18 L 29 18 L 29 16 L 27.333984 16 L 27.666016 14 L 29 14 L 27 6 L 17 6 L 15 6 L 5 6 z M 6.5625 8 L 9.3378906 8 L 8.5722656 12 L 5.5625 12 L 6.5625 8 z M 11.390625 8 L 15 8 L 15 12 L 10.630859 12 L 11.390625 8 z M 17 8 L 20.609375 8 L 21.369141 12 L 17 12 L 17 8 z M 22.662109 8 L 25.4375 8 L 26.4375 12 L 23.427734 12 L 22.662109 8 z M 6.3613281 14 L 8.1894531 14 L 10.25 14 L 15 14 L 17 14 L 21.75 14 L 23.810547 14 L 25.638672 14 L 24.306641 22 L 7.6933594 22 L 6.3613281 14 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
