// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneAutoFixOff : ComponentBase
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
		builder.AddAttribute(18, "x", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "height", "2");
		builder.AddAttribute(23, "opacity", ".3");
		builder.AddAttribute(24, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -9.117 10.2825)");
		builder.AddAttribute(25, "width", "7.73");
		builder.AddAttribute(26, "x", "3.99");
		builder.AddAttribute(27, "y", "15.15");
		builder.CloseElement();
		builder.OpenElement(28, "polygon");
		builder.AddAttribute(29, "points", "20,7 20.94,4.94 23,4 20.94,3.06 20,1 19.06,3.06 17,4 19.06,4.94");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M14.17,8.42l1.41,1.41l-1.46,1.46l1.41,1.41l2.17-2.17c0.39-0.39,0.39-1.02,0-1.41l-2.83-2.83C14.68,6.1,14.43,6,14.17,6 c-0.26,0-0.51,0.1-0.71,0.29l-2.17,2.17l1.41,1.41L14.17,8.42z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M2.81,2.81L1.39,4.22l7.07,7.07l-6.17,6.17c-0.39,0.39-0.39,1.02,0,1.41l2.83,2.83C5.32,21.9,5.57,22,5.83,22 s0.51-0.1,0.71-0.29l6.17-6.17l7.07,7.07l1.41-1.41L2.81,2.81z M5.83,19.59l-1.41-1.41l5.46-5.46l1.41,1.41L5.83,19.59z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
