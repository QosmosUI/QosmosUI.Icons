// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneHdrPlus : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M12,4c-4.41,0-8,3.59-8,8c0,2.52,1.17,4.77,3,6.24V13h3.5c0.8,0,1.5,0.7,1.5,1.5v1c0,0.6-0.4,1.1-0.9,1.4 L12,19h-1.5l-0.9-2H8.5v2H8.13c1.15,0.64,2.47,1,3.87,1c4.41,0,8-3.59,8-8C20,7.59,16.41,4,12,4z M12,12h-1.5V9.5h-2V12H7V6h1.5v2 h2V6H12V12z M17.5,16H16v1.5h-1.5V16H13v-1.5h1.5V13H16v1.49h1.5V16z M17.5,10.5c0,0.8-0.7,1.5-1.5,1.5h-3V6h3 c0.8,0,1.5,0.7,1.5,1.5V10.5z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "height", "3");
		builder.AddAttribute(25, "opacity", ".3");
		builder.AddAttribute(26, "width", "1.5");
		builder.AddAttribute(27, "x", "14.5");
		builder.AddAttribute(28, "y", "7.5");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "height", "1");
		builder.AddAttribute(31, "opacity", ".3");
		builder.AddAttribute(32, "width", "2");
		builder.AddAttribute(33, "x", "8.5");
		builder.AddAttribute(34, "y", "14.5");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M12,2C6.48,2,2,6.48,2,12s4.48,10,10,10s10-4.48,10-10S17.52,2,12,2z M12,20c-1.4,0-2.72-0.36-3.87-1H8.5v-2h1.1l0.9,2H12 l-0.9-2.1c0.5-0.3,0.9-0.8,0.9-1.4v-1c0-0.8-0.7-1.5-1.5-1.5H7v5.24C5.17,16.77,4,14.52,4,12c0-4.41,3.59-8,8-8s8,3.59,8,8 C20,16.41,16.41,20,12,20z M8.5,15.5v-1h2v1H8.5z");
		builder.CloseElement();
		builder.OpenElement(37, "polygon");
		builder.AddAttribute(38, "points", "10.5,8 8.5,8 8.5,6 7,6 7,12 8.5,12 8.5,9.5 10.5,9.5 10.5,12 12,12 12,6 10.5,6");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M16,6h-3v6h3c0.8,0,1.5-0.7,1.5-1.5v-3C17.5,6.7,16.8,6,16,6z M16,10.5h-1.5v-3H16V10.5z");
		builder.CloseElement();
		builder.OpenElement(41, "polygon");
		builder.AddAttribute(42, "points", "16,13 14.5,13 14.5,14.5 13,14.5 13,16 14.5,16 14.5,17.5 16,17.5 16,16 17.5,16 17.5,14.49 16,14.49");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
