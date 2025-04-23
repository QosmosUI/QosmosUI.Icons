// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiGalleryView2 : ComponentBase
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
		builder.AddAttribute(14, "d", "M3 3C2.44772 3 2 3.44772 2 4V10C2 10.5523 2.44772 11 3 11H10C10.5523 11 11 10.5523 11 10V4C11 3.44772 10.5523 3 10 3H3ZM4 9V5H9V9H4ZM3 13C2.44772 13 2 13.4477 2 14V20C2 20.5523 2.44772 21 3 21H10C10.5523 21 11 20.5523 11 20V14C11 13.4477 10.5523 13 10 13H3ZM4 19V15H9V19H4ZM13 4C13 3.44772 13.4477 3 14 3H21C21.5523 3 22 3.44772 22 4V10C22 10.5523 21.5523 11 21 11H14C13.4477 11 13 10.5523 13 10V4ZM15 5V9H20V5H15ZM14 13C13.4477 13 13 13.4477 13 14V20C13 20.5523 13.4477 21 14 21H21C21.5523 21 22 20.5523 22 20V14C22 13.4477 21.5523 13 21 13H14ZM15 19V15H20V19H15Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
