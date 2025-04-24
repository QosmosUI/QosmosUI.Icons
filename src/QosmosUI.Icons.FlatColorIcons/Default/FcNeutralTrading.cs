// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcNeutralTrading : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#1565C0");
		builder.OpenElement(15, "polygon");
		builder.AddAttribute(16, "points", "43.4,13 35,20 35,6");
		builder.CloseElement();
		builder.OpenElement(17, "rect");
		builder.AddAttribute(18, "x", "4");
		builder.AddAttribute(19, "y", "11");
		builder.AddAttribute(20, "width", "34");
		builder.AddAttribute(21, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#2196F3");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "40");
		builder.AddAttribute(26, "y", "23");
		builder.AddAttribute(27, "width", "4");
		builder.AddAttribute(28, "height", "19");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "34");
		builder.AddAttribute(31, "y", "23");
		builder.AddAttribute(32, "width", "4");
		builder.AddAttribute(33, "height", "19");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "28");
		builder.AddAttribute(36, "y", "23");
		builder.AddAttribute(37, "width", "4");
		builder.AddAttribute(38, "height", "19");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "22");
		builder.AddAttribute(41, "y", "23");
		builder.AddAttribute(42, "width", "4");
		builder.AddAttribute(43, "height", "19");
		builder.CloseElement();
		builder.OpenElement(44, "rect");
		builder.AddAttribute(45, "x", "16");
		builder.AddAttribute(46, "y", "23");
		builder.AddAttribute(47, "width", "4");
		builder.AddAttribute(48, "height", "19");
		builder.CloseElement();
		builder.OpenElement(49, "rect");
		builder.AddAttribute(50, "x", "10");
		builder.AddAttribute(51, "y", "23");
		builder.AddAttribute(52, "width", "4");
		builder.AddAttribute(53, "height", "19");
		builder.CloseElement();
		builder.OpenElement(54, "rect");
		builder.AddAttribute(55, "x", "4");
		builder.AddAttribute(56, "y", "23");
		builder.AddAttribute(57, "width", "4");
		builder.AddAttribute(58, "height", "19");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
