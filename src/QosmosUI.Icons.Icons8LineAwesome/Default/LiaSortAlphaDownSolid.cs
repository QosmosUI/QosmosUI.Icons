// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaSortAlphaDownSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 8.1875 5 L 7.96875 5.65625 L 6.03125 11 L 6 11 L 6 11.0625 L 5.0625 13.65625 L 5 13.8125 L 5 15 L 7 15 L 7 14.15625 L 7.40625 13 L 10.59375 13 L 11 14.15625 L 11 15 L 13 15 L 13 13.8125 L 12.9375 13.65625 L 12 11.0625 L 12 11 L 11.96875 11 L 10.03125 5.65625 L 9.8125 5 Z M 22 5 L 22 23.6875 L 19.40625 21.09375 L 18 22.5 L 22.28125 26.8125 L 23 27.5 L 23.71875 26.8125 L 28 22.5 L 26.59375 21.09375 L 24 23.6875 L 24 5 Z M 9 8.65625 L 9.84375 11 L 8.15625 11 Z M 5 17 L 5 19 L 10.5625 19 L 5.28125 24.28125 L 5 24.59375 L 5 27 L 13 27 L 13 25 L 7.4375 25 L 12.71875 19.71875 L 13 19.40625 L 13 17 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
