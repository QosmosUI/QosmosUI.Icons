// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaDollarSignSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 15 3 L 15 5.09375 C 12.164063 5.570313 10 8.050781 10 11 C 10 12.777344 10.832031 14.148438 11.9375 15.03125 C 13.042969 15.914063 14.375 16.40625 15.625 16.90625 C 16.875 17.40625 18.042969 17.914063 18.8125 18.53125 C 19.582031 19.148438 20 19.773438 20 21 C 20 23.15625 18.207031 25 16 25 C 13.78125 25 12 23.21875 12 21 L 12 20 L 10 20 L 10 21 C 10 23.964844 12.164063 26.429688 15 26.90625 L 15 29 L 17 29 L 17 26.90625 C 19.84375 26.425781 22 23.925781 22 21 C 22 19.21875 21.167969 17.855469 20.0625 16.96875 C 18.957031 16.082031 17.625 15.5625 16.375 15.0625 C 15.125 14.5625 13.957031 14.082031 13.1875 13.46875 C 12.417969 12.855469 12 12.21875 12 11 C 12 8.808594 13.785156 7 16 7 C 18.21875 7 20 8.78125 20 11 L 20 12 L 22 12 L 22 11 C 22 8.035156 19.835938 5.570313 17 5.09375 L 17 3 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
