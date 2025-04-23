// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoBusOutline : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "80");
		builder.AddAttribute(15, "y", "112");
		builder.AddAttribute(16, "width", "352");
		builder.AddAttribute(17, "height", "192");
		builder.AddAttribute(18, "rx", "32");
		builder.AddAttribute(19, "ry", "32");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linecap", "round");
		builder.AddAttribute(22, "stroke-linejoin", "round");
		builder.AddAttribute(23, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "80");
		builder.AddAttribute(26, "y", "304");
		builder.AddAttribute(27, "width", "352");
		builder.AddAttribute(28, "height", "128");
		builder.AddAttribute(29, "rx", "32");
		builder.AddAttribute(30, "ry", "32");
		builder.AddAttribute(31, "fill", "none");
		builder.AddAttribute(32, "stroke-linecap", "round");
		builder.AddAttribute(33, "stroke-linejoin", "round");
		builder.AddAttribute(34, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M400,112H112A32.09,32.09,0,0,1,80,80h0a32.09,32.09,0,0,1,32-32H400a32.09,32.09,0,0,1,32,32h0A32.09,32.09,0,0,1,400,112Z");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-linecap", "round");
		builder.AddAttribute(39, "stroke-linejoin", "round");
		builder.AddAttribute(40, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M144,432v22a10,10,0,0,1-10,10H106a10,10,0,0,1-10-10V432Z");
		builder.AddAttribute(43, "fill", "none");
		builder.AddAttribute(44, "stroke-linecap", "round");
		builder.AddAttribute(45, "stroke-linejoin", "round");
		builder.AddAttribute(46, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(47, "path");
		builder.AddAttribute(48, "d", "M416,432v22a10,10,0,0,1-10,10H378a10,10,0,0,1-10-10V432Z");
		builder.AddAttribute(49, "fill", "none");
		builder.AddAttribute(50, "stroke-linecap", "round");
		builder.AddAttribute(51, "stroke-linejoin", "round");
		builder.AddAttribute(52, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(53, "circle");
		builder.AddAttribute(54, "cx", "368");
		builder.AddAttribute(55, "cy", "368");
		builder.AddAttribute(56, "r", "16");
		builder.AddAttribute(57, "fill", "none");
		builder.AddAttribute(58, "stroke-linejoin", "round");
		builder.AddAttribute(59, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(60, "circle");
		builder.AddAttribute(61, "cx", "144");
		builder.AddAttribute(62, "cy", "368");
		builder.AddAttribute(63, "r", "16");
		builder.AddAttribute(64, "fill", "none");
		builder.AddAttribute(65, "stroke-linejoin", "round");
		builder.AddAttribute(66, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(67, "line");
		builder.AddAttribute(68, "x1", "256");
		builder.AddAttribute(69, "y1", "112");
		builder.AddAttribute(70, "x2", "256");
		builder.AddAttribute(71, "y2", "304");
		builder.AddAttribute(72, "fill", "none");
		builder.AddAttribute(73, "stroke-linecap", "round");
		builder.AddAttribute(74, "stroke-linejoin", "round");
		builder.AddAttribute(75, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(76, "line");
		builder.AddAttribute(77, "x1", "80");
		builder.AddAttribute(78, "y1", "80");
		builder.AddAttribute(79, "x2", "80");
		builder.AddAttribute(80, "y2", "368");
		builder.AddAttribute(81, "fill", "none");
		builder.AddAttribute(82, "stroke-linecap", "round");
		builder.AddAttribute(83, "stroke-linejoin", "round");
		builder.AddAttribute(84, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(85, "line");
		builder.AddAttribute(86, "x1", "432");
		builder.AddAttribute(87, "y1", "80");
		builder.AddAttribute(88, "x2", "432");
		builder.AddAttribute(89, "y2", "368");
		builder.AddAttribute(90, "fill", "none");
		builder.AddAttribute(91, "stroke-linecap", "round");
		builder.AddAttribute(92, "stroke-linejoin", "round");
		builder.AddAttribute(93, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
