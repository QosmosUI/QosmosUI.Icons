// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaMemorySolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 2 7 L 2 25 L 15 25 L 15 24 C 15 23.445313 15.445313 23 16 23 C 16.554688 23 17 23.445313 17 24 L 17 25 L 30 25 L 30 7 Z M 4 9 L 28 9 L 28 18 L 4 18 Z M 6 11 L 6 16 L 12 16 L 12 11 Z M 13 11 L 13 16 L 19 16 L 19 11 Z M 20 11 L 20 16 L 26 16 L 26 11 Z M 8 13 L 10 13 L 10 14 L 8 14 Z M 15 13 L 17 13 L 17 14 L 15 14 Z M 22 13 L 24 13 L 24 14 L 22 14 Z M 4 20 L 28 20 L 28 23 L 18.59375 23 C 18.152344 21.890625 17.257813 21 16 21 C 14.742188 21 13.847656 21.890625 13.40625 23 L 4 23 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
