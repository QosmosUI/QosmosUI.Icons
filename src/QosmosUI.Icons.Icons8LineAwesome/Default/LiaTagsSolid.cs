// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaTagsSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 14.59375 4 L 14.28125 4.28125 L 3.28125 15.28125 L 2.59375 16 L 3.28125 16.71875 L 12.28125 25.71875 L 13 26.40625 L 13.71875 25.71875 L 24.71875 14.71875 L 25 14.40625 L 25 4 Z M 15.4375 6 L 23 6 L 23 13.5625 L 13 23.5625 L 5.4375 16 Z M 26 7 L 26 9 L 27 9 L 27 17.15625 L 17.5 26.59375 L 16.25 25.34375 L 14.84375 26.75 L 16.78125 28.71875 L 17.5 29.40625 L 18.1875 28.71875 L 28.71875 18.3125 L 29 18 L 29 7 Z M 20 8 C 19.449219 8 19 8.449219 19 9 C 19 9.550781 19.449219 10 20 10 C 20.550781 10 21 9.550781 21 9 C 21 8.449219 20.550781 8 20 8 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
