// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcMultipleSmartphones : ComponentBase
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
		builder.AddAttribute(14, "fill", "#455A64");
		builder.AddAttribute(15, "d", "M4,31V8c0-2.2,1.8-4,4-4h12c2.2,0,4,1.8,4,4v23c0,2.2-1.8,4-4,4H8C5.8,35,4,33.2,4,31z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#BBDEFB");
		builder.AddAttribute(18, "d", "M20,7H8C7.4,7,7,7.4,7,8v21c0,0.6,0.4,1,1,1h12c0.6,0,1-0.4,1-1V8C21,7.4,20.6,7,20,7z");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "fill", "#37474F");
		builder.AddAttribute(21, "cx", "14");
		builder.AddAttribute(22, "cy", "32.5");
		builder.AddAttribute(23, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "fill", "#546E7A");
		builder.AddAttribute(26, "d", "M14,36V13c0-2.2,1.8-4,4-4h12c2.2,0,4,1.8,4,4v23c0,2.2-1.8,4-4,4H18C15.8,40,14,38.2,14,36z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "fill", "#BBDEFB");
		builder.AddAttribute(29, "d", "M30,12H18c-0.6,0-1,0.4-1,1v21c0,0.6,0.4,1,1,1h12c0.6,0,1-0.4,1-1V13C31,12.4,30.6,12,30,12z");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "fill", "#37474F");
		builder.AddAttribute(32, "cx", "24");
		builder.AddAttribute(33, "cy", "37.5");
		builder.AddAttribute(34, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "fill", "#E38939");
		builder.AddAttribute(37, "d", "M24,40V18c0-2.2,1.8-4,4-4h12c2.2,0,4,1.8,4,4v22c0,2.2-1.8,4-4,4H28C25.8,44,24,42.2,24,40z");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "fill", "#FFF3E0");
		builder.AddAttribute(40, "d", "M40,17H28c-0.6,0-1,0.4-1,1v20c0,0.6,0.4,1,1,1h12c0.6,0,1-0.4,1-1V18C41,17.4,40.6,17,40,17z");
		builder.CloseElement();
		builder.OpenElement(41, "circle");
		builder.AddAttribute(42, "fill", "#A6642A");
		builder.AddAttribute(43, "cx", "34");
		builder.AddAttribute(44, "cy", "41.5");
		builder.AddAttribute(45, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
