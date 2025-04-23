// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcLightAtTheEndOfTunnel : ComponentBase
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
		builder.AddAttribute(14, "fill", "#3F51B5");
		builder.AddAttribute(15, "d", "M6,10v28c0,2.2,1.8,4,4,4h28c2.2,0,4-1.8,4-4V10c0-2.2-1.8-4-4-4H10C7.8,6,6,7.8,6,10z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#CCF2F6");
		builder.AddAttribute(18, "d", "M27.9,28.9h-5.8l-8.4,7.2l6-7.2v-2.4l-3,0.8l3-1.9v-1.5c0-0.8,0.1-1.7,0.6-2.4l-7.5-8.3l8.7,7.2 c0.7-0.7,1.5-1.1,2.5-1.2l0.6-7.3l1.1,7.3c0.3,0,0.6,0.1,0.8,0.1l1.2-1.2l-0.3,1.7c0.3,0.1,0.4,0.3,0.7,0.6l4.4-2.8l-3.6,3.9 c0.3,0.4,0.6,1,0.7,1.7l2.2,0.1l-2.2,0.8c0,0.3,0,1.5,0,1.5l2.6,1.4l-2.6-0.3c0,0,0,1.8,0,2.2l6.2,7.1L27.9,28.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
