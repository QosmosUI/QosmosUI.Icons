// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneBlindsClosed : ComponentBase
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
		builder.AddAttribute(21, "height", "2");
		builder.AddAttribute(22, "opacity", ".3");
		builder.AddAttribute(23, "width", "8");
		builder.AddAttribute(24, "x", "6");
		builder.AddAttribute(25, "y", "5");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "height", "2");
		builder.AddAttribute(28, "opacity", ".3");
		builder.AddAttribute(29, "width", "8");
		builder.AddAttribute(30, "x", "6");
		builder.AddAttribute(31, "y", "9");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "2");
		builder.AddAttribute(34, "opacity", ".3");
		builder.AddAttribute(35, "width", "2");
		builder.AddAttribute(36, "x", "16");
		builder.AddAttribute(37, "y", "17");
		builder.CloseElement();
		builder.OpenElement(38, "rect");
		builder.AddAttribute(39, "height", "2");
		builder.AddAttribute(40, "opacity", ".3");
		builder.AddAttribute(41, "width", "8");
		builder.AddAttribute(42, "x", "6");
		builder.AddAttribute(43, "y", "13");
		builder.CloseElement();
		builder.OpenElement(44, "rect");
		builder.AddAttribute(45, "height", "2");
		builder.AddAttribute(46, "opacity", ".3");
		builder.AddAttribute(47, "width", "8");
		builder.AddAttribute(48, "x", "6");
		builder.AddAttribute(49, "y", "17");
		builder.CloseElement();
		builder.OpenElement(50, "rect");
		builder.AddAttribute(51, "height", "2");
		builder.AddAttribute(52, "opacity", ".3");
		builder.AddAttribute(53, "width", "2");
		builder.AddAttribute(54, "x", "16");
		builder.AddAttribute(55, "y", "13");
		builder.CloseElement();
		builder.OpenElement(56, "rect");
		builder.AddAttribute(57, "height", "2");
		builder.AddAttribute(58, "opacity", ".3");
		builder.AddAttribute(59, "width", "2");
		builder.AddAttribute(60, "x", "16");
		builder.AddAttribute(61, "y", "5");
		builder.CloseElement();
		builder.OpenElement(62, "rect");
		builder.AddAttribute(63, "height", "2");
		builder.AddAttribute(64, "opacity", ".3");
		builder.AddAttribute(65, "width", "2");
		builder.AddAttribute(66, "x", "16");
		builder.AddAttribute(67, "y", "9");
		builder.CloseElement();
		builder.OpenElement(68, "path");
		builder.AddAttribute(69, "d", "M20,19V3H4v16H2v2h11.25c0,0.97,0.78,1.75,1.75,1.75s1.75-0.78,1.75-1.75H22v-2H20z M14,19H6v-2h8V19z M14,15H6v-2h8V15z M14,11H6V9h8V11z M14,7H6V5h8V7z M18,19h-2v-2h2V19z M18,15h-2v-2h2V15z M18,11h-2V9h2V11z M18,7h-2V5h2V7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
