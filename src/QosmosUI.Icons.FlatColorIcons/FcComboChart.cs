// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcComboChart : ComponentBase
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
		builder.AddAttribute(14, "fill", "#00BCD4");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "37");
		builder.AddAttribute(17, "y", "18");
		builder.AddAttribute(18, "width", "6");
		builder.AddAttribute(19, "height", "24");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "29");
		builder.AddAttribute(22, "y", "26");
		builder.AddAttribute(23, "width", "6");
		builder.AddAttribute(24, "height", "16");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "21");
		builder.AddAttribute(27, "y", "22");
		builder.AddAttribute(28, "width", "6");
		builder.AddAttribute(29, "height", "20");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "x", "13");
		builder.AddAttribute(32, "y", "32");
		builder.AddAttribute(33, "width", "6");
		builder.AddAttribute(34, "height", "10");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "5");
		builder.AddAttribute(37, "y", "28");
		builder.AddAttribute(38, "width", "6");
		builder.AddAttribute(39, "height", "14");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(40, "g");
		builder.AddAttribute(41, "fill", "#3F51B5");
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "8");
		builder.AddAttribute(44, "cy", "16");
		builder.AddAttribute(45, "r", "3");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "16");
		builder.AddAttribute(48, "cy", "18");
		builder.AddAttribute(49, "r", "3");
		builder.CloseElement();
		builder.OpenElement(50, "circle");
		builder.AddAttribute(51, "cx", "24");
		builder.AddAttribute(52, "cy", "11");
		builder.AddAttribute(53, "r", "3");
		builder.CloseElement();
		builder.OpenElement(54, "circle");
		builder.AddAttribute(55, "cx", "32");
		builder.AddAttribute(56, "cy", "13");
		builder.AddAttribute(57, "r", "3");
		builder.CloseElement();
		builder.OpenElement(58, "circle");
		builder.AddAttribute(59, "cx", "40");
		builder.AddAttribute(60, "cy", "9");
		builder.AddAttribute(61, "r", "3");
		builder.CloseElement();
		builder.OpenElement(62, "polygon");
		builder.AddAttribute(63, "points", "39.1,7.2 31.8,10.9 23.5,8.8 15.5,15.8 8.5,14.1 7.5,17.9 16.5,20.2 24.5,13.2 32.2,15.1 40.9,10.8");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
