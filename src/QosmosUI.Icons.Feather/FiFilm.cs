// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Feather;

public class FiFilm : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "2");
		builder.AddAttribute(15, "y", "2");
		builder.AddAttribute(16, "width", "20");
		builder.AddAttribute(17, "height", "20");
		builder.AddAttribute(18, "rx", "2.18");
		builder.AddAttribute(19, "ry", "2.18");
		builder.CloseElement();
		builder.OpenElement(20, "line");
		builder.AddAttribute(21, "x1", "7");
		builder.AddAttribute(22, "y1", "2");
		builder.AddAttribute(23, "x2", "7");
		builder.AddAttribute(24, "y2", "22");
		builder.CloseElement();
		builder.OpenElement(25, "line");
		builder.AddAttribute(26, "x1", "17");
		builder.AddAttribute(27, "y1", "2");
		builder.AddAttribute(28, "x2", "17");
		builder.AddAttribute(29, "y2", "22");
		builder.CloseElement();
		builder.OpenElement(30, "line");
		builder.AddAttribute(31, "x1", "2");
		builder.AddAttribute(32, "y1", "12");
		builder.AddAttribute(33, "x2", "22");
		builder.AddAttribute(34, "y2", "12");
		builder.CloseElement();
		builder.OpenElement(35, "line");
		builder.AddAttribute(36, "x1", "2");
		builder.AddAttribute(37, "y1", "7");
		builder.AddAttribute(38, "x2", "7");
		builder.AddAttribute(39, "y2", "7");
		builder.CloseElement();
		builder.OpenElement(40, "line");
		builder.AddAttribute(41, "x1", "2");
		builder.AddAttribute(42, "y1", "17");
		builder.AddAttribute(43, "x2", "7");
		builder.AddAttribute(44, "y2", "17");
		builder.CloseElement();
		builder.OpenElement(45, "line");
		builder.AddAttribute(46, "x1", "17");
		builder.AddAttribute(47, "y1", "17");
		builder.AddAttribute(48, "x2", "22");
		builder.AddAttribute(49, "y2", "17");
		builder.CloseElement();
		builder.OpenElement(50, "line");
		builder.AddAttribute(51, "x1", "17");
		builder.AddAttribute(52, "y1", "7");
		builder.AddAttribute(53, "x2", "22");
		builder.AddAttribute(54, "y2", "7");
		builder.CloseElement();
		builder.CloseElement();
    }
}
