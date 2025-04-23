// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaGlobeAsiaSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 C 9.382813 4 4 9.382813 4 16 C 4 22.617188 9.382813 28 16 28 C 22.617188 28 28 22.617188 28 16 C 28 9.382813 22.617188 4 16 4 Z M 16.40625 6.03125 C 17.367188 6.070313 18.285156 6.210938 19.15625 6.5 L 18.6875 7.15625 L 19.0625 7.9375 L 18.5625 8.9375 L 20.6875 9.21875 L 21.46875 12.84375 L 23.1875 15.1875 L 24.71875 16.15625 L 24.125 14.5 L 24.6875 13.8125 L 25.84375 14.125 C 25.957031 14.730469 26 15.363281 26 16 C 26 16.148438 25.976563 16.292969 25.96875 16.4375 L 25.875 16.25 L 24.90625 16.65625 L 24.65625 17.28125 L 24.125 17.46875 L 24.3125 19.09375 L 24.71875 19.6875 L 24.4375 20.46875 L 22.9375 22.84375 L 22.8125 23.3125 C 21.027344 24.972656 18.640625 26 16 26 C 12.933594 26 10.207031 24.628906 8.375 22.46875 L 6.96875 19 L 7.78125 17.625 L 6.5625 16.9375 L 7.9375 16.28125 L 8 15.53125 L 7.59375 14.46875 L 8.375 14.5625 L 9.15625 15.75 L 9.875 16.09375 L 9.65625 15.28125 L 10.40625 14.53125 L 11.625 15.40625 L 12.28125 14.875 L 12 13.5 L 12.96875 12.125 L 12.84375 10.75 L 14.03125 10.03125 L 13.21875 8.03125 L 15.46875 7.90625 L 16.71875 6.3125 Z M 15 15.59375 L 12.34375 17.59375 L 12.53125 20.09375 L 13.21875 20.6875 L 14.75 19.875 L 15.53125 20.09375 L 16.875 21.53125 L 17.6875 21.3125 L 18.53125 19.3125 L 18 17.9375 L 16.9375 15.875 L 16.15625 17.125 Z M 20 19.8125 L 19.8125 19.875 L 19.75 21.15625 L 19.3125 21.75 L 19.8125 22.21875 L 20.4375 21.5 Z M 18.90625 22.25 L 17.625 23.71875 L 17.96875 24.09375 L 19.46875 22.65625 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
