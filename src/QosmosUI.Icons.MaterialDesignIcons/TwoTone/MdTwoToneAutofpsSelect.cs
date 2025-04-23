// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneAutofpsSelect : ComponentBase
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
		builder.OpenElement(20, "polygon");
		builder.AddAttribute(21, "points", "12.03,6.3 11.97,6.3 10.95,9.19 13.05,9.19");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "height", "5");
		builder.AddAttribute(24, "width", "2");
		builder.AddAttribute(25, "x", "3");
		builder.AddAttribute(26, "y", "17");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M12,15c3.31,0,6-2.69,6-6s-2.69-6-6-6S6,5.69,6,9S8.69,15,12,15z M11.37,5h1.25l2.63,7h-1.21l-0.63-1.79h-2.83L9.96,12 H8.74L11.37,5z");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "height", "5");
		builder.AddAttribute(31, "width", "2");
		builder.AddAttribute(32, "x", "7");
		builder.AddAttribute(33, "y", "17");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "height", "5");
		builder.AddAttribute(36, "width", "2");
		builder.AddAttribute(37, "x", "11");
		builder.AddAttribute(38, "y", "17");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "height", "5");
		builder.AddAttribute(41, "width", "6");
		builder.AddAttribute(42, "x", "15");
		builder.AddAttribute(43, "y", "17");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
