// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxCrosshair2 : ComponentBase
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
		builder.AddAttribute(16, "d", "M7.5 0C7.77614 0 8 0.223858 8 0.5V1.80687C10.6922 2.0935 12.8167 4.28012 13.0068 7H14.5C14.7761 7 15 7.22386 15 7.5C15 7.77614 14.7761 8 14.5 8H12.9888C12.7094 10.6244 10.6244 12.7094 8 12.9888V14.5C8 14.7761 7.77614 15 7.5 15C7.22386 15 7 14.7761 7 14.5V13.0068C4.28012 12.8167 2.0935 10.6922 1.80687 8H0.5C0.223858 8 0 7.77614 0 7.5C0 7.22386 0.223858 7 0.5 7H1.78886C1.98376 4.21166 4.21166 1.98376 7 1.78886V0.5C7 0.223858 7.22386 0 7.5 0ZM8 12.0322V9.5C8 9.22386 7.77614 9 7.5 9C7.22386 9 7 9.22386 7 9.5V12.054C4.80517 11.8689 3.04222 10.1668 2.76344 8H5.5C5.77614 8 6 7.77614 6 7.5C6 7.22386 5.77614 7 5.5 7H2.7417C2.93252 4.73662 4.73662 2.93252 7 2.7417V5.5C7 5.77614 7.22386 6 7.5 6C7.77614 6 8 5.77614 8 5.5V2.76344C10.1668 3.04222 11.8689 4.80517 12.054 7H9.5C9.22386 7 9 7.22386 9 7.5C9 7.77614 9.22386 8 9.5 8H12.0322C11.7621 10.0991 10.0991 11.7621 8 12.0322Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
