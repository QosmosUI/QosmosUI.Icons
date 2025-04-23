// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcTouchscreenSmartphone : ComponentBase
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
		builder.AddAttribute(14, "fill", "#E38939");
		builder.AddAttribute(15, "d", "M12,40V8c0-2.2,1.8-4,4-4h16c2.2,0,4,1.8,4,4v32c0,2.2-1.8,4-4,4H16C13.8,44,12,42.2,12,40z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#FFF3E0");
		builder.AddAttribute(18, "d", "M32,7H16c-0.6,0-1,0.4-1,1v29c0,0.6,0.4,1,1,1h16c0.6,0,1-0.4,1-1V8C33,7.4,32.6,7,32,7z");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "fill", "#A6642A");
		builder.AddAttribute(21, "cx", "24");
		builder.AddAttribute(22, "cy", "41");
		builder.AddAttribute(23, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "fill", "#E91E63");
		builder.AddAttribute(26, "cx", "24");
		builder.AddAttribute(27, "cy", "23");
		builder.AddAttribute(28, "r", "2");
		builder.CloseElement();
		builder.OpenElement(29, "circle");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke", "#F48FB1");
		builder.AddAttribute(32, "stroke-width", "2");
		builder.AddAttribute(33, "stroke-miterlimit", "10");
		builder.AddAttribute(34, "cx", "24");
		builder.AddAttribute(35, "cy", "23");
		builder.AddAttribute(36, "r", "4");
		builder.CloseElement();
		builder.OpenElement(37, "circle");
		builder.AddAttribute(38, "fill", "none");
		builder.AddAttribute(39, "stroke", "#F8BBD0");
		builder.AddAttribute(40, "stroke-miterlimit", "10");
		builder.AddAttribute(41, "cx", "24");
		builder.AddAttribute(42, "cy", "23");
		builder.AddAttribute(43, "r", "6.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
