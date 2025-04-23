// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcTwoSmartphones : ComponentBase
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
		builder.AddAttribute(15, "d", "M6,36V8c0-2.2,1.8-4,4-4h14c2.2,0,4,1.8,4,4v28c0,2.2-1.8,4-4,4H10C7.8,40,6,38.2,6,36z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#BBDEFB");
		builder.AddAttribute(18, "d", "M24,7H10C9.4,7,9,7.4,9,8v25c0,0.6,0.4,1,1,1h14c0.6,0,1-0.4,1-1V8C25,7.4,24.6,7,24,7z");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "14");
		builder.AddAttribute(21, "y", "36");
		builder.AddAttribute(22, "fill", "#78909C");
		builder.AddAttribute(23, "width", "6");
		builder.AddAttribute(24, "height", "2");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#E38939");
		builder.AddAttribute(27, "d", "M20,40V12c0-2.2,1.8-4,4-4h14c2.2,0,4,1.8,4,4v28c0,2.2-1.8,4-4,4H24C21.8,44,20,42.2,20,40z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#FFF3E0");
		builder.AddAttribute(30, "d", "M38,11H24c-0.6,0-1,0.4-1,1v25c0,0.6,0.4,1,1,1h14c0.6,0,1-0.4,1-1V12C39,11.4,38.6,11,38,11z");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "fill", "#A6642A");
		builder.AddAttribute(33, "cx", "31");
		builder.AddAttribute(34, "cy", "41");
		builder.AddAttribute(35, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
