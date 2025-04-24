// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoListSharp : ComponentBase
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
		builder.AddAttribute(14, "x1", "144");
		builder.AddAttribute(15, "y1", "144");
		builder.AddAttribute(16, "x2", "464");
		builder.AddAttribute(17, "y2", "144");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "stroke-linejoin", "round");
		builder.AddAttribute(20, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(21, "line");
		builder.AddAttribute(22, "x1", "144");
		builder.AddAttribute(23, "y1", "256");
		builder.AddAttribute(24, "x2", "464");
		builder.AddAttribute(25, "y2", "256");
		builder.AddAttribute(26, "fill", "none");
		builder.AddAttribute(27, "stroke-linejoin", "round");
		builder.AddAttribute(28, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(29, "line");
		builder.AddAttribute(30, "x1", "144");
		builder.AddAttribute(31, "y1", "368");
		builder.AddAttribute(32, "x2", "464");
		builder.AddAttribute(33, "y2", "368");
		builder.AddAttribute(34, "fill", "none");
		builder.AddAttribute(35, "stroke-linejoin", "round");
		builder.AddAttribute(36, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "x", "64");
		builder.AddAttribute(39, "y", "128");
		builder.AddAttribute(40, "width", "32");
		builder.AddAttribute(41, "height", "32");
		builder.AddAttribute(42, "fill", "none");
		builder.AddAttribute(43, "stroke-linecap", "square");
		builder.AddAttribute(44, "stroke-linejoin", "round");
		builder.AddAttribute(45, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "x", "64");
		builder.AddAttribute(48, "y", "240");
		builder.AddAttribute(49, "width", "32");
		builder.AddAttribute(50, "height", "32");
		builder.AddAttribute(51, "fill", "none");
		builder.AddAttribute(52, "stroke-linecap", "square");
		builder.AddAttribute(53, "stroke-linejoin", "round");
		builder.AddAttribute(54, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(55, "rect");
		builder.AddAttribute(56, "x", "64");
		builder.AddAttribute(57, "y", "352");
		builder.AddAttribute(58, "width", "32");
		builder.AddAttribute(59, "height", "32");
		builder.AddAttribute(60, "fill", "none");
		builder.AddAttribute(61, "stroke-linecap", "square");
		builder.AddAttribute(62, "stroke-linejoin", "round");
		builder.AddAttribute(63, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
