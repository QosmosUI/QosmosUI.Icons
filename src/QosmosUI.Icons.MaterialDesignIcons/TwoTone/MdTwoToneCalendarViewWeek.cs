// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneCalendarViewWeek : ComponentBase
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
		builder.AddAttribute(20, "height", "12");
		builder.AddAttribute(21, "opacity", ".3");
		builder.AddAttribute(22, "width", "2.5");
		builder.AddAttribute(23, "x", "8.5");
		builder.AddAttribute(24, "y", "6");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "12");
		builder.AddAttribute(27, "opacity", ".3");
		builder.AddAttribute(28, "width", "2.5");
		builder.AddAttribute(29, "x", "13");
		builder.AddAttribute(30, "y", "6");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "height", "12");
		builder.AddAttribute(33, "opacity", ".3");
		builder.AddAttribute(34, "width", "2.5");
		builder.AddAttribute(35, "x", "4");
		builder.AddAttribute(36, "y", "6");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "height", "12");
		builder.AddAttribute(39, "opacity", ".3");
		builder.AddAttribute(40, "width", "2.5");
		builder.AddAttribute(41, "x", "17.5");
		builder.AddAttribute(42, "y", "6");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M20,4H4C2.9,4,2,4.9,2,6v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V6C22,4.9,21.1,4,20,4z M6.5,18H4V6h2.5V18z M11,18H8.5V6 H11V18z M15.5,18H13V6h2.5V18z M20,18h-2.5V6H20V18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
