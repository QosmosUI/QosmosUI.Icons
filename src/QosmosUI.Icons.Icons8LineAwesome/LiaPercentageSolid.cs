// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaPercentageSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 Z M 7 7 L 25 7 L 25 25 L 7 25 Z M 12 9 C 10.355469 9 9 10.355469 9 12 L 9 13 C 9 14.644531 10.355469 16 12 16 C 13.644531 16 15 14.644531 15 13 L 15 12 C 15 10.355469 13.644531 9 12 9 Z M 19.59375 9 L 10 23 L 12.40625 23 L 22 9 Z M 12 11 C 12.566406 11 13 11.433594 13 12 L 13 13 C 13 13.566406 12.566406 14 12 14 C 11.433594 14 11 13.566406 11 13 L 11 12 C 11 11.433594 11.433594 11 12 11 Z M 20 16 C 18.355469 16 17 17.355469 17 19 L 17 20 C 17 21.644531 18.355469 23 20 23 C 21.644531 23 23 21.644531 23 20 L 23 19 C 23 17.355469 21.644531 16 20 16 Z M 20 18 C 20.566406 18 21 18.433594 21 19 L 21 20 C 21 20.566406 20.566406 21 20 21 C 19.433594 21 19 20.566406 19 20 L 19 19 C 19 18.433594 19.433594 18 20 18 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
