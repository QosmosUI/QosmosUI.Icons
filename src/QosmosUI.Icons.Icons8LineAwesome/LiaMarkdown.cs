// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaMarkdown : ComponentBase
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
		builder.AddAttribute(14, "d", "M 2.875 6 C 1.320313 6 0 7.253906 0 8.8125 L 0 23.1875 C 0 24.746094 1.320313 26 2.875 26 L 29.125 26 C 30.679688 26 32 24.746094 32 23.1875 L 32 8.8125 C 32 7.253906 30.679688 6 29.125 6 Z M 2.875 8 L 29.125 8 C 29.640625 8 30 8.382813 30 8.8125 L 30 23.1875 C 30 23.617188 29.640625 24 29.125 24 L 2.875 24 C 2.359375 24 2 23.617188 2 23.1875 L 2 8.8125 C 2 8.382813 2.359375 8 2.875 8 Z M 5 11 L 5 21 L 8 21 L 8 14.34375 L 11 18.3125 L 14 14.34375 L 14 21 L 17 21 L 17 11 L 14 11 L 11 15 L 8 11 Z M 22 11 L 22 16 L 19 16 L 23.5 21 L 28 16 L 25 16 L 25 11 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
