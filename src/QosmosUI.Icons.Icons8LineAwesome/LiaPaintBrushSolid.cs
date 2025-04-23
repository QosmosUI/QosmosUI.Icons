// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaPaintBrushSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 24.8125 4.03125 C 23.976563 4.03125 23.132813 4.367188 22.5 5 L 9.8125 17.5 L 9.1875 18.09375 C 8.4375 18.234375 7.722656 18.601563 7.15625 19.21875 C 6.324219 20.128906 6.160156 21.242188 5.84375 22.4375 C 5.527344 23.632813 5.125 24.964844 4.15625 26.4375 L 3.15625 28 L 5 28 C 8.914063 28 11.496094 26.128906 12.8125 24.8125 L 12.84375 24.78125 C 13.445313 24.164063 13.78125 23.386719 13.90625 22.59375 L 14.40625 22.125 L 27.09375 9.625 L 27.09375 9.59375 C 28.359375 8.328125 28.359375 6.265625 27.09375 5 C 26.460938 4.367188 25.648438 4.03125 24.8125 4.03125 Z M 24.8125 6 C 25.125 6 25.421875 6.140625 25.6875 6.40625 C 26.222656 6.941406 26.222656 7.652344 25.6875 8.1875 L 16.65625 17.125 L 14.84375 15.3125 L 23.90625 6.40625 C 24.171875 6.140625 24.5 6 24.8125 6 Z M 13.40625 16.71875 L 15.21875 18.53125 L 13.71875 20 L 11.90625 18.1875 Z M 9.96875 20.03125 C 10.472656 20.046875 11.019531 20.242188 11.4375 20.625 C 12.214844 21.335938 12.234375 22.578125 11.40625 23.40625 C 10.539063 24.273438 9 25.390625 6.75 25.8125 C 7.230469 24.761719 7.566406 23.78125 7.78125 22.96875 C 8.113281 21.714844 8.359375 20.855469 8.625 20.5625 C 8.972656 20.183594 9.464844 20.015625 9.96875 20.03125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
