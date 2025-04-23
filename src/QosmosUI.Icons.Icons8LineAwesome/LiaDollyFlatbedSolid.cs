// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaDollyFlatbedSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 19 6 C 17.355469 6 16 7.355469 16 9 L 10 9 L 10 21 L 28 21 L 28 9 L 22 9 C 22 7.355469 20.644531 6 19 6 Z M 4 7 L 4 9 L 5 9 C 5.554688 9 6 9.445313 6 10 L 6 21 C 6 23.210938 7.789063 25 10 25 L 28 25 L 28 23 L 10 23 C 8.808594 23 8 22.191406 8 21 L 8 10 C 8 8.355469 6.644531 7 5 7 Z M 24.5 25 C 23.671875 25 23 25.671875 23 26.5 C 23 27.328125 23.671875 28 24.5 28 C 25.328125 28 26 27.328125 26 26.5 C 26 25.671875 25.328125 25 24.5 25 Z M 12.5 25 C 11.671875 25 11 25.671875 11 26.5 C 11 27.328125 11.671875 28 12.5 28 C 13.328125 28 14 27.328125 14 26.5 C 14 25.671875 13.328125 25 12.5 25 Z M 19 8 C 19.554688 8 20 8.445313 20 9 L 18 9 C 18 8.445313 18.445313 8 19 8 Z M 12 11 L 26 11 L 26 19 L 12 19 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
