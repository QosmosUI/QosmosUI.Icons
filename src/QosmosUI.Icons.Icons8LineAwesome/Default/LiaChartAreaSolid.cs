// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaChartAreaSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 28 4.0625 L 26.375 5.3125 L 21.75 8.9375 L 16.15625 8 L 15.78125 7.9375 L 15.4375 8.15625 L 9.75 11.9375 L 5.1875 11.03125 L 4 10.78125 L 4 28 L 28 28 Z M 26 8.15625 L 26 13.53125 L 21.78125 16.875 L 16.3125 15.0625 L 15.84375 14.90625 L 15.4375 15.15625 L 9.875 18.875 L 6 17.3125 L 6 13.21875 L 9.8125 13.96875 L 10.21875 14.0625 L 10.5625 13.84375 L 16.21875 10.0625 L 21.84375 11 L 22.28125 11.0625 L 22.625 10.78125 Z M 26 16.09375 L 26 26 L 6 26 L 6 19.5 L 9.625 20.9375 L 10.125 21.125 L 10.5625 20.84375 L 16.1875 17.09375 L 21.6875 18.9375 L 22.1875 19.125 L 22.625 18.78125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
