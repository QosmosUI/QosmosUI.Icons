// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSolarPower : ComponentBase
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
		builder.AddAttribute(21, "opacity", ".3");
		builder.AddAttribute(22, "points", "4.44,20 11,20 11,18 4.84,18");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "opacity", ".3");
		builder.AddAttribute(25, "points", "18.36,14 13,14 13,16 18.76,16");
		builder.CloseElement();
		builder.OpenElement(26, "polygon");
		builder.AddAttribute(27, "opacity", ".3");
		builder.AddAttribute(28, "points", "13,18 13,20 19.56,20 19.16,18");
		builder.CloseElement();
		builder.OpenElement(29, "polygon");
		builder.AddAttribute(30, "opacity", ".3");
		builder.AddAttribute(31, "points", "5.24,16 11,16 11,14 5.64,14");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M20,12H4L2,22h20L20,12z M13,14h5.36l0.4,2H13V14z M11,20H4.44l0.4-2H11V20z M11,16H5.24l0.4-2H11V16z M13,20v-2h6.16 l0.4,2H13z");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "height", "3");
		builder.AddAttribute(36, "width", "2");
		builder.AddAttribute(37, "x", "11");
		builder.AddAttribute(38, "y", "8");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "height", "3");
		builder.AddAttribute(41, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -0.2089 14.6085)");
		builder.AddAttribute(42, "width", "2");
		builder.AddAttribute(43, "x", "16.53");
		builder.AddAttribute(44, "y", "6.06");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "height", "2");
		builder.AddAttribute(47, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -3.448 6.7885)");
		builder.AddAttribute(48, "width", "3");
		builder.AddAttribute(49, "x", "4.97");
		builder.AddAttribute(50, "y", "6.56");
		builder.CloseElement();
		builder.OpenElement(51, "rect");
		builder.AddAttribute(52, "height", "2");
		builder.AddAttribute(53, "width", "3");
		builder.AddAttribute(54, "x", "3");
		builder.AddAttribute(55, "y", "2");
		builder.CloseElement();
		builder.OpenElement(56, "rect");
		builder.AddAttribute(57, "height", "2");
		builder.AddAttribute(58, "width", "3");
		builder.AddAttribute(59, "x", "18");
		builder.AddAttribute(60, "y", "2");
		builder.CloseElement();
		builder.OpenElement(61, "path");
		builder.AddAttribute(62, "d", "M12,7c2.76,0,5-2.24,5-5h-2c0,1.65-1.35,3-3,3S9,3.65,9,2H7C7,4.76,9.24,7,12,7z");
		builder.CloseElement();
		builder.OpenElement(63, "path");
		builder.AddAttribute(64, "d", "M15,2c0,1.66-1.34,3-3,3S9,3.66,9,2H15z");
		builder.AddAttribute(65, "opacity", ".3");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
