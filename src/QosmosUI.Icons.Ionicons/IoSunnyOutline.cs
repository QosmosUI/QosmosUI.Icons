// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoSunnyOutline : ComponentBase
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
		builder.AddAttribute(15, "y1", "48");
		builder.AddAttribute(16, "x2", "256");
		builder.AddAttribute(17, "y2", "96");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "stroke-linecap", "round");
		builder.AddAttribute(20, "stroke-miterlimit", "10");
		builder.AddAttribute(21, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(22, "line");
		builder.AddAttribute(23, "x1", "256");
		builder.AddAttribute(24, "y1", "416");
		builder.AddAttribute(25, "x2", "256");
		builder.AddAttribute(26, "y2", "464");
		builder.AddAttribute(27, "fill", "none");
		builder.AddAttribute(28, "stroke-linecap", "round");
		builder.AddAttribute(29, "stroke-miterlimit", "10");
		builder.AddAttribute(30, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(31, "line");
		builder.AddAttribute(32, "x1", "403.08");
		builder.AddAttribute(33, "y1", "108.92");
		builder.AddAttribute(34, "x2", "369.14");
		builder.AddAttribute(35, "y2", "142.86");
		builder.AddAttribute(36, "fill", "none");
		builder.AddAttribute(37, "stroke-linecap", "round");
		builder.AddAttribute(38, "stroke-miterlimit", "10");
		builder.AddAttribute(39, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(40, "line");
		builder.AddAttribute(41, "x1", "142.86");
		builder.AddAttribute(42, "y1", "369.14");
		builder.AddAttribute(43, "x2", "108.92");
		builder.AddAttribute(44, "y2", "403.08");
		builder.AddAttribute(45, "fill", "none");
		builder.AddAttribute(46, "stroke-linecap", "round");
		builder.AddAttribute(47, "stroke-miterlimit", "10");
		builder.AddAttribute(48, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(49, "line");
		builder.AddAttribute(50, "x1", "464");
		builder.AddAttribute(51, "y1", "256");
		builder.AddAttribute(52, "x2", "416");
		builder.AddAttribute(53, "y2", "256");
		builder.AddAttribute(54, "fill", "none");
		builder.AddAttribute(55, "stroke-linecap", "round");
		builder.AddAttribute(56, "stroke-miterlimit", "10");
		builder.AddAttribute(57, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(58, "line");
		builder.AddAttribute(59, "x1", "96");
		builder.AddAttribute(60, "y1", "256");
		builder.AddAttribute(61, "x2", "48");
		builder.AddAttribute(62, "y2", "256");
		builder.AddAttribute(63, "fill", "none");
		builder.AddAttribute(64, "stroke-linecap", "round");
		builder.AddAttribute(65, "stroke-miterlimit", "10");
		builder.AddAttribute(66, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(67, "line");
		builder.AddAttribute(68, "x1", "403.08");
		builder.AddAttribute(69, "y1", "403.08");
		builder.AddAttribute(70, "x2", "369.14");
		builder.AddAttribute(71, "y2", "369.14");
		builder.AddAttribute(72, "fill", "none");
		builder.AddAttribute(73, "stroke-linecap", "round");
		builder.AddAttribute(74, "stroke-miterlimit", "10");
		builder.AddAttribute(75, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(76, "line");
		builder.AddAttribute(77, "x1", "142.86");
		builder.AddAttribute(78, "y1", "142.86");
		builder.AddAttribute(79, "x2", "108.92");
		builder.AddAttribute(80, "y2", "108.92");
		builder.AddAttribute(81, "fill", "none");
		builder.AddAttribute(82, "stroke-linecap", "round");
		builder.AddAttribute(83, "stroke-miterlimit", "10");
		builder.AddAttribute(84, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(85, "circle");
		builder.AddAttribute(86, "cx", "256");
		builder.AddAttribute(87, "cy", "256");
		builder.AddAttribute(88, "r", "80");
		builder.AddAttribute(89, "fill", "none");
		builder.AddAttribute(90, "stroke-linecap", "round");
		builder.AddAttribute(91, "stroke-miterlimit", "10");
		builder.AddAttribute(92, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
