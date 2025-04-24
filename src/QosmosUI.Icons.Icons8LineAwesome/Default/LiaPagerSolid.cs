// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPagerSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 7 7 C 5.3550302 7 4 8.3550302 4 10 L 4 22 C 4 23.64497 5.3550302 25 7 25 L 25 25 C 26.64497 25 28 23.64497 28 22 L 28 10 C 28 8.3550302 26.64497 7 25 7 L 7 7 z M 7 9 L 25 9 C 25.56503 9 26 9.4349698 26 10 L 26 22 C 26 22.56503 25.56503 23 25 23 L 7 23 C 6.4349698 23 6 22.56503 6 22 L 6 10 C 6 9.4349698 6.4349698 9 7 9 z M 8 11 L 8 17 L 20 17 L 20 11 L 8 11 z M 22 11 L 22 13 L 24 13 L 24 11 L 22 11 z M 22 15 L 22 17 L 24 17 L 24 15 L 22 15 z M 8 19 L 8 21 L 20 21 L 20 19 L 8 19 z M 22 19 L 22 21 L 24 21 L 24 19 L 22 19 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
