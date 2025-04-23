// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoMove : ComponentBase
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
		builder.AddAttribute(14, "points", "176 112 256 32 336 112");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linecap", "round");
		builder.AddAttribute(17, "stroke-linejoin", "round");
		builder.AddAttribute(18, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(19, "line");
		builder.AddAttribute(20, "x1", "255.98");
		builder.AddAttribute(21, "y1", "32");
		builder.AddAttribute(22, "x2", "256");
		builder.AddAttribute(23, "y2", "480");
		builder.AddAttribute(24, "fill", "none");
		builder.AddAttribute(25, "stroke-linecap", "round");
		builder.AddAttribute(26, "stroke-linejoin", "round");
		builder.AddAttribute(27, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(28, "polyline");
		builder.AddAttribute(29, "points", "176 400 256 480 336 400");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linecap", "round");
		builder.AddAttribute(32, "stroke-linejoin", "round");
		builder.AddAttribute(33, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(34, "polyline");
		builder.AddAttribute(35, "points", "400 176 480 256 400 336");
		builder.AddAttribute(36, "fill", "none");
		builder.AddAttribute(37, "stroke-linecap", "round");
		builder.AddAttribute(38, "stroke-linejoin", "round");
		builder.AddAttribute(39, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(40, "polyline");
		builder.AddAttribute(41, "points", "112 176 32 256 112 336");
		builder.AddAttribute(42, "fill", "none");
		builder.AddAttribute(43, "stroke-linecap", "round");
		builder.AddAttribute(44, "stroke-linejoin", "round");
		builder.AddAttribute(45, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(46, "line");
		builder.AddAttribute(47, "x1", "32");
		builder.AddAttribute(48, "y1", "256");
		builder.AddAttribute(49, "x2", "480");
		builder.AddAttribute(50, "y2", "256");
		builder.AddAttribute(51, "fill", "none");
		builder.AddAttribute(52, "stroke-linecap", "round");
		builder.AddAttribute(53, "stroke-linejoin", "round");
		builder.AddAttribute(54, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
