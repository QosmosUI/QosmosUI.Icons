// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaOsi : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 C 9.382813 4 4 9.382813 4 16 C 4 21.125 7.214844 25.503906 11.75 27.21875 L 12.6875 27.59375 L 13.0625 26.65625 L 15.53125 20.09375 L 15.875 19.15625 L 14.9375 18.8125 C 13.804688 18.382813 13 17.292969 13 16 C 13 14.332031 14.332031 13 16 13 C 17.667969 13 19 14.332031 19 16 C 19 17.292969 18.195313 18.382813 17.0625 18.8125 L 16.125 19.15625 L 16.46875 20.09375 L 18.9375 26.65625 L 19.3125 27.59375 L 20.25 27.21875 C 24.785156 25.503906 28 21.125 28 16 C 28 9.382813 22.617188 4 16 4 Z M 16 6 C 21.535156 6 26 10.464844 26 16 C 26 19.921875 23.683594 23.203125 20.40625 24.84375 L 18.59375 20.0625 C 19.976563 19.171875 21 17.757813 21 16 C 21 13.25 18.75 11 16 11 C 13.25 11 11 13.25 11 16 C 11 17.757813 12.023438 19.171875 13.40625 20.0625 L 11.59375 24.84375 C 8.316406 23.203125 6 19.921875 6 16 C 6 10.464844 10.464844 6 16 6 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
