// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoBarbellOutline : ComponentBase
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
		builder.AddAttribute(14, "x1", "48");
		builder.AddAttribute(15, "y1", "256");
		builder.AddAttribute(16, "x2", "464");
		builder.AddAttribute(17, "y2", "256");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "stroke-linecap", "round");
		builder.AddAttribute(20, "stroke-linejoin", "round");
		builder.AddAttribute(21, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "x", "384");
		builder.AddAttribute(24, "y", "128");
		builder.AddAttribute(25, "width", "32");
		builder.AddAttribute(26, "height", "256");
		builder.AddAttribute(27, "rx", "16");
		builder.AddAttribute(28, "ry", "16");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "stroke-linecap", "round");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "x", "96");
		builder.AddAttribute(35, "y", "128");
		builder.AddAttribute(36, "width", "32");
		builder.AddAttribute(37, "height", "256");
		builder.AddAttribute(38, "rx", "16");
		builder.AddAttribute(39, "ry", "16");
		builder.AddAttribute(40, "fill", "none");
		builder.AddAttribute(41, "stroke-linecap", "round");
		builder.AddAttribute(42, "stroke-linejoin", "round");
		builder.AddAttribute(43, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(44, "rect");
		builder.AddAttribute(45, "x", "32");
		builder.AddAttribute(46, "y", "192");
		builder.AddAttribute(47, "width", "16");
		builder.AddAttribute(48, "height", "128");
		builder.AddAttribute(49, "rx", "8");
		builder.AddAttribute(50, "ry", "8");
		builder.AddAttribute(51, "fill", "none");
		builder.AddAttribute(52, "stroke-linecap", "round");
		builder.AddAttribute(53, "stroke-linejoin", "round");
		builder.AddAttribute(54, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(55, "rect");
		builder.AddAttribute(56, "x", "464");
		builder.AddAttribute(57, "y", "192");
		builder.AddAttribute(58, "width", "16");
		builder.AddAttribute(59, "height", "128");
		builder.AddAttribute(60, "rx", "8");
		builder.AddAttribute(61, "ry", "8");
		builder.AddAttribute(62, "fill", "none");
		builder.AddAttribute(63, "stroke-linecap", "round");
		builder.AddAttribute(64, "stroke-linejoin", "round");
		builder.AddAttribute(65, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
