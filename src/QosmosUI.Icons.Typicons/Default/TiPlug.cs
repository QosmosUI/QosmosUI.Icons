// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiPlug : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "M18,6h-1V3c0-0.6-0.4-1-1-1h-2c-0.6,0-1,0.4-1,1v3h-2V3c0-0.6-0.4-1-1-1H8C7.4,2,7,2.4,7,3v3H6C5.4,6,5,6.4,5,7v4	c0,0.1,0,0.1,0,0.2c0.2,2.5,1.8,4.6,4,5.6V20c0,1.1,0.9,2,2,2h2c1.1,0,2-0.9,2-2v-3.2c2.2-1,3.7-3.1,4-5.6c0-0.1,0-0.1,0-0.2V7	C19,6.4,18.6,6,18,6z M14,3h2v3h-2V3z M8,3h2v3H8V3z M13,20h-2v-2h2V20z M12,15.5c-2.2,0-4.1-1.5-4.7-3.5h9.5	C16.1,14,14.2,15.5,12,15.5z M17,10.5c0,0.2,0,0.3-0.1,0.5H7.1C7,10.8,7,10.7,7,10.5V8h10V10.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
