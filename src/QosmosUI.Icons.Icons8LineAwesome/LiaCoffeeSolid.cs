// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaCoffeeSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 11 3 L 11 7 L 13 7 L 13 3 Z M 15 4 L 15 7 L 17 7 L 17 4 Z M 4.875 8 L 5 9.09375 L 6.8125 26.3125 C 6.972656 27.832031 8.285156 29 9.8125 29 L 19.1875 29 C 20.714844 29 22.027344 27.832031 22.1875 26.3125 L 22.65625 22 L 25 22 C 26.644531 22 28 20.644531 28 19 L 28 16 C 28 14.355469 26.644531 13 25 13 L 23.59375 13 L 24 9.09375 L 24.125 8 Z M 7.125 10 L 21.875 10 L 20.1875 26.09375 C 20.132813 26.613281 19.707031 27 19.1875 27 L 9.8125 27 C 9.292969 27 8.867188 26.613281 8.8125 26.09375 Z M 23.375 15 L 25 15 C 25.566406 15 26 15.433594 26 16 L 26 19 C 26 19.566406 25.566406 20 25 20 L 22.84375 20 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
