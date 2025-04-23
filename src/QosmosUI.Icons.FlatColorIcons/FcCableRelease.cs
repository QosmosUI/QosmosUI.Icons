// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCableRelease : ComponentBase
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
		builder.AddAttribute(15, "d", "M34.9,29.1c-2.7-2.7-7.1-2.7-9.8,0l-4,4c-1.7,1.7-4.5,1.7-6.2,0c-1.7-1.7-1.7-4.5,0-6.2l4.5-4.5l-2.8-2.8 l-4.5,4.5c-3.3,3.3-3.3,8.6,0,11.8c3.3,3.3,8.6,3.3,11.8,0l4-4c1.2-1.1,3-1.1,4.2,0c1.1,1.2,1.1,3,0,4.2L27,41.2l2.8,2.8l5.1-5.1 C37.6,36.2,37.6,31.8,34.9,29.1z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#0277BD");
		builder.AddAttribute(18, "d", "M16.1,22.9L16.1,22.9c-2.8-2.8-2.8-7.3,0-10l6.8-6.8c2.8-2.8,7.3-2.8,10,0l0,0c2.8,2.8,2.8,7.3,0,10 l-6.8,6.8C23.3,25.7,18.9,25.7,16.1,22.9z");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "fill", "#B3E5FC");
		builder.AddAttribute(21, "cx", "28");
		builder.AddAttribute(22, "cy", "11");
		builder.AddAttribute(23, "r", "4");
		builder.CloseElement();
		builder.CloseElement();
    }
}
