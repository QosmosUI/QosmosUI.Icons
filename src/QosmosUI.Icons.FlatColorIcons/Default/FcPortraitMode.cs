// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcPortraitMode : ComponentBase
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
		builder.AddAttribute(14, "fill", "#FF9800");
		builder.AddAttribute(15, "d", "M22,38c-4.8,0-5-7-5-7v-6h10v6C27,31,26.8,38,22,38z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#FFA726");
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "31");
		builder.AddAttribute(20, "cy", "19");
		builder.AddAttribute(21, "r", "2");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "13");
		builder.AddAttribute(24, "cy", "19");
		builder.AddAttribute(25, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "fill", "#FFB74D");
		builder.AddAttribute(28, "d", "M31,13c0-7.6-18-5-18,0c0,1.1,0,5.9,0,7c0,5,4,9,9,9s9-4,9-9C31,18.9,31,14.1,31,13z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "fill", "#424242");
		builder.AddAttribute(31, "d", "M22,4c-6.1,0-10,4.9-10,11c0,0.8,0,2.3,0,2.3l2,1.7v-5l12-4l4,4v5l2-1.7c0,0,0-1.5,0-2.3c0-4-1-8-6-9l-1-2 H22z");
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.AddAttribute(33, "fill", "#784719");
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "26");
		builder.AddAttribute(36, "cy", "19");
		builder.AddAttribute(37, "r", "1");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "18");
		builder.AddAttribute(40, "cy", "19");
		builder.AddAttribute(41, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "fill", "#009688");
		builder.AddAttribute(44, "d", "M27,31L27,31c0,0-1.8,2-5,2s-5-2-5-2S6,33,6,44h32C38,33,27,31,27,31z");
		builder.CloseElement();
		builder.OpenElement(45, "g");
		builder.AddAttribute(46, "fill", "#FF9800");
		builder.OpenElement(47, "rect");
		builder.AddAttribute(48, "x", "36.1");
		builder.AddAttribute(49, "y", "6.1");
		builder.AddAttribute(50, "transform", "matrix(.707 .707 -.707 .707 19.787 -25.77)");
		builder.AddAttribute(51, "width", "9.9");
		builder.AddAttribute(52, "height", "9.9");
		builder.CloseElement();
		builder.OpenElement(53, "rect");
		builder.AddAttribute(54, "x", "36");
		builder.AddAttribute(55, "y", "6");
		builder.AddAttribute(56, "width", "10");
		builder.AddAttribute(57, "height", "10");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(58, "circle");
		builder.AddAttribute(59, "fill", "#FFEB3B");
		builder.AddAttribute(60, "cx", "41");
		builder.AddAttribute(61, "cy", "11");
		builder.AddAttribute(62, "r", "3");
		builder.CloseElement();
		builder.CloseElement();
    }
}
