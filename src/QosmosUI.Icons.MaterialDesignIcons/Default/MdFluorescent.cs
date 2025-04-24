// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Default;

public class MdFluorescent : ComponentBase
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
		builder.AddAttribute(20, "height", "6");
		builder.AddAttribute(21, "width", "14");
		builder.AddAttribute(22, "x", "5");
		builder.AddAttribute(23, "y", "9");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "3");
		builder.AddAttribute(26, "width", "2");
		builder.AddAttribute(27, "x", "11");
		builder.AddAttribute(28, "y", "2");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "height", "2");
		builder.AddAttribute(31, "transform", "matrix(0.7046 -0.7096 0.7096 0.7046 1.1814 15.2381)");
		builder.AddAttribute(32, "width", "2.54");
		builder.AddAttribute(33, "x", "17.62");
		builder.AddAttribute(34, "y", "5.2");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "height", "3");
		builder.AddAttribute(37, "width", "2");
		builder.AddAttribute(38, "x", "11");
		builder.AddAttribute(39, "y", "19");
		builder.CloseElement();
		builder.OpenElement(40, "polygon");
		builder.AddAttribute(41, "points", "17.29,17.71 19.08,19.51 20.5,18.09 18.7,16.3");
		builder.CloseElement();
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "height", "2.53");
		builder.AddAttribute(44, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -2.8904 5.4222)");
		builder.AddAttribute(45, "width", "1.99");
		builder.AddAttribute(46, "x", "4.1");
		builder.AddAttribute(47, "y", "4.93");
		builder.CloseElement();
		builder.OpenElement(48, "rect");
		builder.AddAttribute(49, "height", "2");
		builder.AddAttribute(50, "transform", "matrix(0.7096 -0.7046 0.7046 0.7096 -11.1263 8.7897)");
		builder.AddAttribute(51, "width", "2.54");
		builder.AddAttribute(52, "x", "3.83");
		builder.AddAttribute(53, "y", "16.89");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
