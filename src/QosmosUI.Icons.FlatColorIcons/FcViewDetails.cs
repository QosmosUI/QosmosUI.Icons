// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcViewDetails : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "x", "7");
		builder.AddAttribute(15, "y", "4");
		builder.AddAttribute(16, "fill", "#BBDEFB");
		builder.AddAttribute(17, "width", "34");
		builder.AddAttribute(18, "height", "40");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#2196F3");
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "x", "13");
		builder.AddAttribute(23, "y", "26");
		builder.AddAttribute(24, "width", "4");
		builder.AddAttribute(25, "height", "4");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "x", "13");
		builder.AddAttribute(28, "y", "18");
		builder.AddAttribute(29, "width", "4");
		builder.AddAttribute(30, "height", "4");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "13");
		builder.AddAttribute(33, "y", "34");
		builder.AddAttribute(34, "width", "4");
		builder.AddAttribute(35, "height", "4");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "x", "13");
		builder.AddAttribute(38, "y", "10");
		builder.AddAttribute(39, "width", "4");
		builder.AddAttribute(40, "height", "4");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "21");
		builder.AddAttribute(43, "y", "26");
		builder.AddAttribute(44, "width", "14");
		builder.AddAttribute(45, "height", "4");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "x", "21");
		builder.AddAttribute(48, "y", "18");
		builder.AddAttribute(49, "width", "14");
		builder.AddAttribute(50, "height", "4");
		builder.CloseElement();
		builder.OpenElement(51, "rect");
		builder.AddAttribute(52, "x", "21");
		builder.AddAttribute(53, "y", "34");
		builder.AddAttribute(54, "width", "14");
		builder.AddAttribute(55, "height", "4");
		builder.CloseElement();
		builder.OpenElement(56, "rect");
		builder.AddAttribute(57, "x", "21");
		builder.AddAttribute(58, "y", "10");
		builder.AddAttribute(59, "width", "14");
		builder.AddAttribute(60, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
