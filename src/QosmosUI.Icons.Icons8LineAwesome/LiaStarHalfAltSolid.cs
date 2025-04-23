// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaStarHalfAltSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 2.375 L 15.09375 4.40625 L 11.84375 11.71875 L 3.90625 12.53125 L 1.65625 12.78125 L 3.34375 14.28125 L 9.25 19.625 L 7.59375 27.4375 L 7.125 29.625 L 7.15625 29.625 L 9.09375 28.5 L 16 24.53125 L 22.90625 28.5 L 24.875 29.625 L 24.40625 27.4375 L 22.75 19.625 L 28.65625 14.28125 L 30.34375 12.78125 L 28.09375 12.53125 L 20.15625 11.71875 L 16.90625 4.40625 Z M 16 7.28125 L 18.5625 13.0625 L 18.8125 13.5625 L 19.375 13.625 L 25.6875 14.28125 L 20.96875 18.53125 L 20.53125 18.90625 L 20.65625 19.46875 L 21.96875 25.65625 L 16.5 22.5 L 16 22.21875 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
