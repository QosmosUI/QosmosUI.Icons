// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcInTransit : ComponentBase
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
		builder.AddAttribute(14, "fill", "#FFC107");
		builder.AddAttribute(15, "d", "M44,36H30V16c0-1.1,0.9-2,2-2h8c0.6,0,1.2,0.3,1.6,0.8l6,7.7c0.3,0.4,0.4,0.8,0.4,1.2V32 C48,34.2,46.2,36,44,36z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#9575CD");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M8,36h22V13c0-2.2-1.8-4-4-4H4v23C4,34.2,5.8,36,8,36z");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "y", "9");
		builder.AddAttribute(22, "width", "10");
		builder.AddAttribute(23, "height", "2");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "y", "14");
		builder.AddAttribute(26, "width", "10");
		builder.AddAttribute(27, "height", "2");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "y", "19");
		builder.AddAttribute(30, "width", "10");
		builder.AddAttribute(31, "height", "2");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "y", "24");
		builder.AddAttribute(34, "width", "10");
		builder.AddAttribute(35, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "g");
		builder.AddAttribute(37, "fill", "#7E57C2");
		builder.OpenElement(38, "rect");
		builder.AddAttribute(39, "x", "4");
		builder.AddAttribute(40, "y", "11");
		builder.AddAttribute(41, "width", "16");
		builder.AddAttribute(42, "height", "2");
		builder.CloseElement();
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "x", "4");
		builder.AddAttribute(45, "y", "16");
		builder.AddAttribute(46, "width", "12");
		builder.AddAttribute(47, "height", "2");
		builder.CloseElement();
		builder.OpenElement(48, "rect");
		builder.AddAttribute(49, "x", "4");
		builder.AddAttribute(50, "y", "21");
		builder.AddAttribute(51, "width", "8");
		builder.AddAttribute(52, "height", "2");
		builder.CloseElement();
		builder.OpenElement(53, "rect");
		builder.AddAttribute(54, "x", "4");
		builder.AddAttribute(55, "y", "26");
		builder.AddAttribute(56, "width", "4");
		builder.AddAttribute(57, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(58, "g");
		builder.AddAttribute(59, "fill", "#37474F");
		builder.OpenElement(60, "circle");
		builder.AddAttribute(61, "cx", "39");
		builder.AddAttribute(62, "cy", "36");
		builder.AddAttribute(63, "r", "5");
		builder.CloseElement();
		builder.OpenElement(64, "circle");
		builder.AddAttribute(65, "cx", "16");
		builder.AddAttribute(66, "cy", "36");
		builder.AddAttribute(67, "r", "5");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(68, "g");
		builder.AddAttribute(69, "fill", "#78909C");
		builder.OpenElement(70, "circle");
		builder.AddAttribute(71, "cx", "39");
		builder.AddAttribute(72, "cy", "36");
		builder.AddAttribute(73, "r", "2.5");
		builder.CloseElement();
		builder.OpenElement(74, "circle");
		builder.AddAttribute(75, "cx", "16");
		builder.AddAttribute(76, "cy", "36");
		builder.AddAttribute(77, "r", "2.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(78, "path");
		builder.AddAttribute(79, "fill", "#455A64");
		builder.AddAttribute(80, "d", "M44,26h-3.6c-0.3,0-0.5-0.1-0.7-0.3l-1.4-1.4c-0.2-0.2-0.4-0.3-0.7-0.3H34c-0.6,0-1-0.4-1-1v-6 c0-0.6,0.4-1,1-1h5.5c0.3,0,0.6,0.1,0.8,0.4l4.5,5.4c0.1,0.2,0.2,0.4,0.2,0.6V25C45,25.6,44.6,26,44,26z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
