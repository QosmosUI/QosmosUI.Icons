// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoSnowOutline : ComponentBase
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
		builder.OpenElement(13, "line");
		builder.AddAttribute(14, "x1", "256");
		builder.AddAttribute(15, "y1", "32");
		builder.AddAttribute(16, "x2", "256");
		builder.AddAttribute(17, "y2", "480");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "stroke-linecap", "round");
		builder.AddAttribute(20, "stroke-linejoin", "round");
		builder.AddAttribute(21, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M313.72,80A111.47,111.47,0,0,1,256,96a111.47,111.47,0,0,1-57.72-16");
		builder.AddAttribute(24, "fill", "none");
		builder.AddAttribute(25, "stroke-linecap", "round");
		builder.AddAttribute(26, "stroke-linejoin", "round");
		builder.AddAttribute(27, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M198.28,432a112.11,112.11,0,0,1,115.44,0");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linecap", "round");
		builder.AddAttribute(32, "stroke-linejoin", "round");
		builder.AddAttribute(33, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(34, "line");
		builder.AddAttribute(35, "x1", "449.99");
		builder.AddAttribute(36, "y1", "144");
		builder.AddAttribute(37, "x2", "62.01");
		builder.AddAttribute(38, "y2", "368");
		builder.AddAttribute(39, "fill", "none");
		builder.AddAttribute(40, "stroke-linecap", "round");
		builder.AddAttribute(41, "stroke-linejoin", "round");
		builder.AddAttribute(42, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M437.27,218a112.09,112.09,0,0,1-57.71-100");
		builder.AddAttribute(45, "fill", "none");
		builder.AddAttribute(46, "stroke-linecap", "round");
		builder.AddAttribute(47, "stroke-linejoin", "round");
		builder.AddAttribute(48, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "d", "M74.73,294a112.09,112.09,0,0,1,57.71,100");
		builder.AddAttribute(51, "fill", "none");
		builder.AddAttribute(52, "stroke-linecap", "round");
		builder.AddAttribute(53, "stroke-linejoin", "round");
		builder.AddAttribute(54, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(55, "line");
		builder.AddAttribute(56, "x1", "62.01");
		builder.AddAttribute(57, "y1", "144");
		builder.AddAttribute(58, "x2", "449.99");
		builder.AddAttribute(59, "y2", "368");
		builder.AddAttribute(60, "fill", "none");
		builder.AddAttribute(61, "stroke-linecap", "round");
		builder.AddAttribute(62, "stroke-linejoin", "round");
		builder.AddAttribute(63, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(64, "path");
		builder.AddAttribute(65, "d", "M74.73,218a112.09,112.09,0,0,0,57.71-100");
		builder.AddAttribute(66, "fill", "none");
		builder.AddAttribute(67, "stroke-linecap", "round");
		builder.AddAttribute(68, "stroke-linejoin", "round");
		builder.AddAttribute(69, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(70, "path");
		builder.AddAttribute(71, "d", "M437.27,294a112.09,112.09,0,0,0-57.71,100");
		builder.AddAttribute(72, "fill", "none");
		builder.AddAttribute(73, "stroke-linecap", "round");
		builder.AddAttribute(74, "stroke-linejoin", "round");
		builder.AddAttribute(75, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
