// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaHandMiddleFingerSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 2 C 14.355469 2 13 3.355469 13 5 L 13 10.1875 C 12.683594 10.074219 12.351563 10 12 10 C 10.355469 10 9 11.355469 9 13 L 9 16.65625 L 6.90625 19.34375 C 5.628906 20.996094 5.714844 23.367188 7.09375 24.9375 L 9.46875 27.625 C 10.796875 29.136719 12.707031 30 14.71875 30 L 20 30 C 23.855469 30 27 26.855469 27 23 L 27 14 C 27 12.355469 25.644531 11 24 11 C 23.464844 11 22.96875 11.15625 22.53125 11.40625 C 21.996094 10.5625 21.0625 10 20 10 C 19.648438 10 19.316406 10.074219 19 10.1875 L 19 5 C 19 3.355469 17.644531 2 16 2 Z M 16 4 C 16.566406 4 17 4.433594 17 5 L 17 15 L 19 15 L 19 13 C 19 12.433594 19.433594 12 20 12 C 20.566406 12 21 12.433594 21 13 L 21 15 L 23 15 L 23 14 C 23 13.433594 23.433594 13 24 13 C 24.566406 13 25 13.433594 25 14 L 25 23 C 25 25.773438 22.773438 28 20 28 L 14.71875 28 C 13.28125 28 11.917969 27.394531 10.96875 26.3125 L 8.59375 23.59375 C 7.839844 22.734375 7.800781 21.5 8.5 20.59375 L 9 19.9375 L 9 21 L 11 21 L 11 13 C 11 12.433594 11.433594 12 12 12 C 12.566406 12 13 12.433594 13 13 L 13 15 L 15 15 L 15 5 C 15 4.433594 15.433594 4 16 4 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
