// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcSlrBackSide : ComponentBase
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
		builder.AddAttribute(14, "fill", "#5E35B1");
		builder.AddAttribute(15, "d", "M40,10h-7.6l-2-3c-0.4-0.6-1-0.9-1.7-0.9h-9.6c-0.7,0-1.3,0.3-1.7,0.9l-2,3H8c-2.2,0-4,1.8-4,4v24 c0,2.2,1.8,4,4,4h32c2.2,0,4-1.8,4-4V14C44,11.8,42.2,10,40,10z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#F57C00");
		builder.AddAttribute(18, "d", "M11,16h20c0.6,0,1,0.4,1,1v16c0,0.6-0.4,1-1,1H11c-0.6,0-1-0.4-1-1V17C10,16.4,10.4,16,11,16z");
		builder.CloseElement();
		builder.OpenElement(19, "polygon");
		builder.AddAttribute(20, "fill", "#942A09");
		builder.AddAttribute(21, "points", "18.9,22 12,32 25.8,32");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "fill", "#FFF9C4");
		builder.AddAttribute(24, "cx", "27");
		builder.AddAttribute(25, "cy", "21");
		builder.AddAttribute(26, "r", "2");
		builder.CloseElement();
		builder.OpenElement(27, "polygon");
		builder.AddAttribute(28, "fill", "#BF360C");
		builder.AddAttribute(29, "points", "25.2,26 20.4,32 30,32");
		builder.CloseElement();
		builder.OpenElement(30, "g");
		builder.AddAttribute(31, "fill", "#8667C4");
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M34,10h6V9.2C40,8.5,39.5,8,38.8,8h-3.6C34.5,8,34,8.5,34,9.2V10z");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "38");
		builder.AddAttribute(36, "cy", "18");
		builder.AddAttribute(37, "r", "2");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "38");
		builder.AddAttribute(40, "cy", "24");
		builder.AddAttribute(41, "r", "2");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "38");
		builder.AddAttribute(44, "cy", "30");
		builder.AddAttribute(45, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
