// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaHotelSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 10 4 L 8 6 L 10 8 L 12 6 Z M 12 6 L 14 8 L 16 6 L 14 4 Z M 16 6 L 18 8 L 20 6 L 18 4 Z M 20 6 L 22 8 L 24 6 L 22 4 Z M 22 8 L 5 8 L 5 28 L 27 28 L 27 8 Z M 7 10 L 25 10 L 25 26 L 19 26 L 19 21 L 13 21 L 13 26 L 7 26 Z M 9 12 L 9 14 L 11 14 L 11 12 Z M 13 12 L 13 14 L 15 14 L 15 12 Z M 17 12 L 17 14 L 19 14 L 19 12 Z M 21 12 L 21 14 L 23 14 L 23 12 Z M 9 15 L 9 17 L 11 17 L 11 15 Z M 13 15 L 13 17 L 15 17 L 15 15 Z M 17 15 L 17 17 L 19 17 L 19 15 Z M 21 15 L 21 17 L 23 17 L 23 15 Z M 9 18 L 9 20 L 11 20 L 11 18 Z M 13 18 L 13 20 L 15 20 L 15 18 Z M 17 18 L 17 20 L 19 20 L 19 18 Z M 21 18 L 21 20 L 23 20 L 23 18 Z M 9 21 L 9 23 L 11 23 L 11 21 Z M 21 21 L 21 23 L 23 23 L 23 21 Z M 15 23 L 17 23 L 17 26 L 15 26 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
