// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneInsertPageBreak : ComponentBase
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
		builder.AddAttribute(21, "opacity", ".3");
		builder.AddAttribute(22, "points", "18,11 6,11 6,4 13,4 13,9 18,9");
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M18,20H6v-3H4v3c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2v-3h-2V20z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M6,4h7v5h5v2h2V8l-6-6H6C4.9,2,4,2.9,4,4v7h2V4z");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "height", "2");
		builder.AddAttribute(30, "width", "6");
		builder.AddAttribute(31, "x", "9");
		builder.AddAttribute(32, "y", "13");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "height", "2");
		builder.AddAttribute(35, "width", "6");
		builder.AddAttribute(36, "x", "17");
		builder.AddAttribute(37, "y", "13");
		builder.CloseElement();
		builder.OpenElement(38, "rect");
		builder.AddAttribute(39, "height", "2");
		builder.AddAttribute(40, "width", "6");
		builder.AddAttribute(41, "x", "1");
		builder.AddAttribute(42, "y", "13");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "height", "3");
		builder.AddAttribute(45, "opacity", ".3");
		builder.AddAttribute(46, "width", "12");
		builder.AddAttribute(47, "x", "6");
		builder.AddAttribute(48, "y", "17");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
