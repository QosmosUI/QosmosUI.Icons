// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaVialsSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 7 L 6 7 L 6 19.5 C 6 21.4 7.6 23 9.5 23 C 11.4 23 13 21.4 13 19.5 L 13 7 L 14 7 L 14 5 L 13 5 L 6 5 L 5 5 z M 18 5 L 18 7 L 19 7 L 19 19.5 C 19 21.4 20.6 23 22.5 23 C 24.4 23 26 21.4 26 19.5 L 26 7 L 27 7 L 27 5 L 18 5 z M 8 7 L 11 7 L 11 13 L 8 13 L 8 7 z M 21 7 L 24 7 L 24 13 L 21 13 L 21 7 z M 8 15 L 11 15 L 11 19.5 C 11 20.3 10.3 21 9.5 21 C 8.7 21 8 20.3 8 19.5 L 8 15 z M 21 15 L 24 15 L 24 19.5 C 24 20.3 23.3 21 22.5 21 C 21.7 21 21 20.3 21 19.5 L 21 15 z M 2 25 L 2 27 L 30 27 L 30 25 L 2 25 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
