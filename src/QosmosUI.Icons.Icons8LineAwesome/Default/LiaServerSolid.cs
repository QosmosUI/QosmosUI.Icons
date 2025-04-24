// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaServerSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 3 6 L 3 26 L 29 26 L 29 6 Z M 5 8 L 27 8 L 27 12 L 5 12 Z M 7 9 L 7 11 L 15 11 L 15 9 Z M 24 9 C 23.449219 9 23 9.449219 23 10 C 23 10.550781 23.449219 11 24 11 C 24.550781 11 25 10.550781 25 10 C 25 9.449219 24.550781 9 24 9 Z M 5 14 L 27 14 L 27 18 L 5 18 Z M 7 15 L 7 17 L 15 17 L 15 15 Z M 24 15 C 23.449219 15 23 15.449219 23 16 C 23 16.550781 23.449219 17 24 17 C 24.550781 17 25 16.550781 25 16 C 25 15.449219 24.550781 15 24 15 Z M 5 20 L 27 20 L 27 24 L 5 24 Z M 7 21 L 7 23 L 15 23 L 15 21 Z M 24 21 C 23.449219 21 23 21.449219 23 22 C 23 22.550781 23.449219 23 24 23 C 24.550781 23 25 22.550781 25 22 C 25 21.449219 24.550781 21 24 21 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
