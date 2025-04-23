// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcList : ComponentBase
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
		builder.AddAttribute(14, "fill", "#2196F3");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "6");
		builder.AddAttribute(17, "y", "22");
		builder.AddAttribute(18, "width", "4");
		builder.AddAttribute(19, "height", "4");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "6");
		builder.AddAttribute(22, "y", "14");
		builder.AddAttribute(23, "width", "4");
		builder.AddAttribute(24, "height", "4");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "6");
		builder.AddAttribute(27, "y", "30");
		builder.AddAttribute(28, "width", "4");
		builder.AddAttribute(29, "height", "4");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "x", "6");
		builder.AddAttribute(32, "y", "6");
		builder.AddAttribute(33, "width", "4");
		builder.AddAttribute(34, "height", "4");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "6");
		builder.AddAttribute(37, "y", "38");
		builder.AddAttribute(38, "width", "4");
		builder.AddAttribute(39, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(40, "g");
		builder.AddAttribute(41, "fill", "#2196F3");
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "x", "14");
		builder.AddAttribute(44, "y", "22");
		builder.AddAttribute(45, "width", "28");
		builder.AddAttribute(46, "height", "4");
		builder.CloseElement();
		builder.OpenElement(47, "rect");
		builder.AddAttribute(48, "x", "14");
		builder.AddAttribute(49, "y", "14");
		builder.AddAttribute(50, "width", "28");
		builder.AddAttribute(51, "height", "4");
		builder.CloseElement();
		builder.OpenElement(52, "rect");
		builder.AddAttribute(53, "x", "14");
		builder.AddAttribute(54, "y", "30");
		builder.AddAttribute(55, "width", "28");
		builder.AddAttribute(56, "height", "4");
		builder.CloseElement();
		builder.OpenElement(57, "rect");
		builder.AddAttribute(58, "x", "14");
		builder.AddAttribute(59, "y", "6");
		builder.AddAttribute(60, "width", "28");
		builder.AddAttribute(61, "height", "4");
		builder.CloseElement();
		builder.OpenElement(62, "rect");
		builder.AddAttribute(63, "x", "14");
		builder.AddAttribute(64, "y", "38");
		builder.AddAttribute(65, "width", "28");
		builder.AddAttribute(66, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
