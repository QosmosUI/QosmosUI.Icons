// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaRedhat : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16.388672 6.0019531 C 15.611672 6.0019531 15.385172 7.0820312 14.451172 7.0820312 C 13.546172 7.0820312 12.888969 6.2714844 12.042969 6.2714844 C 11.235969 6.2714844 10.713547 6.8640313 10.310547 8.0820312 C 8.9335469 12.245031 8.9939063 12.068109 9.0039062 12.287109 C 9.0039063 13.619109 13.881156 17.990234 20.410156 17.990234 L 20.410156 18 C 22.091156 18 24.519531 17.624703 24.519531 15.470703 C 24.539531 15.106703 24.569516 15.377781 23.478516 10.300781 C 23.252516 9.2697812 23.045047 8.80125 21.373047 7.90625 C 20.065047 7.18725 17.224672 6.0019531 16.388672 6.0019531 z M 8.2695312 13.039062 C 5.9695313 13.149063 3 13.570234 3 16.240234 C 3 20.610234 13.189766 26 21.259766 26 C 27.439766 26 29 23.160156 29 20.910156 C 29 19.140156 27.499063 17.139453 24.789062 15.939453 C 25.020063 17.177453 25 17.558703 25 17.720703 C 25 19.827703 22.844813 21 20.007812 21 C 13.612813 21.011 8 16.873437 8 14.148438 C 8 13.768437 8.1295313 13.387063 8.2695312 13.039062 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
