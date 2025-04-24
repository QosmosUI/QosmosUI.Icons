// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaTransgenderAltSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 4 4 L 4 11 L 6 11 L 6 7.40625 L 9.0625 10.5 L 7.28125 12.28125 L 8.71875 13.71875 L 10.5 11.9375 L 11.8125 13.25 C 11.285156 14.042969 11 14.984375 11 16 C 11 18.40625 12.726563 20.4375 15 20.90625 L 15 23 L 12 23 L 12 25 L 15 25 L 15 28 L 17 28 L 17 25 L 20 25 L 20 23 L 17 23 L 17 20.90625 C 19.273438 20.4375 21 18.40625 21 16 C 21 14.984375 20.714844 14.042969 20.1875 13.25 L 26 7.40625 L 26 11 L 28 11 L 28 4 L 21 4 L 21 6 L 24.59375 6 L 18.75 11.8125 C 17.957031 11.285156 17.015625 11 16 11 C 14.984375 11 14.042969 11.285156 13.25 11.8125 L 11.9375 10.5 L 13.71875 8.71875 L 12.28125 7.28125 L 10.5 9.0625 L 7.40625 6 L 11 6 L 11 4 Z M 16 13 C 17.667969 13 19 14.332031 19 16 C 19 17.667969 17.667969 19 16 19 C 14.332031 19 13 17.667969 13 16 C 13 14.332031 14.332031 13 16 13 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
