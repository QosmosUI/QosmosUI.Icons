// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaDiceSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 12 1 L 0 13 L 12 25 L 24 13 L 12 1 z M 12 3.8007812 L 21.199219 13 L 12 22.199219 L 2.8007812 13 L 12 3.8007812 z M 12 8 A 1 1 0 0 0 12 10 A 1 1 0 0 0 12 8 z M 8 12 A 1 1 0 0 0 8 14 A 1 1 0 0 0 8 12 z M 12 12 A 1 1 0 0 0 12 14 A 1 1 0 0 0 12 12 z M 16 12 A 1 1 0 0 0 16 14 A 1 1 0 0 0 16 12 z M 26.800781 13 L 24.800781 15 L 30 15 L 30 27 L 18 27 L 18 21.800781 L 16 23.800781 L 16 29 L 32 29 L 32 13 L 26.800781 13 z M 12 16 A 1 1 0 0 0 12 18 A 1 1 0 0 0 12 16 z M 24 20 A 1 1 0 0 0 24 22 A 1 1 0 0 0 24 20 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
