// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaFireExtinguisherSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 C 14.707031 4 13.605469 4.84375 13.1875 6 L 12 6 C 9.253906 6 7 8.253906 7 11 L 9 11 C 9 9.34375 10.34375 8 12 8 L 13 8 L 13 10.46875 C 12.679688 10.707031 12.265625 11.046875 11.78125 11.53125 C 10.953125 12.359375 10 13.5 10 15 L 10 28 L 22 28 L 22 15 C 22 13.5 21.046875 12.359375 20.21875 11.53125 C 19.734375 11.046875 19.320313 10.707031 19 10.46875 L 19 10.1875 L 23.84375 11 L 25 11.1875 L 25 4.8125 L 23.84375 5 L 18.75 5.84375 C 18.292969 4.769531 17.234375 4 16 4 Z M 16 6 C 16.554688 6 17 6.445313 17 7 L 17 10 L 15 10 L 15 7 C 15 6.445313 15.445313 6 16 6 Z M 23 7.1875 L 23 8.8125 L 19 8.125 L 19 7.875 Z M 14.375 12 L 17.625 12 C 17.777344 12.105469 18.203125 12.390625 18.78125 12.96875 C 19.453125 13.640625 20 14.5 20 15 L 20 26 L 12 26 L 12 15 C 12 14.5 12.546875 13.640625 13.21875 12.96875 C 13.796875 12.390625 14.222656 12.105469 14.375 12 Z M 14 17 L 14 19 L 18 19 L 18 17 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
