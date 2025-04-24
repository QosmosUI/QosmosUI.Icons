// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaCodepen : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 2.84375 L 15.4375 3.21875 L 3.4375 11.25 L 3 11.53125 L 3 20.46875 L 3.4375 20.75 L 15.4375 28.78125 L 16 29.15625 L 16.5625 28.78125 L 28.5625 20.75 L 29 20.46875 L 29 11.53125 L 28.5625 11.25 L 16.5625 3.21875 Z M 15 5.90625 L 15 11.34375 L 9.84375 14.8125 L 5.8125 12.09375 Z M 17 5.90625 L 26.1875 12.09375 L 22.15625 14.8125 L 17 11.34375 Z M 16 13.09375 L 20.34375 16 L 16 18.90625 L 11.65625 16 Z M 5 13.9375 L 8.0625 16 L 5 18.0625 Z M 27 13.9375 L 27 18.0625 L 23.9375 16 Z M 9.875 17.1875 L 15 20.65625 L 15 26.09375 L 5.8125 19.90625 Z M 22.125 17.1875 L 26.1875 19.90625 L 17 26.09375 L 17 20.65625 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
