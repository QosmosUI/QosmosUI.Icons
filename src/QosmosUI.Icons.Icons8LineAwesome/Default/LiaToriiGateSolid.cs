// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaToriiGateSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 2.9375 4.96875 L 2.9375 6.78125 L 3.25 7.09375 L 7.25 10.75 L 7.5625 11 L 9 11 L 9 14 L 7 14 L 7 16 L 9 16 L 9 27 L 11 27 L 11 16 L 21 16 L 21 27 L 23 27 L 23 16 L 25 16 L 25 14 L 23 14 L 23 11 L 24.375 11 L 24.6875 10.75 L 28.6875 7.09375 L 29 6.78125 L 29 4.96875 L 27.78125 5.25 C 27.746094 5.257813 23.527344 6 16 6 C 8.472656 6 4.191406 5.257813 4.15625 5.25 Z M 6.78125 7.5625 C 8.894531 7.773438 11.914063 8 16 8 C 20.054688 8 23.058594 7.769531 25.15625 7.5625 L 23.59375 9 L 8.34375 9 Z M 11 11 L 14 11 L 14 14 L 11 14 Z M 18 11 L 21 11 L 21 14 L 18 14 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
