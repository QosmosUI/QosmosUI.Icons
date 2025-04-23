// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneMargin : ComponentBase
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
		builder.AddAttribute(21, "d", "M5,19h14V5H5V19z M15,7h2v2h-2V7z M15,11h2v2h-2V11z M11,7h2v2h-2V7z M11,11h2v2h-2V11z M7,7h2v2H7V7z M7,11h2v2H7V11z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "height", "2");
		builder.AddAttribute(25, "width", "2");
		builder.AddAttribute(26, "x", "7");
		builder.AddAttribute(27, "y", "7");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "height", "2");
		builder.AddAttribute(30, "width", "2");
		builder.AddAttribute(31, "x", "7");
		builder.AddAttribute(32, "y", "11");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M3,3v18h18V3H3z M19,19H5V5h14V19z");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "height", "2");
		builder.AddAttribute(37, "width", "2");
		builder.AddAttribute(38, "x", "11");
		builder.AddAttribute(39, "y", "7");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "height", "2");
		builder.AddAttribute(42, "width", "2");
		builder.AddAttribute(43, "x", "15");
		builder.AddAttribute(44, "y", "11");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "height", "2");
		builder.AddAttribute(47, "width", "2");
		builder.AddAttribute(48, "x", "11");
		builder.AddAttribute(49, "y", "11");
		builder.CloseElement();
		builder.OpenElement(50, "rect");
		builder.AddAttribute(51, "height", "2");
		builder.AddAttribute(52, "width", "2");
		builder.AddAttribute(53, "x", "15");
		builder.AddAttribute(54, "y", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
