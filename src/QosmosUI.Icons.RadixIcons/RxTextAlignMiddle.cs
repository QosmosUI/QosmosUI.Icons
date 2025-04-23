// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxTextAlignMiddle : ComponentBase
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
		builder.AddAttribute(16, "d", "M3.49949 14.9C3.7204 14.9 3.89949 14.7209 3.89949 14.5L3.89949 10.4657L5.21664 11.7829C5.37285 11.9391 5.62612 11.9391 5.78233 11.7829C5.93854 11.6267 5.93854 11.3734 5.78233 11.2172L3.78233 9.21718C3.70732 9.14217 3.60557 9.10002 3.49949 9.10002C3.3934 9.10002 3.29166 9.14217 3.21664 9.21718L1.21664 11.2172C1.06043 11.3734 1.06043 11.6267 1.21664 11.7829C1.37285 11.9391 1.62612 11.9391 1.78233 11.7829L3.09949 10.4657L3.09949 14.5C3.09949 14.7209 3.27857 14.9 3.49949 14.9ZM7.99998 10.5C7.99998 10.7762 8.22383 11 8.49998 11H14.5C14.7761 11 15 10.7762 15 10.5C15 10.2239 14.7761 10 14.5 10H8.49998C8.22383 10 7.99998 10.2239 7.99998 10.5ZM7.99998 7.50002C7.99998 7.77617 8.22383 8.00002 8.49998 8.00002H14.5C14.7761 8.00002 15 7.77617 15 7.50002C15 7.22388 14.7761 7.00002 14.5 7.00002H8.49998C8.22383 7.00002 7.99998 7.22388 7.99998 7.50002ZM8.49998 5.00002C8.22383 5.00002 7.99998 4.77617 7.99998 4.50002C7.99998 4.22388 8.22383 4.00002 8.49998 4.00002H14.5C14.7761 4.00002 15 4.22388 15 4.50002C15 4.77617 14.7761 5.00002 14.5 5.00002H8.49998ZM3.89949 0.500025C3.89949 0.279111 3.7204 0.100025 3.49949 0.100025C3.27857 0.100025 3.09949 0.279111 3.09949 0.500025L3.09949 4.53434L1.78233 3.21718C1.62612 3.06097 1.37285 3.06097 1.21664 3.21718C1.06043 3.37339 1.06043 3.62666 1.21664 3.78287L3.21664 5.78287C3.29166 5.85788 3.3934 5.90002 3.49949 5.90002C3.60557 5.90002 3.70732 5.85788 3.78233 5.78287L5.78233 3.78287C5.93854 3.62666 5.93854 3.37339 5.78233 3.21718C5.62612 3.06097 5.37285 3.06097 5.21664 3.21718L3.89949 4.53434L3.89949 0.500025Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
