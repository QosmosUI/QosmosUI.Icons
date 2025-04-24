// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaDraftingCompassSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 15 3 L 15 6.15625 C 13.28125 6.601563 12 8.148438 12 10 C 12 11.046875 12.425781 12 13.09375 12.71875 L 9.75 20 L 6 20 L 6 22 L 8.8125 22 L 5.96875 28.1875 L 7.78125 29.03125 L 11.03125 22 L 15 22 L 15 24 L 17 24 L 17 22 L 20.96875 22 L 24.1875 29.03125 L 26 28.21875 L 23.15625 22 L 26 22 L 26 20 L 22.25 20 L 18.90625 12.6875 C 19.566406 11.976563 20 11.042969 20 10 C 20 8.148438 18.71875 6.601563 17 6.15625 L 17 3 Z M 16 8 C 17.117188 8 18 8.882813 18 10 C 18 10.582031 17.765625 11.101563 17.375 11.46875 L 17.34375 11.5 L 16.34375 11.9375 L 20.03125 20 L 17 20 L 17 18 L 15 18 L 15 20 L 11.9375 20 L 15.625 12 L 14.625 11.53125 L 14.65625 11.5 C 14.242188 11.132813 14 10.601563 14 10 C 14 8.882813 14.882813 8 16 8 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
