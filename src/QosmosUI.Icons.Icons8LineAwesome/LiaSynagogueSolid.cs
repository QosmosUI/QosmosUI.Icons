// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaSynagogueSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4.65625 L 15.34375 5.25 L 7.625 12 L 4 12 L 4 27 L 14 27 L 14 23 C 14 21.882813 14.882813 21 16 21 C 17.117188 21 18 21.882813 18 23 L 18 27 L 28 27 L 28 12 L 24.375 12 L 16.65625 5.25 Z M 6 7 C 5.417969 7.875 4 8.007813 4 9.65625 C 4 10.582031 4.65625 11 4.65625 11 L 7.34375 11 C 7.34375 11 8 10.582031 8 9.65625 C 8 7.921875 6.65625 7.847656 6 7 Z M 26 7 C 25.417969 7.875 24 8.5 24 9.65625 C 24 10.582031 24.65625 11 24.65625 11 L 27.34375 11 C 27.34375 11 28 10.582031 28 9.65625 C 28 8.414063 26.65625 7.847656 26 7 Z M 16 7.3125 L 23.34375 13.75 L 23.625 14 L 26 14 L 26 25 L 20 25 L 20 23 C 20 20.800781 18.199219 19 16 19 C 13.800781 19 12 20.800781 12 23 L 12 25 L 6 25 L 6 14 L 8.375 14 L 8.65625 13.75 Z M 16 11.46875 L 15.125 12.96875 L 13.40625 12.96875 L 14.25 14.46875 L 13.40625 15.96875 L 15.125 15.96875 L 16 17.5 L 16.875 15.96875 L 18.59375 15.96875 L 17.75 14.46875 L 18.59375 12.96875 L 16.875 12.96875 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
