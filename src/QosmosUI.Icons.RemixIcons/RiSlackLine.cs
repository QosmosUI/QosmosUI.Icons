// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiSlackLine : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M14.501 3C15.3294 3 16.001 3.67157 16.001 4.5V9.5C16.001 10.3284 15.3294 11 14.501 11C13.6725 11 13.001 10.3284 13.001 9.5V4.5C13.001 3.67157 13.6725 3 14.501 3ZM4.50098 13H6.00098V14.5C6.00098 15.3284 5.3294 16 4.50098 16C3.67255 16 3.00098 15.3284 3.00098 14.5C3.00098 13.6716 3.67255 13 4.50098 13ZM13.001 18H14.501C15.3294 18 16.001 18.6716 16.001 19.5C16.001 20.3284 15.3294 21 14.501 21C13.6725 21 13.001 20.3284 13.001 19.5V18ZM14.501 13H19.501C20.3294 13 21.001 13.6716 21.001 14.5C21.001 15.3284 20.3294 16 19.501 16H14.501C13.6725 16 13.001 15.3284 13.001 14.5C13.001 13.6716 13.6725 13 14.501 13ZM19.501 8C20.3294 8 21.001 8.67157 21.001 9.5C21.001 10.3284 20.3294 11 19.501 11H18.001V9.5C18.001 8.67157 18.6725 8 19.501 8ZM4.50098 8H9.50098C10.3294 8 11.001 8.67157 11.001 9.5C11.001 10.3284 10.3294 11 9.50098 11H4.50098C3.67255 11 3.00098 10.3284 3.00098 9.5C3.00098 8.67157 3.67255 8 4.50098 8ZM9.50098 3C10.3294 3 11.001 3.67157 11.001 4.5V6H9.50098C8.67255 6 8.00098 5.32843 8.00098 4.5C8.00098 3.67157 8.67255 3 9.50098 3ZM9.50098 13C10.3294 13 11.001 13.6716 11.001 14.5V19.5C11.001 20.3284 10.3294 21 9.50098 21C8.67255 21 8.00098 20.3284 8.00098 19.5V14.5C8.00098 13.6716 8.67255 13 9.50098 13Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
