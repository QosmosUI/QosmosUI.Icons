// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaItalicSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 11.75 5 L 11.6875 5.9375 L 11.5 8.9375 L 11.4375 10 L 13.4375 10 L 12.5625 22 L 10.5625 22 L 10.5 22.9375 L 10.3125 25.9375 L 10.21875 27 L 20.25 27 L 20.3125 26.0625 L 20.5 23.0625 L 20.5625 22 L 18.5625 22 L 19.4375 10 L 21.4375 10 L 21.5 9.0625 L 21.6875 6.0625 L 21.78125 5 Z M 13.625 7 L 19.625 7 L 19.5625 8 L 17.5625 8 L 17.5 8.9375 L 16.5 22.9375 L 16.4375 24 L 18.4375 24 L 18.375 25 L 12.375 25 L 12.4375 24 L 14.4375 24 L 14.5 23.0625 L 15.5 9.0625 L 15.5625 8 L 13.5625 8 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
