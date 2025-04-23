// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaSatelliteDishSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16.5 4.5 L 16.5 6.5 C 21.484375 6.5 25.5 10.515625 25.5 15.5 L 27.5 15.5 C 27.5 9.4375 22.5625 4.5 16.5 4.5 Z M 16.5 8.5 L 16.5 10.5 C 19.273438 10.5 21.5 12.726563 21.5 15.5 L 23.5 15.5 C 23.5 11.644531 20.355469 8.5 16.5 8.5 Z M 7.90625 8.59375 L 7.21875 9.28125 C 2.949219 13.550781 2.949219 20.511719 7.21875 24.78125 C 11.488281 29.050781 18.449219 29.050781 22.71875 24.78125 L 23.40625 24.09375 L 22.71875 23.375 L 17.21875 17.875 C 18.242188 17.5625 19 16.628906 19 15.5 C 19 14.121094 17.878906 13 16.5 13 C 15.371094 13 14.4375 13.757813 14.125 14.78125 L 8.625 9.28125 Z M 8.0625 11.5625 L 20.4375 23.9375 C 16.917969 26.730469 11.882813 26.632813 8.625 23.375 C 5.367188 20.117188 5.269531 15.082031 8.0625 11.5625 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
