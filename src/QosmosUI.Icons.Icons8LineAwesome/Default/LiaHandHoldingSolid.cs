// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaHandHoldingSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 10.515625 18 C 9.484625 18.004 8.6992188 18.265625 8.6992188 18.265625 L 8.6796875 18.273438 L 3.0078125 20.449219 L 4.9921875 26.019531 L 9.921875 24.128906 L 17.058594 28.058594 L 29.382812 22.953125 L 28.617188 21.109375 L 17.179688 25.84375 L 10.078125 21.933594 L 6.1875 23.421875 L 5.546875 21.615234 L 9.34375 20.158203 C 9.35275 20.155203 9.819625 20 10.515625 20 C 11.218625 20 12.038281 20.156062 12.738281 20.789062 L 12.751953 20.796875 L 12.755859 20.800781 C 13.786859 21.695781 14.564484 22.321156 15.646484 22.660156 C 16.728484 23.000156 17.955859 23.03925 20.005859 23.03125 L 19.996094 21.03125 C 17.984094 21.03925 16.933094 20.968 16.246094 20.75 C 15.558094 20.539 15.070125 20.159781 14.078125 19.300781 L 14.066406 19.292969 C 12.909406 18.253969 11.534625 17.996 10.515625 18 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
