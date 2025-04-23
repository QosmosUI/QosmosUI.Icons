// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaFillSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 11.3125 3.28125 L 9.90625 4.71875 L 11.6875 6.5 L 4.78125 13.40625 C 3.597656 14.589844 3.597656 16.535156 4.78125 17.71875 L 4.84375 17.78125 L 11.1875 24.09375 C 12.371094 25.277344 14.316406 25.277344 15.5 24.09375 L 23.09375 16.5 L 23.8125 15.8125 L 14.09375 6.09375 L 13.3125 5.28125 L 13.09375 5.09375 Z M 13.125 7.9375 L 21 15.8125 L 14.09375 22.6875 C 13.675781 23.105469 13.011719 23.105469 12.59375 22.6875 L 6.21875 16.28125 C 5.800781 15.863281 5.800781 15.230469 6.21875 14.8125 Z M 25 19.25 L 24.1875 20.4375 C 24.1875 20.4375 23.648438 21.191406 23.125 22.09375 C 22.863281 22.546875 22.617188 23.019531 22.40625 23.5 C 22.195313 23.980469 22 24.421875 22 25 C 22 26.644531 23.355469 28 25 28 C 26.644531 28 28 26.644531 28 25 C 28 24.421875 27.804688 23.980469 27.59375 23.5 C 27.382813 23.019531 27.136719 22.546875 26.875 22.09375 C 26.351563 21.191406 25.8125 20.4375 25.8125 20.4375 Z M 25 22.875 C 25.066406 22.984375 25.058594 22.976563 25.125 23.09375 C 25.363281 23.503906 25.617188 23.941406 25.78125 24.3125 C 25.945313 24.683594 26 25.027344 26 25 C 26 25.554688 25.554688 26 25 26 C 24.445313 26 24 25.554688 24 25 C 24 25.027344 24.054688 24.683594 24.21875 24.3125 C 24.382813 23.941406 24.636719 23.503906 24.875 23.09375 C 24.941406 22.976563 24.933594 22.984375 25 22.875 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
