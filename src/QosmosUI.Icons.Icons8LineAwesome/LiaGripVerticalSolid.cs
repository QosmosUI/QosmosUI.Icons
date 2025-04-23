// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaGripVerticalSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 7 2 L 7 10 L 15 10 L 15 2 L 7 2 z M 17 2 L 17 10 L 25 10 L 25 2 L 17 2 z M 9 4 L 13 4 L 13 8 L 9 8 L 9 4 z M 19 4 L 23 4 L 23 8 L 19 8 L 19 4 z M 7 12 L 7 20 L 15 20 L 15 12 L 7 12 z M 17 12 L 17 20 L 25 20 L 25 12 L 17 12 z M 9 14 L 13 14 L 13 18 L 9 18 L 9 14 z M 19 14 L 23 14 L 23 18 L 19 18 L 19 14 z M 7 22 L 7 30 L 15 30 L 15 22 L 7 22 z M 17 22 L 17 30 L 25 30 L 25 22 L 17 22 z M 9 24 L 13 24 L 13 28 L 9 28 L 9 24 z M 19 24 L 23 24 L 23 28 L 19 28 L 19 24 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
