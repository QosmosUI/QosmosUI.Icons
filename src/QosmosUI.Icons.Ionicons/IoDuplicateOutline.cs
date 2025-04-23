// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoDuplicateOutline : ComponentBase
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
		builder.AddAttribute(14, "x", "128");
		builder.AddAttribute(15, "y", "128");
		builder.AddAttribute(16, "width", "336");
		builder.AddAttribute(17, "height", "336");
		builder.AddAttribute(18, "rx", "57");
		builder.AddAttribute(19, "ry", "57");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linejoin", "round");
		builder.AddAttribute(22, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M383.5,128l.5-24a56.16,56.16,0,0,0-56-56H112a64.19,64.19,0,0,0-64,64V328a56.16,56.16,0,0,0,56,56h24");
		builder.AddAttribute(25, "fill", "none");
		builder.AddAttribute(26, "stroke-linecap", "round");
		builder.AddAttribute(27, "stroke-linejoin", "round");
		builder.AddAttribute(28, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(29, "line");
		builder.AddAttribute(30, "x1", "296");
		builder.AddAttribute(31, "y1", "216");
		builder.AddAttribute(32, "x2", "296");
		builder.AddAttribute(33, "y2", "376");
		builder.AddAttribute(34, "fill", "none");
		builder.AddAttribute(35, "stroke-linecap", "round");
		builder.AddAttribute(36, "stroke-linejoin", "round");
		builder.AddAttribute(37, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(38, "line");
		builder.AddAttribute(39, "x1", "376");
		builder.AddAttribute(40, "y1", "296");
		builder.AddAttribute(41, "x2", "216");
		builder.AddAttribute(42, "y2", "296");
		builder.AddAttribute(43, "fill", "none");
		builder.AddAttribute(44, "stroke-linecap", "round");
		builder.AddAttribute(45, "stroke-linejoin", "round");
		builder.AddAttribute(46, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
