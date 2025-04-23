// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneCalendarViewMonth : ComponentBase
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
		builder.AddAttribute(20, "height", "5");
		builder.AddAttribute(21, "opacity", ".3");
		builder.AddAttribute(22, "width", "4");
		builder.AddAttribute(23, "x", "4");
		builder.AddAttribute(24, "y", "6");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "5");
		builder.AddAttribute(27, "opacity", ".3");
		builder.AddAttribute(28, "width", "4");
		builder.AddAttribute(29, "x", "4");
		builder.AddAttribute(30, "y", "13");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "height", "5");
		builder.AddAttribute(33, "opacity", ".3");
		builder.AddAttribute(34, "width", "4");
		builder.AddAttribute(35, "x", "10");
		builder.AddAttribute(36, "y", "13");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "height", "5");
		builder.AddAttribute(39, "opacity", ".3");
		builder.AddAttribute(40, "width", "4");
		builder.AddAttribute(41, "x", "16");
		builder.AddAttribute(42, "y", "13");
		builder.CloseElement();
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "height", "5");
		builder.AddAttribute(45, "opacity", ".3");
		builder.AddAttribute(46, "width", "4");
		builder.AddAttribute(47, "x", "16");
		builder.AddAttribute(48, "y", "6");
		builder.CloseElement();
		builder.OpenElement(49, "rect");
		builder.AddAttribute(50, "height", "5");
		builder.AddAttribute(51, "opacity", ".3");
		builder.AddAttribute(52, "width", "4");
		builder.AddAttribute(53, "x", "10");
		builder.AddAttribute(54, "y", "6");
		builder.CloseElement();
		builder.OpenElement(55, "path");
		builder.AddAttribute(56, "d", "M20,4H4C2.9,4,2,4.9,2,6v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V6C22,4.9,21.1,4,20,4z M8,18H4v-5h4V18z M8,11H4V6h4V11z M14,18h-4v-5h4V18z M14,11h-4V6h4V11z M20,18h-4v-5h4V18z M20,11h-4V6h4V11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
