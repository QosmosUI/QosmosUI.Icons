// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoHelpBuoyOutline : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "256");
		builder.AddAttribute(15, "cy", "256");
		builder.AddAttribute(16, "r", "208");
		builder.AddAttribute(17, "fill", "none");
		builder.AddAttribute(18, "stroke-linecap", "round");
		builder.AddAttribute(19, "stroke-linejoin", "round");
		builder.AddAttribute(20, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "256");
		builder.AddAttribute(23, "cy", "256");
		builder.AddAttribute(24, "r", "80");
		builder.AddAttribute(25, "fill", "none");
		builder.AddAttribute(26, "stroke-linecap", "round");
		builder.AddAttribute(27, "stroke-linejoin", "round");
		builder.AddAttribute(28, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(29, "line");
		builder.AddAttribute(30, "x1", "208");
		builder.AddAttribute(31, "y1", "54");
		builder.AddAttribute(32, "x2", "216");
		builder.AddAttribute(33, "y2", "186");
		builder.AddAttribute(34, "fill", "none");
		builder.AddAttribute(35, "stroke-linecap", "round");
		builder.AddAttribute(36, "stroke-linejoin", "round");
		builder.AddAttribute(37, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(38, "line");
		builder.AddAttribute(39, "x1", "296");
		builder.AddAttribute(40, "y1", "186");
		builder.AddAttribute(41, "x2", "304");
		builder.AddAttribute(42, "y2", "54");
		builder.AddAttribute(43, "fill", "none");
		builder.AddAttribute(44, "stroke-linecap", "round");
		builder.AddAttribute(45, "stroke-linejoin", "round");
		builder.AddAttribute(46, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(47, "line");
		builder.AddAttribute(48, "x1", "208");
		builder.AddAttribute(49, "y1", "458");
		builder.AddAttribute(50, "x2", "216");
		builder.AddAttribute(51, "y2", "326");
		builder.AddAttribute(52, "fill", "none");
		builder.AddAttribute(53, "stroke-linecap", "round");
		builder.AddAttribute(54, "stroke-linejoin", "round");
		builder.AddAttribute(55, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(56, "line");
		builder.AddAttribute(57, "x1", "296");
		builder.AddAttribute(58, "y1", "326");
		builder.AddAttribute(59, "x2", "304");
		builder.AddAttribute(60, "y2", "458");
		builder.AddAttribute(61, "fill", "none");
		builder.AddAttribute(62, "stroke-linecap", "round");
		builder.AddAttribute(63, "stroke-linejoin", "round");
		builder.AddAttribute(64, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(65, "line");
		builder.AddAttribute(66, "x1", "458");
		builder.AddAttribute(67, "y1", "208");
		builder.AddAttribute(68, "x2", "326");
		builder.AddAttribute(69, "y2", "216");
		builder.AddAttribute(70, "fill", "none");
		builder.AddAttribute(71, "stroke-linecap", "round");
		builder.AddAttribute(72, "stroke-linejoin", "round");
		builder.AddAttribute(73, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(74, "line");
		builder.AddAttribute(75, "x1", "326");
		builder.AddAttribute(76, "y1", "296");
		builder.AddAttribute(77, "x2", "458");
		builder.AddAttribute(78, "y2", "304");
		builder.AddAttribute(79, "fill", "none");
		builder.AddAttribute(80, "stroke-linecap", "round");
		builder.AddAttribute(81, "stroke-linejoin", "round");
		builder.AddAttribute(82, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(83, "line");
		builder.AddAttribute(84, "x1", "54");
		builder.AddAttribute(85, "y1", "208");
		builder.AddAttribute(86, "x2", "186");
		builder.AddAttribute(87, "y2", "216");
		builder.AddAttribute(88, "fill", "none");
		builder.AddAttribute(89, "stroke-linecap", "round");
		builder.AddAttribute(90, "stroke-linejoin", "round");
		builder.AddAttribute(91, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(92, "line");
		builder.AddAttribute(93, "x1", "186");
		builder.AddAttribute(94, "y1", "296");
		builder.AddAttribute(95, "x2", "54");
		builder.AddAttribute(96, "y2", "304");
		builder.AddAttribute(97, "fill", "none");
		builder.AddAttribute(98, "stroke-linecap", "round");
		builder.AddAttribute(99, "stroke-linejoin", "round");
		builder.AddAttribute(100, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
