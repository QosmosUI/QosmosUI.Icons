// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpTungsten : ComponentBase
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
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "height", "3");
		builder.AddAttribute(21, "width", "2");
		builder.AddAttribute(22, "x", "11");
		builder.AddAttribute(23, "y", "19");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "2");
		builder.AddAttribute(26, "width", "3");
		builder.AddAttribute(27, "x", "2");
		builder.AddAttribute(28, "y", "11");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "height", "2");
		builder.AddAttribute(31, "width", "3");
		builder.AddAttribute(32, "x", "19");
		builder.AddAttribute(33, "y", "11");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "height", "3");
		builder.AddAttribute(36, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -7.6665 17.8014)");
		builder.AddAttribute(37, "width", "1.99");
		builder.AddAttribute(38, "x", "16.66");
		builder.AddAttribute(39, "y", "16.66");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "height", "1.99");
		builder.AddAttribute(42, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -10.9791 9.8041)");
		builder.AddAttribute(43, "width", "3");
		builder.AddAttribute(44, "x", "4.85");
		builder.AddAttribute(45, "y", "17.16");
		builder.CloseElement();
		builder.OpenElement(46, "path");
		builder.AddAttribute(47, "d", "M15,8.02V3H9v5.02C7.79,8.94,7,10.37,7,12c0,2.76,2.24,5,5,5s5-2.24,5-5C17,10.37,16.21,8.94,15,8.02z M11,5h2v2.1 C12.68,7.04,12.34,7,12,7s-0.68,0.04-1,0.1V5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
