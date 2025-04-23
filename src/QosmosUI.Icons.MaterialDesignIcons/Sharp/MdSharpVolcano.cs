// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpVolcano : ComponentBase
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
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "points", "18,8 11,8 9,13 6,13 2,22 22,22");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "4");
		builder.AddAttribute(26, "width", "2");
		builder.AddAttribute(27, "x", "13");
		builder.AddAttribute(28, "y", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(29, "g");
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "height", "2");
		builder.AddAttribute(32, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 1.9792 14.2929)");
		builder.AddAttribute(33, "width", "4");
		builder.AddAttribute(34, "x", "16.24");
		builder.AddAttribute(35, "y", "3.76");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "g");
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "height", "4");
		builder.AddAttribute(39, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -0.5061 8.2929)");
		builder.AddAttribute(40, "width", "2");
		builder.AddAttribute(41, "x", "8.76");
		builder.AddAttribute(42, "y", "2.76");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
