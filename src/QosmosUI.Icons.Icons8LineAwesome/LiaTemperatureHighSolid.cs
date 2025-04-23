// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaTemperatureHighSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 9 4 L 9 15.46875 C 7.25 16.73775 6 18.676 6 21 C 6 24.855 9.145 28 13 28 C 16.855 28 20 24.855 20 21 C 20 18.676 18.75 16.73775 17 15.46875 L 17 14 L 19 14 L 19 12 L 17 12 L 17 10 L 19 10 L 19 8 L 17 8 L 17 6 L 19 6 L 19 4 L 9 4 z M 24.5 4 C 22.57 4 21 5.57 21 7.5 C 21 9.43 22.57 11 24.5 11 C 26.43 11 28 9.43 28 7.5 C 28 5.57 26.43 4 24.5 4 z M 11 6 L 15 6 L 15 16.40625 L 15.5 16.6875 C 16.996 17.5555 18 19.148 18 21 C 18 23.773 15.773 26 13 26 C 10.227 26 8 23.773 8 21 C 8 19.148 9.004 17.5555 10.5 16.6875 L 11 16.40625 L 11 6 z M 24.5 6 C 25.327 6 26 6.673 26 7.5 C 26 8.327 25.327 9 24.5 9 C 23.673 9 23 8.327 23 7.5 C 23 6.673 23.673 6 24.5 6 z M 12 8 L 12 18.1875 C 10.84 18.6015 10 19.700953 10 21.001953 C 10 22.657953 11.344 24.001953 13 24.001953 C 14.656 24.001953 16 22.657953 16 21.001953 C 16 19.700953 15.16 18.6025 14 18.1875 L 14 8 L 12 8 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
