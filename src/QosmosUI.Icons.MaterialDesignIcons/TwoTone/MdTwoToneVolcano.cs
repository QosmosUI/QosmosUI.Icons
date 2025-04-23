// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneVolcano : ComponentBase
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
		builder.AddAttribute(22, "points", "16.49,10 12.35,10 10.86,13.74 10.35,15 9,15 7.3,15 5.08,20 19.35,20");
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M18,8h-7l-2,5H6l-4,9h20L18,8z M7.3,15H9h1.35l0.5-1.26l1.5-3.74h4.14l2.86,10H5.08L7.3,15z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(26, "g");
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "4");
		builder.AddAttribute(29, "width", "2");
		builder.AddAttribute(30, "x", "13");
		builder.AddAttribute(31, "y", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "height", "2");
		builder.AddAttribute(35, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 1.9792 14.2929)");
		builder.AddAttribute(36, "width", "4");
		builder.AddAttribute(37, "x", "16.24");
		builder.AddAttribute(38, "y", "3.76");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(39, "g");
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "height", "4");
		builder.AddAttribute(42, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -0.5061 8.2929)");
		builder.AddAttribute(43, "width", "2");
		builder.AddAttribute(44, "x", "8.76");
		builder.AddAttribute(45, "y", "2.76");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
