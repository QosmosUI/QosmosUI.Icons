// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdSolarPower : ComponentBase
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
		builder.OpenElement(20, "polygon");
		builder.AddAttribute(21, "points", "3.33,16 11,16 11,13 4,13");
		builder.CloseElement();
		builder.OpenElement(22, "polygon");
		builder.AddAttribute(23, "points", "13,16 20.67,16 20,13 13,13");
		builder.CloseElement();
		builder.OpenElement(24, "polygon");
		builder.AddAttribute(25, "points", "21.11,18 13,18 13,22 22,22");
		builder.CloseElement();
		builder.OpenElement(26, "polygon");
		builder.AddAttribute(27, "points", "2,22 11,22 11,18 2.89,18");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "height", "3");
		builder.AddAttribute(30, "width", "2");
		builder.AddAttribute(31, "x", "11");
		builder.AddAttribute(32, "y", "8");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "height", "3");
		builder.AddAttribute(35, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -0.2089 14.6085)");
		builder.AddAttribute(36, "width", "2");
		builder.AddAttribute(37, "x", "16.53");
		builder.AddAttribute(38, "y", "6.06");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "height", "2");
		builder.AddAttribute(41, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -3.448 6.7885)");
		builder.AddAttribute(42, "width", "3");
		builder.AddAttribute(43, "x", "4.97");
		builder.AddAttribute(44, "y", "6.56");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "height", "2");
		builder.AddAttribute(47, "width", "3");
		builder.AddAttribute(48, "x", "3");
		builder.AddAttribute(49, "y", "2");
		builder.CloseElement();
		builder.OpenElement(50, "rect");
		builder.AddAttribute(51, "height", "2");
		builder.AddAttribute(52, "width", "3");
		builder.AddAttribute(53, "x", "18");
		builder.AddAttribute(54, "y", "2");
		builder.CloseElement();
		builder.OpenElement(55, "path");
		builder.AddAttribute(56, "d", "M12,7c2.76,0,5-2.24,5-5H7C7,4.76,9.24,7,12,7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
