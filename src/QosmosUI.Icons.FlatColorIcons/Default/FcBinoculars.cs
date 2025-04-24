// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcBinoculars : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#37474F");
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "33");
		builder.AddAttribute(17, "cy", "16");
		builder.AddAttribute(18, "r", "6");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "15");
		builder.AddAttribute(21, "cy", "16");
		builder.AddAttribute(22, "r", "6");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M46.7,25l-15.3,3H16.7L1.4,25l4.3-7.9c1.1-1.9,3.1-3.1,5.3-3.1h26.2c2.2,0,4.2,1.2,5.3,3.1L46.7,25z");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "38");
		builder.AddAttribute(27, "cy", "30");
		builder.AddAttribute(28, "r", "10");
		builder.CloseElement();
		builder.OpenElement(29, "circle");
		builder.AddAttribute(30, "cx", "10");
		builder.AddAttribute(31, "cy", "30");
		builder.AddAttribute(32, "r", "10");
		builder.CloseElement();
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "cx", "24");
		builder.AddAttribute(35, "cy", "28");
		builder.AddAttribute(36, "r", "5");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(37, "circle");
		builder.AddAttribute(38, "fill", "#546E7A");
		builder.AddAttribute(39, "cx", "24");
		builder.AddAttribute(40, "cy", "28");
		builder.AddAttribute(41, "r", "2");
		builder.CloseElement();
		builder.OpenElement(42, "g");
		builder.AddAttribute(43, "fill", "#a0f");
		builder.OpenElement(44, "circle");
		builder.AddAttribute(45, "cx", "38");
		builder.AddAttribute(46, "cy", "30");
		builder.AddAttribute(47, "r", "7");
		builder.CloseElement();
		builder.OpenElement(48, "circle");
		builder.AddAttribute(49, "cx", "10");
		builder.AddAttribute(50, "cy", "30");
		builder.AddAttribute(51, "r", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(52, "g");
		builder.AddAttribute(53, "fill", "#CE93D8");
		builder.OpenElement(54, "path");
		builder.AddAttribute(55, "d", "M41.7,27.7c-1-1.1-2.3-1.7-3.7-1.7s-2.8,0.6-3.7,1.7c-0.4,0.4-0.3,1,0.1,1.4c0.4,0.4,1,0.3,1.4-0.1 c1.2-1.3,3.3-1.3,4.5,0c0.2,0.2,0.5,0.3,0.7,0.3c0.2,0,0.5-0.1,0.7-0.3C42.1,28.7,42.1,28.1,41.7,27.7z");
		builder.CloseElement();
		builder.OpenElement(56, "path");
		builder.AddAttribute(57, "d", "M10,26c-1.4,0-2.8,0.6-3.7,1.7c-0.4,0.4-0.3,1,0.1,1.4c0.4,0.4,1,0.3,1.4-0.1c1.2-1.3,3.3-1.3,4.5,0 c0.2,0.2,0.5,0.3,0.7,0.3c0.2,0,0.5-0.1,0.7-0.3c0.4-0.4,0.4-1,0.1-1.4C12.8,26.6,11.4,26,10,26z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
