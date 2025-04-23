// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneGridView : ComponentBase
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
		builder.AddAttribute(21, "height", "4");
		builder.AddAttribute(22, "opacity", ".3");
		builder.AddAttribute(23, "width", "4");
		builder.AddAttribute(24, "x", "5");
		builder.AddAttribute(25, "y", "5");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "height", "4");
		builder.AddAttribute(28, "opacity", ".3");
		builder.AddAttribute(29, "width", "4");
		builder.AddAttribute(30, "x", "5");
		builder.AddAttribute(31, "y", "15");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "4");
		builder.AddAttribute(34, "opacity", ".3");
		builder.AddAttribute(35, "width", "4");
		builder.AddAttribute(36, "x", "15");
		builder.AddAttribute(37, "y", "15");
		builder.CloseElement();
		builder.OpenElement(38, "rect");
		builder.AddAttribute(39, "height", "4");
		builder.AddAttribute(40, "opacity", ".3");
		builder.AddAttribute(41, "width", "4");
		builder.AddAttribute(42, "x", "15");
		builder.AddAttribute(43, "y", "5");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "d", "M3,21h8v-8H3V21z M5,15h4v4H5V15z");
		builder.CloseElement();
		builder.OpenElement(46, "path");
		builder.AddAttribute(47, "d", "M3,11h8V3H3V11z M5,5h4v4H5V5z");
		builder.CloseElement();
		builder.OpenElement(48, "path");
		builder.AddAttribute(49, "d", "M13,21h8v-8h-8V21z M15,15h4v4h-4V15z");
		builder.CloseElement();
		builder.OpenElement(50, "path");
		builder.AddAttribute(51, "d", "M13,3v8h8V3H13z M19,9h-4V5h4V9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
