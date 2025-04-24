// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Lucide.Default;

public class LuSlidersHorizontal : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "2";

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
		builder.OpenElement(13, "line");
		builder.AddAttribute(14, "x1", "21");
		builder.AddAttribute(15, "x2", "14");
		builder.AddAttribute(16, "y1", "4");
		builder.AddAttribute(17, "y2", "4");
		builder.CloseElement();
		builder.OpenElement(18, "line");
		builder.AddAttribute(19, "x1", "10");
		builder.AddAttribute(20, "x2", "3");
		builder.AddAttribute(21, "y1", "4");
		builder.AddAttribute(22, "y2", "4");
		builder.CloseElement();
		builder.OpenElement(23, "line");
		builder.AddAttribute(24, "x1", "21");
		builder.AddAttribute(25, "x2", "12");
		builder.AddAttribute(26, "y1", "12");
		builder.AddAttribute(27, "y2", "12");
		builder.CloseElement();
		builder.OpenElement(28, "line");
		builder.AddAttribute(29, "x1", "8");
		builder.AddAttribute(30, "x2", "3");
		builder.AddAttribute(31, "y1", "12");
		builder.AddAttribute(32, "y2", "12");
		builder.CloseElement();
		builder.OpenElement(33, "line");
		builder.AddAttribute(34, "x1", "21");
		builder.AddAttribute(35, "x2", "16");
		builder.AddAttribute(36, "y1", "20");
		builder.AddAttribute(37, "y2", "20");
		builder.CloseElement();
		builder.OpenElement(38, "line");
		builder.AddAttribute(39, "x1", "12");
		builder.AddAttribute(40, "x2", "3");
		builder.AddAttribute(41, "y1", "20");
		builder.AddAttribute(42, "y2", "20");
		builder.CloseElement();
		builder.OpenElement(43, "line");
		builder.AddAttribute(44, "x1", "14");
		builder.AddAttribute(45, "x2", "14");
		builder.AddAttribute(46, "y1", "2");
		builder.AddAttribute(47, "y2", "6");
		builder.CloseElement();
		builder.OpenElement(48, "line");
		builder.AddAttribute(49, "x1", "8");
		builder.AddAttribute(50, "x2", "8");
		builder.AddAttribute(51, "y1", "10");
		builder.AddAttribute(52, "y2", "14");
		builder.CloseElement();
		builder.OpenElement(53, "line");
		builder.AddAttribute(54, "x1", "16");
		builder.AddAttribute(55, "x2", "16");
		builder.AddAttribute(56, "y1", "18");
		builder.AddAttribute(57, "y2", "22");
		builder.CloseElement();
		builder.CloseElement();
    }
}
