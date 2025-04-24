// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaQrcodeSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 13 L 7 13 L 7 15 L 9 15 L 9 13 L 13 13 L 13 5 Z M 13 13 L 13 15 L 15 15 L 15 17 L 11 17 L 11 19 L 5 19 L 5 27 L 13 27 L 13 19 L 19 19 L 19 17 L 17 17 L 17 15 L 21 15 L 21 13 L 23 13 L 23 15 L 25 15 L 25 13 L 27 13 L 27 5 L 19 5 L 19 13 Z M 25 15 L 25 17 L 27 17 L 27 15 Z M 25 17 L 23 17 L 23 19 L 25 19 Z M 25 19 L 25 21 L 27 21 L 27 19 Z M 25 21 L 23 21 L 23 19 L 21 19 L 21 21 L 16 21 L 16 27 L 18 27 L 18 23 L 22 23 L 22 25 L 24 25 L 24 23 L 25 23 Z M 22 25 L 20 25 L 20 27 L 22 27 Z M 23 17 L 23 15 L 21 15 L 21 17 Z M 11 17 L 11 15 L 9 15 L 9 17 Z M 7 15 L 5 15 L 5 17 L 7 17 Z M 15 5 L 15 9 L 14 9 L 14 11 L 15 11 L 15 12 L 17 12 L 17 9 L 18 9 L 18 7 L 17 7 L 17 5 Z M 7 7 L 11 7 L 11 11 L 7 11 Z M 21 7 L 25 7 L 25 11 L 21 11 Z M 8 8 L 8 10 L 10 10 L 10 8 Z M 22 8 L 22 10 L 24 10 L 24 8 Z M 7 21 L 11 21 L 11 25 L 7 25 Z M 8 22 L 8 24 L 10 24 L 10 22 Z M 25 25 L 25 27 L 27 27 L 27 25 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
