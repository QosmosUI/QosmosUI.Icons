// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiFigmaLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M5 6C5 3.79086 6.79086 2 9 2H15C17.2091 2 19 3.79086 19 6C19 7.19469 18.4762 8.26706 17.6458 9C18.4762 9.73295 19 10.8053 19 12C19 14.2091 17.2091 16 15 16C14.2714 16 13.5883 15.8052 13 15.4649V18C13 20.2091 11.2091 22 9 22C6.79086 22 5 20.2091 5 18C5 16.8053 5.52376 15.7329 6.35418 15C5.52376 14.2671 5 13.1947 5 12C5 10.8053 5.52376 9.73295 6.35418 9C5.52376 8.26706 5 7.19469 5 6ZM11 10H9C7.89543 10 7 10.8954 7 12C7 13.1046 7.89543 14 9 14H11V10ZM13 12C13 13.1046 13.8954 14 15 14C16.1046 14 17 13.1046 17 12C17 10.8954 16.1046 10 15 10C13.8954 10 13 10.8954 13 12ZM15 8C16.1046 8 17 7.10457 17 6C17 4.89543 16.1046 4 15 4H13V8H15ZM9 4C7.89543 4 7 4.89543 7 6C7 7.10457 7.89543 8 9 8H11V4H9ZM11 16H9C7.89543 16 7 16.8954 7 18C7 19.1046 7.89543 20 9 20C10.1046 20 11 19.1046 11 18V16Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
