// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxHobbyKnife : ComponentBase
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
		builder.AddAttribute(16, "d", "M12.3536 13.3536C12.1583 13.5488 11.8417 13.5488 11.6465 13.3536L6.39645 8.10355C6.36478 8.07188 6.33824 8.03702 6.31685 8H5.00002C4.78719 8 4.59769 7.86528 4.52777 7.66426L2.12777 0.764277C2.05268 0.548387 2.13355 0.309061 2.3242 0.182972C2.51486 0.0568819 2.76674 0.0761337 2.93602 0.229734L8.336 5.12972C8.44044 5.22449 8.50001 5.35897 8.50001 5.5V5.81684C8.53702 5.83824 8.57189 5.86478 8.60356 5.89645L13.8536 11.1464C14.0488 11.3417 14.0488 11.6583 13.8536 11.8536L12.3536 13.3536ZM8.25 6.95711L7.45711 7.75L12 12.2929L12.7929 11.5L8.25 6.95711ZM3.71669 2.28845L5.35549 7H6.2929L7.50001 5.79289V5.72146L3.71669 2.28845Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
