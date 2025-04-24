// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaCubesSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 L 15.625 4.15625 L 9.625 6.5625 L 9 6.8125 L 9 13.53125 L 3.59375 15.875 L 3 16.15625 L 3 24.21875 L 3.5 24.53125 L 9.5 27.875 L 9.96875 28.125 L 10.4375 27.90625 L 16 25.125 L 21.5625 27.90625 L 22.03125 28.125 L 22.5 27.875 L 28.5 24.53125 L 29 24.21875 L 29 16.15625 L 28.40625 15.875 L 23 13.53125 L 23 6.8125 L 22.375 6.5625 L 16.375 4.15625 Z M 16 6.1875 L 19.28125 7.46875 L 16 8.75 L 12.71875 7.46875 Z M 11 8.9375 L 15 10.46875 L 15 15.34375 L 11 13.5625 Z M 21 8.9375 L 21 13.5625 L 17 15.34375 L 17 10.46875 Z M 10 15.3125 L 13.625 16.90625 L 10 18.6875 L 6.375 16.875 Z M 22 15.3125 L 25.625 16.875 L 22 18.6875 L 18.375 16.90625 L 19.5 16.40625 Z M 5 18.40625 L 9 20.40625 L 9 25.3125 L 5 23.0625 Z M 27 18.40625 L 27 23.0625 L 23 25.3125 L 23 20.40625 Z M 15 18.46875 L 15 23.375 L 11 25.375 L 11 20.40625 Z M 17 18.46875 L 21 20.40625 L 21 25.375 L 17 23.375 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
