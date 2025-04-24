// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaFilmSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 4 4 L 4 28 L 28 28 L 28 4 Z M 6 6 L 8 6 L 8 7 L 10 7 L 10 6 L 22 6 L 22 7 L 24 7 L 24 6 L 26 6 L 26 26 L 24 26 L 24 25 L 22 25 L 22 26 L 10 26 L 10 25 L 8 25 L 8 26 L 6 26 Z M 8 9 L 8 11 L 10 11 L 10 9 Z M 22 9 L 22 11 L 24 11 L 24 9 Z M 8 13 L 8 15 L 10 15 L 10 13 Z M 22 13 L 22 15 L 24 15 L 24 13 Z M 8 17 L 8 19 L 10 19 L 10 17 Z M 22 17 L 22 19 L 24 19 L 24 17 Z M 8 21 L 8 23 L 10 23 L 10 21 Z M 22 21 L 22 23 L 24 23 L 24 21 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
