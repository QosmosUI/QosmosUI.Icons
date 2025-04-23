// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcNews : ComponentBase
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
		builder.AddAttribute(14, "fill", "#FF5722");
		builder.AddAttribute(15, "d", "M32,15v28H10c-2.2,0-4-1.8-4-4V15H32z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#FFCCBC");
		builder.AddAttribute(18, "d", "M14,5v34c0,2.2-1.8,4-4,4h29c2.2,0,4-1.8,4-4V5H14z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#FF5722");
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "x", "20");
		builder.AddAttribute(23, "y", "10");
		builder.AddAttribute(24, "width", "18");
		builder.AddAttribute(25, "height", "4");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "x", "20");
		builder.AddAttribute(28, "y", "17");
		builder.AddAttribute(29, "width", "8");
		builder.AddAttribute(30, "height", "2");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "30");
		builder.AddAttribute(33, "y", "17");
		builder.AddAttribute(34, "width", "8");
		builder.AddAttribute(35, "height", "2");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "x", "20");
		builder.AddAttribute(38, "y", "21");
		builder.AddAttribute(39, "width", "8");
		builder.AddAttribute(40, "height", "2");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "30");
		builder.AddAttribute(43, "y", "21");
		builder.AddAttribute(44, "width", "8");
		builder.AddAttribute(45, "height", "2");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "x", "20");
		builder.AddAttribute(48, "y", "25");
		builder.AddAttribute(49, "width", "8");
		builder.AddAttribute(50, "height", "2");
		builder.CloseElement();
		builder.OpenElement(51, "rect");
		builder.AddAttribute(52, "x", "30");
		builder.AddAttribute(53, "y", "25");
		builder.AddAttribute(54, "width", "8");
		builder.AddAttribute(55, "height", "2");
		builder.CloseElement();
		builder.OpenElement(56, "rect");
		builder.AddAttribute(57, "x", "20");
		builder.AddAttribute(58, "y", "29");
		builder.AddAttribute(59, "width", "8");
		builder.AddAttribute(60, "height", "2");
		builder.CloseElement();
		builder.OpenElement(61, "rect");
		builder.AddAttribute(62, "x", "30");
		builder.AddAttribute(63, "y", "29");
		builder.AddAttribute(64, "width", "8");
		builder.AddAttribute(65, "height", "2");
		builder.CloseElement();
		builder.OpenElement(66, "rect");
		builder.AddAttribute(67, "x", "20");
		builder.AddAttribute(68, "y", "33");
		builder.AddAttribute(69, "width", "8");
		builder.AddAttribute(70, "height", "2");
		builder.CloseElement();
		builder.OpenElement(71, "rect");
		builder.AddAttribute(72, "x", "30");
		builder.AddAttribute(73, "y", "33");
		builder.AddAttribute(74, "width", "8");
		builder.AddAttribute(75, "height", "2");
		builder.CloseElement();
		builder.OpenElement(76, "rect");
		builder.AddAttribute(77, "x", "20");
		builder.AddAttribute(78, "y", "37");
		builder.AddAttribute(79, "width", "8");
		builder.AddAttribute(80, "height", "2");
		builder.CloseElement();
		builder.OpenElement(81, "rect");
		builder.AddAttribute(82, "x", "30");
		builder.AddAttribute(83, "y", "37");
		builder.AddAttribute(84, "width", "8");
		builder.AddAttribute(85, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
