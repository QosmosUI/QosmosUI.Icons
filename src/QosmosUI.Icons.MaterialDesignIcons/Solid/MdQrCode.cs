// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdQrCode : ComponentBase
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
		builder.AddAttribute(21, "d", "M3,11h8V3H3V11z M5,5h4v4H5V5z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M3,21h8v-8H3V21z M5,15h4v4H5V15z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M13,3v8h8V3H13z M19,9h-4V5h4V9z");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "height", "2");
		builder.AddAttribute(28, "width", "2");
		builder.AddAttribute(29, "x", "19");
		builder.AddAttribute(30, "y", "19");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "height", "2");
		builder.AddAttribute(33, "width", "2");
		builder.AddAttribute(34, "x", "13");
		builder.AddAttribute(35, "y", "13");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "height", "2");
		builder.AddAttribute(38, "width", "2");
		builder.AddAttribute(39, "x", "15");
		builder.AddAttribute(40, "y", "15");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "height", "2");
		builder.AddAttribute(43, "width", "2");
		builder.AddAttribute(44, "x", "13");
		builder.AddAttribute(45, "y", "17");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "height", "2");
		builder.AddAttribute(48, "width", "2");
		builder.AddAttribute(49, "x", "15");
		builder.AddAttribute(50, "y", "19");
		builder.CloseElement();
		builder.OpenElement(51, "rect");
		builder.AddAttribute(52, "height", "2");
		builder.AddAttribute(53, "width", "2");
		builder.AddAttribute(54, "x", "17");
		builder.AddAttribute(55, "y", "17");
		builder.CloseElement();
		builder.OpenElement(56, "rect");
		builder.AddAttribute(57, "height", "2");
		builder.AddAttribute(58, "width", "2");
		builder.AddAttribute(59, "x", "17");
		builder.AddAttribute(60, "y", "13");
		builder.CloseElement();
		builder.OpenElement(61, "rect");
		builder.AddAttribute(62, "height", "2");
		builder.AddAttribute(63, "width", "2");
		builder.AddAttribute(64, "x", "19");
		builder.AddAttribute(65, "y", "15");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
