// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaHighlighterSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 23.625 3.0625 L 22.90625 3.6875 L 7.5625 17 L 7.0625 17.46875 L 7.3125 18.125 C 7.3125 18.125 8.4375 21.125 6.28125 23.28125 L 6.28125 23.3125 L 6.25 23.34375 L 6.09375 23.53125 L 5.96875 23.65625 L 2 27.53125 L 7.375 29 L 9.4375 26.9375 L 9.65625 26.75 L 9.6875 26.71875 L 9.71875 26.71875 C 11.875 24.5625 14.875 25.6875 14.875 25.6875 L 15.53125 25.9375 L 16 25.4375 L 29.3125 10.09375 L 29.9375 9.375 Z M 23.5 5.8125 L 27.1875 9.5 L 18.4375 19.5625 L 13.4375 14.5625 Z M 11.9375 15.875 L 17.125 21.0625 L 15.1875 23.3125 L 9.6875 17.8125 Z M 9.5625 20.5 L 12.5 23.4375 C 11.257813 23.484375 9.753906 23.875 8.34375 25.25 C 8.324219 25.269531 8.300781 25.261719 8.28125 25.28125 L 8.03125 25.5 L 7.5 24.96875 L 7.71875 24.71875 L 7.75 24.65625 C 9.125 23.246094 9.515625 21.742188 9.5625 20.5 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
