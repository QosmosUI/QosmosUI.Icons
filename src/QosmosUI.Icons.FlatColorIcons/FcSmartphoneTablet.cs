// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcSmartphoneTablet : ComponentBase
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
		builder.AddAttribute(15, "d", "M4,39V7c0-2.2,1.8-4,4-4h22c2.2,0,4,1.8,4,4v32c0,2.2-1.8,4-4,4H8C5.8,43,4,41.2,4,39z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#BBDEFB");
		builder.AddAttribute(18, "d", "M30,6H8C7.4,6,7,6.4,7,7v29c0,0.6,0.4,1,1,1h22c0.6,0,1-0.4,1-1V7C31,6.4,30.6,6,30,6z");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "15");
		builder.AddAttribute(21, "y", "39");
		builder.AddAttribute(22, "fill", "#78909C");
		builder.AddAttribute(23, "width", "6");
		builder.AddAttribute(24, "height", "2");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#E38939");
		builder.AddAttribute(27, "d", "M24,41V17c0-2.2,1.8-4,4-4h12c2.2,0,4,1.8,4,4v24c0,2.2-1.8,4-4,4H28C25.8,45,24,43.2,24,41z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#FFF3E0");
		builder.AddAttribute(30, "d", "M40,16H28c-0.6,0-1,0.4-1,1v22c0,0.6,0.4,1,1,1h12c0.6,0,1-0.4,1-1V17C41,16.4,40.6,16,40,16z");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "fill", "#A6642A");
		builder.AddAttribute(33, "cx", "34");
		builder.AddAttribute(34, "cy", "42.5");
		builder.AddAttribute(35, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
