// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdAddRoad : ComponentBase
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
		builder.AddAttribute(21, "points", "20,18 20,15 18,15 18,18 15,18 15,20 18,20 18,23 20,23 20,20 23,20 23,18");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "height", "9");
		builder.AddAttribute(24, "width", "2");
		builder.AddAttribute(25, "x", "18");
		builder.AddAttribute(26, "y", "4");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "16");
		builder.AddAttribute(29, "width", "2");
		builder.AddAttribute(30, "x", "4");
		builder.AddAttribute(31, "y", "4");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "4");
		builder.AddAttribute(34, "width", "2");
		builder.AddAttribute(35, "x", "11");
		builder.AddAttribute(36, "y", "4");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "height", "4");
		builder.AddAttribute(39, "width", "2");
		builder.AddAttribute(40, "x", "11");
		builder.AddAttribute(41, "y", "10");
		builder.CloseElement();
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "height", "4");
		builder.AddAttribute(44, "width", "2");
		builder.AddAttribute(45, "x", "11");
		builder.AddAttribute(46, "y", "16");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
