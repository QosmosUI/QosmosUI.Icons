// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcBbc : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#37474F");
		builder.AddAttribute(15, "d", "M0,17v14h14V17H0z M34,17v14h14V17H34z M17,17v14h14V17H17z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#FFFFFF");
		builder.AddAttribute(18, "d", "M8.2,23.7c0,0,1.3-0.5,1.3-2c0,0,0.2-2.4-3-2.7H3v10h4c0,0,3.4,0,3.4-2.8C10.4,26.2,10.5,24.3,8.2,23.7z	 M4.8,20.6h1.4c1.5,0.1,1.4,1.2,1.4,1.2c0,1.4-1.6,1.4-1.6,1.4H4.8V20.6z M6.7,27.5H4.8v-2.7h1.9c1.9,0,1.9,1.3,1.9,1.3	C8.5,27.5,6.7,27.5,6.7,27.5z M25.2,23.7c0,0,1.3-0.5,1.3-2c0,0,0.2-2.4-3-2.7H20v10h4c0,0,3.4,0,3.4-2.8	C27.4,26.2,27.5,24.3,25.2,23.7z M21.8,20.6h1.4c1.5,0.1,1.4,1.2,1.4,1.2c0,1.4-1.6,1.4-1.6,1.4h-1.2V20.6z M23.7,27.5h-1.9v-2.7	h1.9c1.9,0,1.9,1.3,1.9,1.3C25.5,27.5,23.7,27.5,23.7,27.5z M45.3,28.1c0,0-2.9,1.8-6.3,0.4c0,0-2.9-1.1-3-4.5c0,0-0.1-3.5,3.7-4.7	c0,0,1-0.4,2.8-0.2c0,0,1.1,0.1,2.7,0.8v1.8c0,0-1.7-1.1-3.7-1.1c0,0-3.6-0.1-3.8,3.5c0,0-0.1,3.3,3.7,3.4c0,0,1.6,0.2,3.8-1.2	L45.3,28.1L45.3,28.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
