// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaMenorahSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 4 5 C 4 5 3 7.015625 3 8 C 3 8.550781 3.449219 9 4 9 C 4.550781 9 5 8.550781 5 8 C 5 7.0625 4 5 4 5 Z M 8 5 C 8 5 7 7.015625 7 8 C 7 8.550781 7.449219 9 8 9 C 8.550781 9 9 8.550781 9 8 C 9 7.0625 8 5 8 5 Z M 12 5 C 12 5 11 7.015625 11 8 C 11 8.550781 11.449219 9 12 9 C 12.550781 9 13 8.550781 13 8 C 13 7.0625 12 5 12 5 Z M 16 5 C 16 5 15 7.015625 15 8 C 15 8.550781 15.449219 9 16 9 C 16.550781 9 17 8.550781 17 8 C 17 7.0625 16 5 16 5 Z M 20 5 C 20 5 19 7.015625 19 8 C 19 8.550781 19.449219 9 20 9 C 20.550781 9 21 8.550781 21 8 C 21 7.0625 20 5 20 5 Z M 24 5 C 24 5 23 7.015625 23 8 C 23 8.550781 23.449219 9 24 9 C 24.550781 9 25 8.550781 25 8 C 25 7.0625 24 5 24 5 Z M 28 5 C 28 5 27 7.015625 27 8 C 27 8.550781 27.449219 9 28 9 C 28.550781 9 29 8.550781 29 8 C 29 7.0625 28 5 28 5 Z M 3 10 C 3 16.804688 8.320313 22.414063 15 22.9375 L 15 25 L 10 25 L 10 27 L 22 27 L 22 25 L 17 25 L 17 22.9375 C 23.679688 22.414063 29 16.804688 29 10 L 27 10 C 27 15.71875 22.589844 20.429688 17 20.9375 L 17 18.9375 C 21.476563 18.429688 25 14.605469 25 10 L 23 10 C 23 13.515625 20.382813 16.417969 17 16.90625 L 17 14.90625 C 19.269531 14.4375 21 12.402344 21 10 L 19 10 C 19 11.300781 18.15625 12.394531 17 12.8125 L 17 10 L 15 10 L 15 12.8125 C 13.84375 12.394531 13 11.300781 13 10 L 11 10 C 11 12.402344 12.730469 14.4375 15 14.90625 L 15 16.90625 C 11.617188 16.417969 9 13.515625 9 10 L 7 10 C 7 14.605469 10.523438 18.429688 15 18.9375 L 15 20.9375 C 9.410156 20.429688 5 15.71875 5 10 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
