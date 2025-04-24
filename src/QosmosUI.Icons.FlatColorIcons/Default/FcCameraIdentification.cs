// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcCameraIdentification : ComponentBase
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
		builder.AddAttribute(14, "fill", "#512DA8");
		builder.AddAttribute(15, "d", "M33.9,12.1H14.2L17.6,7c0.4-0.6,1-0.9,1.7-0.9h9.6c0.7,0,1.3,0.3,1.7,0.9L33.9,12.1z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#8667C4");
		builder.AddAttribute(18, "d", "M14,11H8V9.2C8,8.5,8.5,8,9.2,8h3.6C13.5,8,14,8.5,14,9.2V11z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#5E35B1");
		builder.AddAttribute(21, "d", "M40,42H8c-2.2,0-4-1.8-4-4V14c0-2.2,1.8-4,4-4h32c2.2,0,4,1.8,4,4v24C44,40.2,42.2,42,40,42z");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "fill", "#512DA8");
		builder.AddAttribute(24, "cx", "24");
		builder.AddAttribute(25, "cy", "26");
		builder.AddAttribute(26, "r", "12");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "fill", "#B388FF");
		builder.AddAttribute(29, "cx", "24");
		builder.AddAttribute(30, "cy", "26");
		builder.AddAttribute(31, "r", "9");
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.AddAttribute(33, "fill", "#616161");
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "42.2");
		builder.AddAttribute(36, "y", "38.3");
		builder.AddAttribute(37, "transform", "matrix(.707 -.707 .707 .707 -18.002 43.46)");
		builder.AddAttribute(38, "width", "2.4");
		builder.AddAttribute(39, "height", "10.4");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "35");
		builder.AddAttribute(42, "cy", "35");
		builder.AddAttribute(43, "r", "10");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(44, "rect");
		builder.AddAttribute(45, "x", "43.9");
		builder.AddAttribute(46, "y", "42.4");
		builder.AddAttribute(47, "transform", "matrix(.707 -.707 .707 .707 -18.709 45.167)");
		builder.AddAttribute(48, "fill", "#37474F");
		builder.AddAttribute(49, "width", "2.4");
		builder.AddAttribute(50, "height", "5.6");
		builder.CloseElement();
		builder.OpenElement(51, "circle");
		builder.AddAttribute(52, "fill", "#64B5F6");
		builder.AddAttribute(53, "cx", "35");
		builder.AddAttribute(54, "cy", "35");
		builder.AddAttribute(55, "r", "8");
		builder.CloseElement();
		builder.OpenElement(56, "path");
		builder.AddAttribute(57, "fill", "#BBDEFB");
		builder.AddAttribute(58, "d", "M39.3,31.4c-1.1-1.3-2.6-2-4.2-2s-3.2,0.7-4.2,2c-0.2,0.3-0.2,0.6,0.1,0.9c0.3,0.2,0.6,0.2,0.9-0.1 c0.8-1,2-1.5,3.3-1.5s2.5,0.6,3.3,1.5c0.1,0.1,0.3,0.2,0.5,0.2c0.1,0,0.3,0,0.4-0.1C39.5,32.1,39.5,31.7,39.3,31.4z");
		builder.CloseElement();
		builder.OpenElement(59, "path");
		builder.AddAttribute(60, "fill", "#C7A7FF");
		builder.AddAttribute(61, "d", "M29,23c-1.2-1.4-3-2.2-4.8-2.2c-1.8,0-3.6,0.8-4.8,2.2c-0.5,0.5-0.4,1.3,0.1,1.8c0.5,0.5,1.3,0.4,1.8-0.1 c1.5-1.7,4.3-1.7,5.8,0c0.3,0.3,0.6,0.4,1,0.4c0.3,0,0.6-0.1,0.9-0.3C29.4,24.4,29.5,23.5,29,23z");
		builder.CloseElement();
		builder.OpenElement(62, "ellipse");
		builder.AddAttribute(63, "fill", "#8667C4");
		builder.AddAttribute(64, "cx", "11");
		builder.AddAttribute(65, "cy", "13.5");
		builder.AddAttribute(66, "rx", "2");
		builder.AddAttribute(67, "ry", "1.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
