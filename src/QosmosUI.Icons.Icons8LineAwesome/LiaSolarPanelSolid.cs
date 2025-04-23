// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaSolarPanelSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 15 4 L 15 6.59375 L 13.1875 4.8125 L 11.8125 6.1875 L 13.59375 8 L 11 8 L 11 10 L 13.59375 10 L 11.8125 11.8125 L 13.1875 13.1875 L 15 11.40625 L 15 14 L 17 14 L 17 11.40625 L 18.8125 13.1875 L 20.1875 11.8125 L 18.40625 10 L 21 10 L 21 8 L 18.40625 8 L 20.1875 6.1875 L 18.8125 4.8125 L 17 6.59375 L 17 4 Z M 16 7 C 17.101563 7 18 7.898438 18 9 C 18 10.101563 17.101563 11 16 11 C 14.898438 11 14 10.101563 14 9 C 14 7.898438 14.898438 7 16 7 Z M 6.21875 16 L 4 24.875 L 4 28 L 28 28 L 28 24.875 L 25.78125 16 Z M 7.78125 18 L 24.21875 18 L 26 25.125 L 26 26 L 6 26 L 6 25.125 Z M 9 19 L 8.59375 20.8125 L 10.6875 20.8125 L 11 19 Z M 13 19 L 12.8125 20.8125 L 14.90625 20.8125 L 15 19 Z M 17 19 L 17.09375 20.8125 L 19.1875 20.8125 L 19 19 Z M 21 19 L 21.3125 20.8125 L 23.40625 20.8125 L 23 19 Z M 8.1875 22.8125 L 7.8125 25 L 10.09375 25 L 10.40625 22.8125 Z M 12.6875 22.8125 L 12.5 25 L 14.8125 25 L 14.90625 22.8125 Z M 17.09375 22.8125 L 17.1875 25 L 19.5 25 L 19.3125 22.8125 Z M 21.59375 22.8125 L 21.90625 25 L 24.1875 25 L 23.8125 22.8125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
