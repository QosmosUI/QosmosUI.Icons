// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaChurchSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 15 3 L 15 5 L 13 5 L 13 7 L 15 7 L 15 9.5625 L 11.28125 13.28125 L 11 13.59375 L 11 17.40625 L 4.5 21.125 L 5.5 22.875 L 7 22.03125 L 7 29 L 15 29 L 15 25 C 15 24.445313 15.445313 24 16 24 C 16.554688 24 17 24.445313 17 25 L 17 29 L 25 29 L 25 22.03125 L 26.5 22.875 L 27.5 21.125 L 21 17.40625 L 21 13.59375 L 20.71875 13.28125 L 17 9.5625 L 17 7 L 19 7 L 19 5 L 17 5 L 17 3 Z M 16 11.4375 L 19 14.4375 L 19 18.59375 L 19.5 18.875 L 23 20.875 L 23 27 L 19 27 L 19 25 C 19 23.355469 17.644531 22 16 22 C 14.355469 22 13 23.355469 13 25 L 13 27 L 9 27 L 9 20.875 L 12.5 18.875 L 13 18.59375 L 13 14.4375 Z M 16 15 C 15.449219 15 15 15.449219 15 16 L 15 19 L 17 19 L 17 16 C 17 15.449219 16.550781 15 16 15 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
