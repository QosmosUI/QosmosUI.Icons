// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxDragHandleVertical : ComponentBase
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
		builder.AddAttribute(16, "d", "M4.09998 12.5C4.09998 12.7209 4.27906 12.9 4.49998 12.9C4.72089 12.9 4.89998 12.7209 4.89998 12.5L4.89998 2.50002C4.89998 2.27911 4.72089 2.10003 4.49998 2.10003C4.27906 2.10003 4.09998 2.27911 4.09998 2.50002L4.09998 12.5ZM6.09998 12.5C6.09998 12.7209 6.27906 12.9 6.49998 12.9C6.72089 12.9 6.89998 12.7209 6.89998 12.5L6.89998 2.50002C6.89998 2.27911 6.72089 2.10003 6.49998 2.10003C6.27906 2.10003 6.09998 2.27911 6.09998 2.50002L6.09998 12.5ZM8.49998 12.9C8.27906 12.9 8.09998 12.7209 8.09998 12.5L8.09998 2.50002C8.09998 2.27911 8.27906 2.10002 8.49998 2.10002C8.72089 2.10002 8.89998 2.27911 8.89998 2.50002L8.89998 12.5C8.89998 12.7209 8.72089 12.9 8.49998 12.9ZM10.1 12.5C10.1 12.7209 10.2791 12.9 10.5 12.9C10.7209 12.9 10.9 12.7209 10.9 12.5L10.9 2.50002C10.9 2.27911 10.7209 2.10002 10.5 2.10002C10.2791 2.10002 10.1 2.27911 10.1 2.50002L10.1 12.5Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
