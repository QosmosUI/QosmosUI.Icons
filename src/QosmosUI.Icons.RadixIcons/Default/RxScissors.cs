// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxScissors : ComponentBase
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
		builder.AddAttribute(16, "d", "M0.949988 4.48455C0.949988 5.34059 1.64395 6.03455 2.49999 6.03455C3.35603 6.03455 4.04999 5.34059 4.04999 4.48455C4.04999 3.6285 3.35603 2.93455 2.49999 2.93455C1.64395 2.93455 0.949988 3.6285 0.949988 4.48455ZM2.49999 6.93455C1.14689 6.93455 0.0499878 5.83764 0.0499878 4.48455C0.0499878 3.13145 1.14689 2.03455 2.49999 2.03455C3.85309 2.03455 4.94999 3.13145 4.94999 4.48455C4.94999 4.80813 4.88726 5.11707 4.77329 5.39985L5.73655 6.04413C5.72943 6.06656 5.72269 6.08914 5.71635 6.11188L5.56288 6.66186L5.21005 6.89773L4.21554 6.23366C3.77357 6.6672 3.168 6.93455 2.49999 6.93455ZM0.949991 10.5C0.949991 9.64394 1.64395 8.94998 2.49999 8.94998C3.35603 8.94998 4.04999 9.64394 4.04999 10.5C4.04999 11.356 3.35603 12.05 2.49999 12.05C1.64395 12.05 0.949991 11.356 0.949991 10.5ZM2.49999 8.04998C1.14689 8.04998 0.0499908 9.14688 0.0499908 10.5C0.0499908 11.8531 1.14689 12.95 2.49999 12.95C3.85309 12.95 4.94999 11.8531 4.94999 10.5C4.94999 10.1803 4.88877 9.87497 4.77743 9.595L15 2.75737L14.0486 2.85737C12.7077 2.9983 11.4091 3.40895 10.231 4.06461L7.15646 5.77564C6.92307 5.90553 6.75134 6.12339 6.67955 6.38066L6.42653 7.28737L4.22437 8.75957C3.78166 8.32091 3.17246 8.04998 2.49999 8.04998ZM7.14435 9.2149L7.15646 9.22176L10.231 10.9328C11.4091 11.5884 12.7077 11.9991 14.0486 12.14L15 12.24L8.81072 8.1003L7.14435 9.2149Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
