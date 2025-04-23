// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneTungsten : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M13,7.1V5h-2v2.1C11.32,7.04,11.66,7,12,7S12.68,7.04,13,7.1z");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "height", "3");
		builder.AddAttribute(24, "width", "2");
		builder.AddAttribute(25, "x", "11");
		builder.AddAttribute(26, "y", "19");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "2");
		builder.AddAttribute(29, "width", "3");
		builder.AddAttribute(30, "x", "2");
		builder.AddAttribute(31, "y", "11");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "2");
		builder.AddAttribute(34, "width", "3");
		builder.AddAttribute(35, "x", "19");
		builder.AddAttribute(36, "y", "11");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "height", "3");
		builder.AddAttribute(39, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -7.6665 17.8014)");
		builder.AddAttribute(40, "width", "1.99");
		builder.AddAttribute(41, "x", "16.66");
		builder.AddAttribute(42, "y", "16.66");
		builder.CloseElement();
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "height", "1.99");
		builder.AddAttribute(45, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -10.9791 9.8041)");
		builder.AddAttribute(46, "width", "3");
		builder.AddAttribute(47, "x", "4.85");
		builder.AddAttribute(48, "y", "17.16");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "d", "M15,8.02V3H9v5.02C7.79,8.94,7,10.37,7,12c0,2.76,2.24,5,5,5s5-2.24,5-5C17,10.37,16.21,8.94,15,8.02z M11,5h2v2.1 C12.68,7.04,12.34,7,12,7s-0.68,0.04-1,0.1V5z M12,15c-1.65,0-3-1.35-3-3s1.35-3,3-3c1.65,0,3,1.35,3,3S13.65,15,12,15z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
