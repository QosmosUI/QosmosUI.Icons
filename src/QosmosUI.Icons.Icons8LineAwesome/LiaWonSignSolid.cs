// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaWonSignSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 4 6 L 5.8125 12 L 4 12 L 4 14 L 6.40625 14 L 7 16 L 4 16 L 4 18 L 7.59375 18 L 10 26 L 12 26 L 14 18 L 18 18 L 20 26 L 22 26 L 24.40625 18 L 28 18 L 28 16 L 25 16 L 25.59375 14 L 28 14 L 28 12 L 26.1875 12 L 28 6 L 26 6 L 24.1875 12 L 18.5 12 L 17 6 L 15 6 L 13.5 12 L 7.8125 12 L 6 6 Z M 16 10 L 16.5 12 L 15.5 12 Z M 8.40625 14 L 13 14 L 12.5 16 L 9 16 Z M 15 14 L 17 14 L 17.5 16 L 14.5 16 Z M 19 14 L 23.59375 14 L 23 16 L 19.5 16 Z M 9.59375 18 L 12 18 L 10.90625 22.375 Z M 20 18 L 22.40625 18 L 21.09375 22.375 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
