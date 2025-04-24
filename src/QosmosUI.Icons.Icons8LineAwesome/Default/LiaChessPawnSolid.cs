// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaChessPawnSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 9 C 13.800781 9 12 10.800781 12 13 C 12 14.199219 12.558594 15.265625 13.40625 16 L 12 16 C 11.96875 16 11.9375 16 11.90625 16 C 11.355469 16.027344 10.925781 16.496094 10.953125 17.046875 C 10.980469 17.597656 11.449219 18.027344 12 18 L 12.5 18 L 11.09375 21.5625 L 10.375 23 L 9 23 C 8.96875 23 8.9375 23 8.90625 23 C 8.433594 23.03125 8.050781 23.386719 7.980469 23.855469 C 7.914063 24.320313 8.183594 24.773438 8.625 24.9375 L 7.28125 26.28125 L 7 26.59375 L 7 29 L 25 29 L 25 26.59375 L 24.71875 26.28125 L 23.375 24.9375 C 23.832031 24.765625 24.101563 24.289063 24.007813 23.808594 C 23.917969 23.328125 23.488281 22.988281 23 23 L 21.625 23 L 20.90625 21.5625 L 19.5 18 L 20 18 C 20.359375 18.003906 20.695313 17.816406 20.878906 17.503906 C 21.058594 17.191406 21.058594 16.808594 20.878906 16.496094 C 20.695313 16.183594 20.359375 15.996094 20 16 L 18.59375 16 C 19.441406 15.265625 20 14.199219 20 13 C 20 10.800781 18.199219 9 16 9 Z M 16 11 C 17.117188 11 18 11.882813 18 13 C 18 14.117188 17.117188 15 16 15 C 14.882813 15 14 14.117188 14 13 C 14 11.882813 14.882813 11 16 11 Z M 14.6875 18 L 17.3125 18 L 19.0625 22.375 L 19.09375 22.40625 L 19.09375 22.4375 L 19.375 23 L 12.625 23 L 12.90625 22.4375 L 12.90625 22.40625 L 12.9375 22.375 Z M 11.4375 25 L 20.5625 25 L 22.5625 27 L 9.4375 27 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
