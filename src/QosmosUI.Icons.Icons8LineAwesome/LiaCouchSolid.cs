// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaCouchSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 6 7 C 4.355469 7 3 8.355469 3 10 L 3 12.1875 C 1.84375 12.605469 1 13.707031 1 15 L 1 26 L 3 26 L 3 24 L 29 24 L 29 26 L 31 26 L 31 15 C 31 13.707031 30.15625 12.605469 29 12.1875 L 29 10 C 29 8.355469 27.644531 7 26 7 Z M 6 9 L 26 9 C 26.554688 9 27 9.445313 27 10 L 27 12.1875 C 25.84375 12.605469 25 13.707031 25 15 L 25 17 L 7 17 L 7 15 C 7 13.707031 6.15625 12.605469 5 12.1875 L 5 10 C 5 9.445313 5.445313 9 6 9 Z M 4 14 C 4.554688 14 5 14.445313 5 15 L 5 19 L 27 19 L 27 15 C 27 14.445313 27.445313 14 28 14 C 28.554688 14 29 14.445313 29 15 L 29 22 L 3 22 L 3 15 C 3 14.445313 3.445313 14 4 14 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
