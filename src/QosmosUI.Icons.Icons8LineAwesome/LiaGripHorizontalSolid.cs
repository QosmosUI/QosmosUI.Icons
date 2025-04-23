// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaGripHorizontalSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 2 7 L 2 15 L 10 15 L 10 7 L 2 7 z M 12 7 L 12 15 L 20 15 L 20 7 L 12 7 z M 22 7 L 22 15 L 30 15 L 30 7 L 22 7 z M 4 9 L 8 9 L 8 13 L 4 13 L 4 9 z M 14 9 L 18 9 L 18 13 L 14 13 L 14 9 z M 24 9 L 28 9 L 28 13 L 24 13 L 24 9 z M 2 17 L 2 25 L 10 25 L 10 17 L 2 17 z M 12 17 L 12 25 L 20 25 L 20 17 L 12 17 z M 22 17 L 22 25 L 30 25 L 30 17 L 22 17 z M 4 19 L 8 19 L 8 23 L 4 23 L 4 19 z M 14 19 L 18 19 L 18 23 L 14 23 L 14 19 z M 24 19 L 28 19 L 28 23 L 24 23 L 24 19 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
