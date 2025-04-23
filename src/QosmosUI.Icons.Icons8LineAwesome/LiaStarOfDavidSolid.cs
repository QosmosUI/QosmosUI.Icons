// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaStarOfDavidSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 2.0625 L 15.15625 3.46875 L 11.78125 9 L 3.3125 9 L 4.21875 10.53125 L 7.53125 16 L 4.21875 21.46875 L 3.3125 23 L 11.78125 23 L 15.15625 28.53125 L 16 29.9375 L 16.84375 28.53125 L 20.21875 23 L 28.78125 23 L 27.84375 21.46875 L 24.5 16 L 27.84375 10.53125 L 28.78125 9 L 20.21875 9 L 16.84375 3.46875 Z M 16 5.90625 L 17.875 9 L 14.125 9 Z M 6.875 11 L 10.59375 11 L 8.71875 14.0625 Z M 12.90625 11 L 19.125 11 L 22.15625 16 L 19.125 21 L 12.90625 21 L 9.90625 16 Z M 21.4375 11 L 25.21875 11 L 23.34375 14.09375 Z M 23.34375 17.90625 L 25.21875 21 L 21.4375 21 Z M 8.71875 17.9375 L 10.59375 21 L 6.875 21 Z M 14.125 23 L 17.875 23 L 16 26.09375 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
