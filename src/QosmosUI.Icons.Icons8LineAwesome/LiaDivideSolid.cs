// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaDivideSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 6 C 14.355469 6 13 7.355469 13 9 C 13 10.644531 14.355469 12 16 12 C 17.644531 12 19 10.644531 19 9 C 19 7.355469 17.644531 6 16 6 Z M 16 8 C 16.5625 8 17 8.4375 17 9 C 17 9.5625 16.5625 10 16 10 C 15.4375 10 15 9.5625 15 9 C 15 8.4375 15.4375 8 16 8 Z M 5 15 L 5 17 L 27 17 L 27 15 Z M 16 20 C 14.355469 20 13 21.355469 13 23 C 13 24.644531 14.355469 26 16 26 C 17.644531 26 19 24.644531 19 23 C 19 21.355469 17.644531 20 16 20 Z M 16 22 C 16.5625 22 17 22.4375 17 23 C 17 23.5625 16.5625 24 16 24 C 15.4375 24 15 23.5625 15 23 C 15 22.4375 15.4375 22 16 22 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
