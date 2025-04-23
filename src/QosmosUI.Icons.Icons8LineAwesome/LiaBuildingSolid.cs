// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaBuildingSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 4 3 L 4 29 L 15 29 L 15 25 L 17 25 L 17 29 L 28 29 L 28 3 Z M 6 5 L 26 5 L 26 27 L 19 27 L 19 23 L 13 23 L 13 27 L 6 27 Z M 8 7 L 8 9 L 12 9 L 12 7 Z M 14 7 L 14 9 L 18 9 L 18 7 Z M 20 7 L 20 9 L 24 9 L 24 7 Z M 8 11 L 8 13 L 12 13 L 12 11 Z M 14 11 L 14 13 L 18 13 L 18 11 Z M 20 11 L 20 13 L 24 13 L 24 11 Z M 8 15 L 8 17 L 12 17 L 12 15 Z M 14 15 L 14 17 L 18 17 L 18 15 Z M 20 15 L 20 17 L 24 17 L 24 15 Z M 8 19 L 8 21 L 12 21 L 12 19 Z M 14 19 L 14 21 L 18 21 L 18 19 Z M 20 19 L 20 21 L 24 21 L 24 19 Z M 8 23 L 8 25 L 12 25 L 12 23 Z M 20 23 L 20 25 L 24 25 L 24 23 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
