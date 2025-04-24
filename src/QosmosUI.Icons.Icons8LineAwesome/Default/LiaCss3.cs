// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaCss3 : ComponentBase
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
		builder.AddAttribute(14, "d", "M 8.21875 5 L 8.0625 5.8125 L 7.5625 8.6875 L 7.34375 9.875 L 21.46875 9.875 L 21.15625 11.6875 L 7.03125 11.6875 L 6.875 12.5 L 6.375 15.375 L 6.15625 16.53125 L 20.28125 16.53125 L 19.5625 20.59375 L 14.34375 23 L 10.25 20.75 L 10.46875 19.53125 L 10.6875 18.375 L 5.8125 18.375 L 5.6875 19.1875 L 5 23 L 4.84375 23.75 L 5.53125 24.09375 L 13.34375 27.90625 L 13.75 28.09375 L 14.15625 27.9375 L 23.3125 24.09375 L 23.8125 23.90625 L 23.9375 23.34375 L 27 6.1875 L 27.21875 5 Z M 9.875 7 L 24.8125 7 L 22.0625 22.46875 L 13.78125 25.875 L 7.09375 22.625 L 7.5 20.375 L 8.28125 20.375 L 8.03125 21.8125 L 8.65625 22.15625 L 13.8125 25 L 14.25 25.25 L 14.71875 25.03125 L 20.875 22.1875 L 21.34375 21.96875 L 21.4375 21.4375 L 22.46875 15.71875 L 22.6875 14.53125 L 8.5625 14.53125 L 8.6875 13.6875 L 22.84375 13.6875 L 22.96875 12.84375 L 23.65625 9.03125 L 23.875 7.875 L 9.75 7.875 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
