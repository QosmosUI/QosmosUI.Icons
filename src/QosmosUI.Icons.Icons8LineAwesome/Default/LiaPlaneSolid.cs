// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPlaneSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 3 C 14.355469 3 13 4.355469 13 6 L 13 13.34375 L 4.59375 17.09375 L 4 17.34375 L 4 22.125 L 13 21.125 L 13 22.96875 L 10.4375 24.6875 L 10 24.96875 L 10 29.21875 L 11.1875 28.96875 L 16 28 L 20.8125 28.96875 L 22 29.21875 L 22 24.96875 L 21.5625 24.6875 L 19 22.96875 L 19 21.125 L 28 22.125 L 28 17.34375 L 27.40625 17.09375 L 19 13.34375 L 19 6 C 19 4.355469 17.644531 3 16 3 Z M 16 5 C 16.566406 5 17 5.433594 17 6 L 17 14.65625 L 17.59375 14.90625 L 26 18.65625 L 26 19.875 L 17 18.875 L 17 24.0625 L 17.4375 24.34375 L 20 26.0625 L 20 26.78125 L 16.1875 26.03125 L 16 25.96875 L 15.8125 26.03125 L 12 26.78125 L 12 26.0625 L 14.5625 24.34375 L 15 24.0625 L 15 18.875 L 6 19.875 L 6 18.65625 L 14.40625 14.90625 L 15 14.65625 L 15 6 C 15 5.433594 15.433594 5 16 5 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
