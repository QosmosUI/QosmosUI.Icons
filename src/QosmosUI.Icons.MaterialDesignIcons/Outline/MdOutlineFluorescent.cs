// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineFluorescent : ComponentBase
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
		builder.AddAttribute(20, "d", "M5,15h14V9H5V15z M7,11h10v2H7V11z");
		builder.CloseElement();
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "height", "3");
		builder.AddAttribute(23, "width", "2");
		builder.AddAttribute(24, "x", "11");
		builder.AddAttribute(25, "y", "2");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "height", "2");
		builder.AddAttribute(28, "transform", "matrix(0.7046 -0.7096 0.7096 0.7046 1.1814 15.2381)");
		builder.AddAttribute(29, "width", "2.54");
		builder.AddAttribute(30, "x", "17.62");
		builder.AddAttribute(31, "y", "5.2");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "3");
		builder.AddAttribute(34, "width", "2");
		builder.AddAttribute(35, "x", "11");
		builder.AddAttribute(36, "y", "19");
		builder.CloseElement();
		builder.OpenElement(37, "polygon");
		builder.AddAttribute(38, "points", "17.29,17.71 19.08,19.51 20.5,18.09 18.7,16.3");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "height", "2.53");
		builder.AddAttribute(41, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -2.8904 5.4222)");
		builder.AddAttribute(42, "width", "1.99");
		builder.AddAttribute(43, "x", "4.1");
		builder.AddAttribute(44, "y", "4.93");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "height", "2");
		builder.AddAttribute(47, "transform", "matrix(0.7096 -0.7046 0.7046 0.7096 -11.1263 8.7897)");
		builder.AddAttribute(48, "width", "2.54");
		builder.AddAttribute(49, "x", "3.83");
		builder.AddAttribute(50, "y", "16.89");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
