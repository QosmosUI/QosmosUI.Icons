// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaCitySolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 10 3.8828125 L 3 7.3828125 L 3 28 L 17 28 L 29 28 L 29 10 L 17 10 L 17 7.3828125 L 10 3.8828125 z M 10 6.1171875 L 15 8.6171875 L 15 26 L 5 26 L 5 8.6171875 L 10 6.1171875 z M 7 10 L 7 12 L 9 12 L 9 10 L 7 10 z M 11 10 L 11 12 L 13 12 L 13 10 L 11 10 z M 17 12 L 27 12 L 27 26 L 17 26 L 17 12 z M 7 14 L 7 16 L 9 16 L 9 14 L 7 14 z M 11 14 L 11 16 L 13 16 L 13 14 L 11 14 z M 19 14 L 19 16 L 21 16 L 21 14 L 19 14 z M 23 14 L 23 16 L 25 16 L 25 14 L 23 14 z M 7 18 L 7 20 L 9 20 L 9 18 L 7 18 z M 11 18 L 11 20 L 13 20 L 13 18 L 11 18 z M 19 18 L 19 20 L 21 20 L 21 18 L 19 18 z M 23 18 L 23 20 L 25 20 L 25 18 L 23 18 z M 7 22 L 7 24 L 9 24 L 9 22 L 7 22 z M 11 22 L 11 24 L 13 24 L 13 22 L 11 22 z M 19 22 L 19 24 L 21 24 L 21 22 L 19 22 z M 23 22 L 23 24 L 25 24 L 25 22 L 23 22 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
