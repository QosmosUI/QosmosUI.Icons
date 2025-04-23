// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCallback : ComponentBase
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
		builder.AddAttribute(14, "fill", "#2196F3");
		builder.AddAttribute(15, "d", "M26.4,33.9c0,0,4-2.6,4.8-3c0.8-0.4,1.7-0.6,2.2-0.2c0.8,0.5,7.5,4.9,8.1,5.3c0.6,0.4,0.8,1.5,0.1,2.6 c-0.8,1.1-4.3,5.5-5.8,5.4c-1.5,0-8.4,0.4-20.3-11.4C3.6,20.7,4,13.8,4,12.3c0-1.5,4.3-5.1,5.4-5.8c1.1-0.8,2.2-0.5,2.6,0.1 c0.4,0.6,4.8,7.3,5.3,8.1c0.3,0.5,0.2,1.4-0.2,2.2c-0.4,0.8-3,4.8-3,4.8s0.7,2.8,5,7.2C23.5,33.2,26.4,33.9,26.4,33.9z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#3F51B5");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M35,9H25v4h10c1.1,0,2,0.9,2,2v10h4V15C41,11.7,38.3,9,35,9z");
		builder.CloseElement();
		builder.OpenElement(20, "polygon");
		builder.AddAttribute(21, "points", "28,16 21.3,11 28,6");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
