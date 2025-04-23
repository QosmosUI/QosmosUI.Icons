// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxTextAlignBottom : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M3.89949 5.50002C3.89949 5.27911 3.7204 5.10003 3.49949 5.10003C3.27857 5.10003 3.09949 5.27911 3.09949 5.50002L3.09949 12.5343L1.78233 11.2172C1.62612 11.061 1.37285 11.061 1.21664 11.2172C1.06043 11.3734 1.06043 11.6267 1.21664 11.7829L3.21664 13.7829C3.29166 13.8579 3.3934 13.9 3.49949 13.9C3.60557 13.9 3.70732 13.8579 3.78233 13.7829L5.78233 11.7829C5.93854 11.6267 5.93854 11.3734 5.78233 11.2172C5.62612 11.061 5.37285 11.061 5.21664 11.2172L3.89949 12.5343L3.89949 5.50002ZM8.49998 13C8.22383 13 7.99998 12.7762 7.99998 12.5C7.99998 12.2239 8.22383 12 8.49998 12H14.5C14.7761 12 15 12.2239 15 12.5C15 12.7762 14.7761 13 14.5 13H8.49998ZM8.49998 10C8.22383 10 7.99998 9.77617 7.99998 9.50002C7.99998 9.22388 8.22383 9.00002 8.49998 9.00002H14.5C14.7761 9.00002 15 9.22388 15 9.50002C15 9.77617 14.7761 10 14.5 10H8.49998ZM7.99998 6.50002C7.99998 6.77617 8.22383 7.00002 8.49998 7.00002H14.5C14.7761 7.00002 15 6.77617 15 6.50002C15 6.22388 14.7761 6.00002 14.5 6.00002H8.49998C8.22383 6.00002 7.99998 6.22388 7.99998 6.50002Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
