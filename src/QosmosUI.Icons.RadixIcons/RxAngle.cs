// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxAngle : ComponentBase
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
		builder.AddAttribute(16, "d", "M8.8914 2.1937C9.1158 2.35464 9.16725 2.66701 9.00631 2.89141L2.47388 12H13.5C13.7761 12 14 12.2239 14 12.5C14 12.7762 13.7761 13 13.5 13H1.5C1.31254 13 1.14082 12.8952 1.0552 12.7284C0.969578 12.5616 0.984438 12.361 1.09369 12.2086L8.19369 2.30862C8.35462 2.08422 8.667 2.03277 8.8914 2.1937ZM11.1 6.50001C11.1 6.22387 11.3238 6.00001 11.6 6.00001C11.8761 6.00001 12.1 6.22387 12.1 6.50001C12.1 6.77615 11.8761 7.00001 11.6 7.00001C11.3238 7.00001 11.1 6.77615 11.1 6.50001ZM10.4 4.00001C10.1239 4.00001 9.90003 4.22387 9.90003 4.50001C9.90003 4.77615 10.1239 5.00001 10.4 5.00001C10.6762 5.00001 10.9 4.77615 10.9 4.50001C10.9 4.22387 10.6762 4.00001 10.4 4.00001ZM12.1 8.50001C12.1 8.22387 12.3238 8.00001 12.6 8.00001C12.8761 8.00001 13.1 8.22387 13.1 8.50001C13.1 8.77615 12.8761 9.00001 12.6 9.00001C12.3238 9.00001 12.1 8.77615 12.1 8.50001ZM13.4 10C13.1239 10 12.9 10.2239 12.9 10.5C12.9 10.7761 13.1239 11 13.4 11C13.6762 11 13.9 10.7761 13.9 10.5C13.9 10.2239 13.6762 10 13.4 10Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
