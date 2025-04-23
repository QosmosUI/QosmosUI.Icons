// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSportsCricket : ComponentBase
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
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "height", "10.02");
		builder.AddAttribute(22, "opacity", ".3");
		builder.AddAttribute(23, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -5.0045 9.2536)");
		builder.AddAttribute(24, "width", "2.01");
		builder.AddAttribute(25, "x", "7.66");
		builder.AddAttribute(26, "y", "5.66");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "18.5");
		builder.AddAttribute(29, "cy", "5.5");
		builder.AddAttribute(30, "opacity", ".3");
		builder.AddAttribute(31, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M15.04,12.79l-8.5-8.5C6.35,4.1,6.09,4,5.83,4S5.32,4.1,5.13,4.29L2.29,7.13c-0.39,0.39-0.39,1.03,0,1.42l8.5,8.5 c0.2,0.2,0.45,0.29,0.71,0.29c0.26,0,0.51-0.1,0.71-0.29l2.83-2.83C15.43,13.82,15.43,13.18,15.04,12.79z M11.5,14.92L4.41,7.83 l1.42-1.42l7.09,7.09L11.5,14.92z");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "height", "6");
		builder.AddAttribute(36, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -8.5264 17.7562)");
		builder.AddAttribute(37, "width", "2");
		builder.AddAttribute(38, "x", "16.17");
		builder.AddAttribute(39, "y", "16.17");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M18.5,2C16.57,2,15,3.57,15,5.5C15,7.43,16.57,9,18.5,9S22,7.43,22,5.5C22,3.57,20.43,2,18.5,2z M18.5,7 C17.67,7,17,6.33,17,5.5S17.67,4,18.5,4S20,4.67,20,5.5S19.33,7,18.5,7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
