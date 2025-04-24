// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcRules : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "#42A5F5");
		builder.AddAttribute(15, "d", "M39,45H9c0,0-3-0.1-3-8h36C42,44.9,39,45,39,45z");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "8");
		builder.AddAttribute(18, "y", "3");
		builder.AddAttribute(19, "fill", "#90CAF9");
		builder.AddAttribute(20, "width", "32");
		builder.AddAttribute(21, "height", "34");
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#1976D2");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "18");
		builder.AddAttribute(26, "y", "15");
		builder.AddAttribute(27, "width", "16");
		builder.AddAttribute(28, "height", "2");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "18");
		builder.AddAttribute(31, "y", "19");
		builder.AddAttribute(32, "width", "16");
		builder.AddAttribute(33, "height", "2");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "18");
		builder.AddAttribute(36, "y", "23");
		builder.AddAttribute(37, "width", "16");
		builder.AddAttribute(38, "height", "2");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "18");
		builder.AddAttribute(41, "y", "27");
		builder.AddAttribute(42, "width", "16");
		builder.AddAttribute(43, "height", "2");
		builder.CloseElement();
		builder.OpenElement(44, "rect");
		builder.AddAttribute(45, "x", "18");
		builder.AddAttribute(46, "y", "31");
		builder.AddAttribute(47, "width", "16");
		builder.AddAttribute(48, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(49, "g");
		builder.AddAttribute(50, "fill", "#1976D2");
		builder.OpenElement(51, "rect");
		builder.AddAttribute(52, "x", "14");
		builder.AddAttribute(53, "y", "15");
		builder.AddAttribute(54, "width", "2");
		builder.AddAttribute(55, "height", "2");
		builder.CloseElement();
		builder.OpenElement(56, "rect");
		builder.AddAttribute(57, "x", "14");
		builder.AddAttribute(58, "y", "19");
		builder.AddAttribute(59, "width", "2");
		builder.AddAttribute(60, "height", "2");
		builder.CloseElement();
		builder.OpenElement(61, "rect");
		builder.AddAttribute(62, "x", "14");
		builder.AddAttribute(63, "y", "23");
		builder.AddAttribute(64, "width", "2");
		builder.AddAttribute(65, "height", "2");
		builder.CloseElement();
		builder.OpenElement(66, "rect");
		builder.AddAttribute(67, "x", "14");
		builder.AddAttribute(68, "y", "27");
		builder.AddAttribute(69, "width", "2");
		builder.AddAttribute(70, "height", "2");
		builder.CloseElement();
		builder.OpenElement(71, "rect");
		builder.AddAttribute(72, "x", "14");
		builder.AddAttribute(73, "y", "31");
		builder.AddAttribute(74, "width", "2");
		builder.AddAttribute(75, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
