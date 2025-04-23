// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaFortAwesomeAlt : ComponentBase
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
		builder.AddAttribute(14, "d", "M 15.5 3 C 8.607 3 3 8.607 3 15.5 C 3 22.393 8.607 28 15.5 28 C 22.393 28 28 22.393 28 15.5 C 28 8.607 22.393 3 15.5 3 z M 15.5 5 C 21.29 5 26 9.71 26 15.5 C 26 21.29 21.29 26 15.5 26 C 9.71 26 5 21.29 5 15.5 C 5 9.71 9.71 5 15.5 5 z M 15 8 L 15 12 L 15 13 L 14 13 L 14 12 L 13 12 L 13 13 L 12 13 L 12 12 L 11 12 L 11 18 L 9 18 L 9 17 L 8 17 L 8 18 L 8 19.490234 C 9.206 21.746234 11.4 23.393375 14 23.859375 L 14 20.5 C 14 19.675 14.675 19 15.5 19 C 16.325 19 17 19.675 17 20.5 L 17 23.859375 C 19.6 23.394375 21.794 21.747234 23 19.490234 L 23 18 L 23 17 L 22 17 L 22 18 L 20 18 L 20 12 L 19 12 L 19 13 L 18 13 L 18 12 L 17 12 L 17 13 L 16 13 L 16 12 L 16 10 C 16 10 16.390391 9.7695312 16.900391 9.7695312 C 17.400391 9.7695312 17.679844 10 18.089844 10 C 18.639844 10 19 9.7695312 19 9.7695312 L 19 8 C 19 8 18.639844 8.2304688 18.089844 8.2304688 C 17.679844 8.2304688 17.400391 8 16.900391 8 C 16.390391 8 16 8.2304688 16 8.2304688 L 16 8 L 15 8 z M 13 15 L 14 15 L 14 17 L 13 17 L 13 15 z M 17 15 L 18 15 L 18 17 L 17 17 L 17 15 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
