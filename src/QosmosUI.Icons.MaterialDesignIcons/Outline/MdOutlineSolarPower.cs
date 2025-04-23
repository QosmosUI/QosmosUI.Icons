// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineSolarPower : ComponentBase
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
		builder.AddAttribute(21, "d", "M20,12H4L2,22h20L20,12z M18.36,14l0.4,2H13v-2H18.36z M11,14v2H5.24l0.4-2H11z M4.84,18H11v2H4.44L4.84,18z M13,20v-2 h6.16l0.4,2H13z");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "height", "3");
		builder.AddAttribute(24, "width", "2");
		builder.AddAttribute(25, "x", "11");
		builder.AddAttribute(26, "y", "8");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "3");
		builder.AddAttribute(29, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -0.2089 14.6085)");
		builder.AddAttribute(30, "width", "2");
		builder.AddAttribute(31, "x", "16.53");
		builder.AddAttribute(32, "y", "6.06");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "height", "2");
		builder.AddAttribute(35, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -3.448 6.7885)");
		builder.AddAttribute(36, "width", "3");
		builder.AddAttribute(37, "x", "4.97");
		builder.AddAttribute(38, "y", "6.56");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "height", "2");
		builder.AddAttribute(41, "width", "3");
		builder.AddAttribute(42, "x", "3");
		builder.AddAttribute(43, "y", "2");
		builder.CloseElement();
		builder.OpenElement(44, "rect");
		builder.AddAttribute(45, "height", "2");
		builder.AddAttribute(46, "width", "3");
		builder.AddAttribute(47, "x", "18");
		builder.AddAttribute(48, "y", "2");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "d", "M12,7c2.76,0,5-2.24,5-5h-2c0,1.65-1.35,3-3,3S9,3.65,9,2H7C7,4.76,9.24,7,12,7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
