// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaBorderNoneSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 7 L 5 9 L 7 9 L 7 7 L 9 7 L 9 5 L 5 5 z M 11 5 L 11 7 L 15 7 L 15 5 L 11 5 z M 17 5 L 17 7 L 21 7 L 21 5 L 17 5 z M 23 5 L 23 7 L 25 7 L 25 9 L 27 9 L 27 7 L 27 5 L 25 5 L 23 5 z M 15 9 L 15 13 L 17 13 L 17 9 L 15 9 z M 5 11 L 5 15 L 7 15 L 7 11 L 5 11 z M 25 11 L 25 15 L 27 15 L 27 11 L 25 11 z M 9 15 L 9 17 L 13 17 L 13 15 L 9 15 z M 15 15 L 15 17 L 17 17 L 17 15 L 15 15 z M 19 15 L 19 17 L 23 17 L 23 15 L 19 15 z M 5 17 L 5 21 L 7 21 L 7 17 L 5 17 z M 25 17 L 25 21 L 27 21 L 27 17 L 25 17 z M 15 19 L 15 23 L 17 23 L 17 19 L 15 19 z M 5 23 L 5 27 L 7 27 L 9 27 L 9 25 L 7 25 L 7 23 L 5 23 z M 25 23 L 25 25 L 23 25 L 23 27 L 25 27 L 27 27 L 27 25 L 27 23 L 25 23 z M 11 25 L 11 27 L 15 27 L 15 25 L 11 25 z M 17 25 L 17 27 L 21 27 L 21 25 L 17 25 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
