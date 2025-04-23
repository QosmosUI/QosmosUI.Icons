// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoMoveSharp : ComponentBase
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
		builder.AddAttribute(16, "stroke-miterlimit", "10");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "line");
		builder.AddAttribute(19, "x1", "255.98");
		builder.AddAttribute(20, "y1", "32");
		builder.AddAttribute(21, "x2", "256");
		builder.AddAttribute(22, "y2", "480");
		builder.AddAttribute(23, "fill", "none");
		builder.AddAttribute(24, "stroke-miterlimit", "10");
		builder.AddAttribute(25, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(26, "polyline");
		builder.AddAttribute(27, "points", "176 400 256 480 336 400");
		builder.AddAttribute(28, "fill", "none");
		builder.AddAttribute(29, "stroke-miterlimit", "10");
		builder.AddAttribute(30, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(31, "polyline");
		builder.AddAttribute(32, "points", "400 176 480 256 400 336");
		builder.AddAttribute(33, "fill", "none");
		builder.AddAttribute(34, "stroke-miterlimit", "10");
		builder.AddAttribute(35, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(36, "polyline");
		builder.AddAttribute(37, "points", "112 176 32 256 112 336");
		builder.AddAttribute(38, "fill", "none");
		builder.AddAttribute(39, "stroke-miterlimit", "10");
		builder.AddAttribute(40, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(41, "line");
		builder.AddAttribute(42, "x1", "32");
		builder.AddAttribute(43, "y1", "256");
		builder.AddAttribute(44, "x2", "480");
		builder.AddAttribute(45, "y2", "256");
		builder.AddAttribute(46, "fill", "none");
		builder.AddAttribute(47, "stroke-miterlimit", "10");
		builder.AddAttribute(48, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
