// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoApertureOutline : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M448,256c0-106-86-192-192-192S64,150,64,256s86,192,192,192S448,362,448,256Z");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-miterlimit", "10");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "line");
		builder.AddAttribute(19, "x1", "360");
		builder.AddAttribute(20, "y1", "94.59");
		builder.AddAttribute(21, "x2", "360");
		builder.AddAttribute(22, "y2", "296");
		builder.AddAttribute(23, "fill", "none");
		builder.AddAttribute(24, "stroke-linecap", "round");
		builder.AddAttribute(25, "stroke-linejoin", "round");
		builder.AddAttribute(26, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(27, "line");
		builder.AddAttribute(28, "x1", "443.13");
		builder.AddAttribute(29, "y1", "212.87");
		builder.AddAttribute(30, "x2", "296");
		builder.AddAttribute(31, "y2", "360");
		builder.AddAttribute(32, "fill", "none");
		builder.AddAttribute(33, "stroke-linecap", "round");
		builder.AddAttribute(34, "stroke-linejoin", "round");
		builder.AddAttribute(35, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(36, "line");
		builder.AddAttribute(37, "x1", "417.41");
		builder.AddAttribute(38, "y1", "360");
		builder.AddAttribute(39, "x2", "216");
		builder.AddAttribute(40, "y2", "360");
		builder.AddAttribute(41, "fill", "none");
		builder.AddAttribute(42, "stroke-linecap", "round");
		builder.AddAttribute(43, "stroke-linejoin", "round");
		builder.AddAttribute(44, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(45, "line");
		builder.AddAttribute(46, "x1", "299.13");
		builder.AddAttribute(47, "y1", "443.13");
		builder.AddAttribute(48, "x2", "155.13");
		builder.AddAttribute(49, "y2", "299.13");
		builder.AddAttribute(50, "fill", "none");
		builder.AddAttribute(51, "stroke-linecap", "round");
		builder.AddAttribute(52, "stroke-linejoin", "round");
		builder.AddAttribute(53, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(54, "line");
		builder.AddAttribute(55, "x1", "152");
		builder.AddAttribute(56, "y1", "416");
		builder.AddAttribute(57, "x2", "152");
		builder.AddAttribute(58, "y2", "216");
		builder.AddAttribute(59, "fill", "none");
		builder.AddAttribute(60, "stroke-linecap", "round");
		builder.AddAttribute(61, "stroke-linejoin", "round");
		builder.AddAttribute(62, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(63, "line");
		builder.AddAttribute(64, "x1", "68.87");
		builder.AddAttribute(65, "y1", "299.13");
		builder.AddAttribute(66, "x2", "212.87");
		builder.AddAttribute(67, "y2", "155.13");
		builder.AddAttribute(68, "fill", "none");
		builder.AddAttribute(69, "stroke-linecap", "round");
		builder.AddAttribute(70, "stroke-linejoin", "round");
		builder.AddAttribute(71, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(72, "line");
		builder.AddAttribute(73, "x1", "94.59");
		builder.AddAttribute(74, "y1", "152");
		builder.AddAttribute(75, "x2", "288");
		builder.AddAttribute(76, "y2", "152");
		builder.AddAttribute(77, "fill", "none");
		builder.AddAttribute(78, "stroke-linecap", "round");
		builder.AddAttribute(79, "stroke-linejoin", "round");
		builder.AddAttribute(80, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(81, "line");
		builder.AddAttribute(82, "x1", "212.87");
		builder.AddAttribute(83, "y1", "68.87");
		builder.AddAttribute(84, "x2", "360");
		builder.AddAttribute(85, "y2", "216");
		builder.AddAttribute(86, "fill", "none");
		builder.AddAttribute(87, "stroke-linecap", "round");
		builder.AddAttribute(88, "stroke-linejoin", "round");
		builder.AddAttribute(89, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
