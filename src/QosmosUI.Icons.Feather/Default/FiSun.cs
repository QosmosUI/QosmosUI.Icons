// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Feather.Default;

public class FiSun : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "12");
		builder.AddAttribute(15, "cy", "12");
		builder.AddAttribute(16, "r", "5");
		builder.CloseElement();
		builder.OpenElement(17, "line");
		builder.AddAttribute(18, "x1", "12");
		builder.AddAttribute(19, "y1", "1");
		builder.AddAttribute(20, "x2", "12");
		builder.AddAttribute(21, "y2", "3");
		builder.CloseElement();
		builder.OpenElement(22, "line");
		builder.AddAttribute(23, "x1", "12");
		builder.AddAttribute(24, "y1", "21");
		builder.AddAttribute(25, "x2", "12");
		builder.AddAttribute(26, "y2", "23");
		builder.CloseElement();
		builder.OpenElement(27, "line");
		builder.AddAttribute(28, "x1", "4.22");
		builder.AddAttribute(29, "y1", "4.22");
		builder.AddAttribute(30, "x2", "5.64");
		builder.AddAttribute(31, "y2", "5.64");
		builder.CloseElement();
		builder.OpenElement(32, "line");
		builder.AddAttribute(33, "x1", "18.36");
		builder.AddAttribute(34, "y1", "18.36");
		builder.AddAttribute(35, "x2", "19.78");
		builder.AddAttribute(36, "y2", "19.78");
		builder.CloseElement();
		builder.OpenElement(37, "line");
		builder.AddAttribute(38, "x1", "1");
		builder.AddAttribute(39, "y1", "12");
		builder.AddAttribute(40, "x2", "3");
		builder.AddAttribute(41, "y2", "12");
		builder.CloseElement();
		builder.OpenElement(42, "line");
		builder.AddAttribute(43, "x1", "21");
		builder.AddAttribute(44, "y1", "12");
		builder.AddAttribute(45, "x2", "23");
		builder.AddAttribute(46, "y2", "12");
		builder.CloseElement();
		builder.OpenElement(47, "line");
		builder.AddAttribute(48, "x1", "4.22");
		builder.AddAttribute(49, "y1", "19.78");
		builder.AddAttribute(50, "x2", "5.64");
		builder.AddAttribute(51, "y2", "18.36");
		builder.CloseElement();
		builder.OpenElement(52, "line");
		builder.AddAttribute(53, "x1", "18.36");
		builder.AddAttribute(54, "y1", "5.64");
		builder.AddAttribute(55, "x2", "19.78");
		builder.AddAttribute(56, "y2", "4.22");
		builder.CloseElement();
		builder.CloseElement();
    }
}
