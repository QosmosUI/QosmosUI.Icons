// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaCompassSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 C 9.382813 4 4 9.382813 4 16 C 4 22.617188 9.382813 28 16 28 C 22.617188 28 28 22.617188 28 16 C 28 9.382813 22.617188 4 16 4 Z M 14.96875 6.0625 C 14.980469 6.0625 14.988281 6.0625 15 6.0625 L 15 7 L 17 7 L 17 6.0625 C 21.738281 6.527344 25.472656 10.261719 25.9375 15 L 25 15 L 25 17 L 25.9375 17 C 25.472656 21.738281 21.738281 25.472656 17 25.9375 L 17 25 L 15 25 L 15 25.9375 C 10.261719 25.472656 6.527344 21.738281 6.0625 17 L 7 17 L 7 15 L 6.0625 15 C 6.527344 10.269531 10.246094 6.539063 14.96875 6.0625 Z M 22.5 9.5 L 14.15625 14.15625 L 9.5 22.5 L 17.84375 17.84375 Z M 16 14.5 C 16.828125 14.5 17.5 15.171875 17.5 16 C 17.5 16.828125 16.828125 17.5 16 17.5 C 15.171875 17.5 14.5 16.828125 14.5 16 C 14.5 15.171875 15.171875 14.5 16 14.5 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
