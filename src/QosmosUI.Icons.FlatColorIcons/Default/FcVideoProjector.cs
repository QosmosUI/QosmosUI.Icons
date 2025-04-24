// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcVideoProjector : ComponentBase
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
		builder.AddAttribute(14, "fill", "#546E7A");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "5");
		builder.AddAttribute(17, "y", "34");
		builder.AddAttribute(18, "width", "6");
		builder.AddAttribute(19, "height", "3");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "37");
		builder.AddAttribute(22, "y", "34");
		builder.AddAttribute(23, "width", "6");
		builder.AddAttribute(24, "height", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#78909C");
		builder.AddAttribute(27, "d", "M44,35H4c-2.2,0-4-1.8-4-4V17c0-2.2,1.8-4,4-4h40c2.2,0,4,1.8,4,4v14C48,33.2,46.2,35,44,35z");
		builder.CloseElement();
		builder.OpenElement(28, "g");
		builder.AddAttribute(29, "fill", "#37474F");
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "x", "5");
		builder.AddAttribute(32, "y", "19");
		builder.AddAttribute(33, "width", "2");
		builder.AddAttribute(34, "height", "2");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "5");
		builder.AddAttribute(37, "y", "23");
		builder.AddAttribute(38, "width", "2");
		builder.AddAttribute(39, "height", "2");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "5");
		builder.AddAttribute(42, "y", "27");
		builder.AddAttribute(43, "width", "2");
		builder.AddAttribute(44, "height", "2");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "x", "9");
		builder.AddAttribute(47, "y", "19");
		builder.AddAttribute(48, "width", "2");
		builder.AddAttribute(49, "height", "2");
		builder.CloseElement();
		builder.OpenElement(50, "rect");
		builder.AddAttribute(51, "x", "9");
		builder.AddAttribute(52, "y", "23");
		builder.AddAttribute(53, "width", "2");
		builder.AddAttribute(54, "height", "2");
		builder.CloseElement();
		builder.OpenElement(55, "rect");
		builder.AddAttribute(56, "x", "9");
		builder.AddAttribute(57, "y", "27");
		builder.AddAttribute(58, "width", "2");
		builder.AddAttribute(59, "height", "2");
		builder.CloseElement();
		builder.OpenElement(60, "rect");
		builder.AddAttribute(61, "x", "13");
		builder.AddAttribute(62, "y", "19");
		builder.AddAttribute(63, "width", "2");
		builder.AddAttribute(64, "height", "2");
		builder.CloseElement();
		builder.OpenElement(65, "rect");
		builder.AddAttribute(66, "x", "13");
		builder.AddAttribute(67, "y", "23");
		builder.AddAttribute(68, "width", "2");
		builder.AddAttribute(69, "height", "2");
		builder.CloseElement();
		builder.OpenElement(70, "rect");
		builder.AddAttribute(71, "x", "13");
		builder.AddAttribute(72, "y", "27");
		builder.AddAttribute(73, "width", "2");
		builder.AddAttribute(74, "height", "2");
		builder.CloseElement();
		builder.OpenElement(75, "rect");
		builder.AddAttribute(76, "x", "17");
		builder.AddAttribute(77, "y", "19");
		builder.AddAttribute(78, "width", "2");
		builder.AddAttribute(79, "height", "2");
		builder.CloseElement();
		builder.OpenElement(80, "rect");
		builder.AddAttribute(81, "x", "17");
		builder.AddAttribute(82, "y", "23");
		builder.AddAttribute(83, "width", "2");
		builder.AddAttribute(84, "height", "2");
		builder.CloseElement();
		builder.OpenElement(85, "rect");
		builder.AddAttribute(86, "x", "17");
		builder.AddAttribute(87, "y", "27");
		builder.AddAttribute(88, "width", "2");
		builder.AddAttribute(89, "height", "2");
		builder.CloseElement();
		builder.OpenElement(90, "rect");
		builder.AddAttribute(91, "x", "21");
		builder.AddAttribute(92, "y", "19");
		builder.AddAttribute(93, "width", "2");
		builder.AddAttribute(94, "height", "2");
		builder.CloseElement();
		builder.OpenElement(95, "rect");
		builder.AddAttribute(96, "x", "21");
		builder.AddAttribute(97, "y", "23");
		builder.AddAttribute(98, "width", "2");
		builder.AddAttribute(99, "height", "2");
		builder.CloseElement();
		builder.OpenElement(100, "rect");
		builder.AddAttribute(101, "x", "21");
		builder.AddAttribute(102, "y", "27");
		builder.AddAttribute(103, "width", "2");
		builder.AddAttribute(104, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(105, "circle");
		builder.AddAttribute(106, "fill", "#37474F");
		builder.AddAttribute(107, "cx", "37");
		builder.AddAttribute(108, "cy", "24");
		builder.AddAttribute(109, "r", "8");
		builder.CloseElement();
		builder.OpenElement(110, "circle");
		builder.AddAttribute(111, "fill", "#a0f");
		builder.AddAttribute(112, "cx", "37");
		builder.AddAttribute(113, "cy", "24");
		builder.AddAttribute(114, "r", "6");
		builder.CloseElement();
		builder.OpenElement(115, "path");
		builder.AddAttribute(116, "fill", "#EA80FC");
		builder.AddAttribute(117, "d", "M40.7,21.7c-1-1.1-2.3-1.7-3.7-1.7s-2.8,0.6-3.7,1.7c-0.4,0.4-0.3,1,0.1,1.4c0.4,0.4,1,0.3,1.4-0.1 c1.2-1.3,3.3-1.3,4.5,0c0.2,0.2,0.5,0.3,0.7,0.3c0.2,0,0.5-0.1,0.7-0.3C41.1,22.7,41.1,22.1,40.7,21.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
