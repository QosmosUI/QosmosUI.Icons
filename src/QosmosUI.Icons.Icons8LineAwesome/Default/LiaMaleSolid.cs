// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaMaleSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 2 C 13.800781 2 12 3.800781 12 6 C 12 7.066406 12.433594 8.03125 13.125 8.75 C 11.273438 9.773438 10 11.746094 10 14 L 10 19.40625 L 10.28125 19.71875 L 12 21.4375 L 12 30 L 14 30 L 14 20.59375 L 13.71875 20.28125 L 12 18.5625 L 12 14 C 12 11.78125 13.78125 10 16 10 C 18.21875 10 20 11.78125 20 14 L 20 18.5625 L 18.28125 20.28125 L 18 20.59375 L 18 30 L 20 30 L 20 21.4375 L 21.71875 19.71875 L 22 19.40625 L 22 14 C 22 11.746094 20.726563 9.773438 18.875 8.75 C 19.566406 8.03125 20 7.066406 20 6 C 20 3.800781 18.199219 2 16 2 Z M 16 4 C 17.117188 4 18 4.882813 18 6 C 18 7.117188 17.117188 8 16 8 C 14.882813 8 14 7.117188 14 6 C 14 4.882813 14.882813 4 16 4 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
