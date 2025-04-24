// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoBarcodeSharp : ComponentBase
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
		builder.OpenElement(13, "polyline");
		builder.AddAttribute(14, "points", "400 400.33 448 400 448 112 400 112.33");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linecap", "square");
		builder.AddAttribute(17, "stroke-linejoin", "round");
		builder.AddAttribute(18, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(19, "polyline");
		builder.AddAttribute(20, "points", "112 112 64 112.33 64 400.33 112 400");
		builder.AddAttribute(21, "fill", "none");
		builder.AddAttribute(22, "stroke-linecap", "square");
		builder.AddAttribute(23, "stroke-linejoin", "round");
		builder.AddAttribute(24, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(25, "line");
		builder.AddAttribute(26, "x1", "384");
		builder.AddAttribute(27, "y1", "192");
		builder.AddAttribute(28, "x2", "384");
		builder.AddAttribute(29, "y2", "320");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linecap", "square");
		builder.AddAttribute(32, "stroke-linejoin", "round");
		builder.AddAttribute(33, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(34, "line");
		builder.AddAttribute(35, "x1", "320");
		builder.AddAttribute(36, "y1", "160");
		builder.AddAttribute(37, "x2", "320");
		builder.AddAttribute(38, "y2", "352");
		builder.AddAttribute(39, "fill", "none");
		builder.AddAttribute(40, "stroke-linecap", "square");
		builder.AddAttribute(41, "stroke-linejoin", "round");
		builder.AddAttribute(42, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(43, "line");
		builder.AddAttribute(44, "x1", "256");
		builder.AddAttribute(45, "y1", "176");
		builder.AddAttribute(46, "x2", "256");
		builder.AddAttribute(47, "y2", "336");
		builder.AddAttribute(48, "fill", "none");
		builder.AddAttribute(49, "stroke-linecap", "square");
		builder.AddAttribute(50, "stroke-linejoin", "round");
		builder.AddAttribute(51, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(52, "line");
		builder.AddAttribute(53, "x1", "192");
		builder.AddAttribute(54, "y1", "160");
		builder.AddAttribute(55, "x2", "192");
		builder.AddAttribute(56, "y2", "352");
		builder.AddAttribute(57, "fill", "none");
		builder.AddAttribute(58, "stroke-linecap", "square");
		builder.AddAttribute(59, "stroke-linejoin", "round");
		builder.AddAttribute(60, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(61, "line");
		builder.AddAttribute(62, "x1", "128");
		builder.AddAttribute(63, "y1", "192");
		builder.AddAttribute(64, "x2", "128");
		builder.AddAttribute(65, "y2", "320");
		builder.AddAttribute(66, "fill", "none");
		builder.AddAttribute(67, "stroke-linecap", "square");
		builder.AddAttribute(68, "stroke-linejoin", "round");
		builder.AddAttribute(69, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
