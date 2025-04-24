// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaSprayCanSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 12 2 L 12 8 L 14 8 L 14 9.0625 C 9.898438 9.5 8.125 12.53125 8.125 12.53125 L 8 12.75 L 8 30 L 22 30 L 22 12.75 L 21.875 12.53125 C 21.875 12.53125 20.101563 9.5 16 9.0625 L 16 8 L 18 8 L 18 2 Z M 24 2 C 23.449219 2 23 2.449219 23 3 C 23 3.550781 23.449219 4 24 4 C 24.550781 4 25 3.550781 25 3 C 25 2.449219 24.550781 2 24 2 Z M 14 4 L 16 4 L 16 6 L 14 6 Z M 21 4 C 20.449219 4 20 4.449219 20 5 C 20 5.550781 20.449219 6 21 6 C 21.550781 6 22 5.550781 22 5 C 22 4.449219 21.550781 4 21 4 Z M 24 6 C 23.449219 6 23 6.449219 23 7 C 23 7.550781 23.449219 8 24 8 C 24.550781 8 25 7.550781 25 7 C 25 6.449219 24.550781 6 24 6 Z M 15 11 C 16.738281 11 17.910156 11.480469 18.6875 12 L 11.3125 12 C 12.089844 11.480469 13.261719 11 15 11 Z M 10 14 L 20 14 L 20 28 L 10 28 Z M 15 18 C 13.355469 18 12 19.355469 12 21 C 12 22.644531 13.355469 24 15 24 C 16.644531 24 18 22.644531 18 21 C 18 19.355469 16.644531 18 15 18 Z M 15 20 C 15.5625 20 16 20.4375 16 21 C 16 21.5625 15.5625 22 15 22 C 14.4375 22 14 21.5625 14 21 C 14 20.4375 14.4375 20 15 20 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
