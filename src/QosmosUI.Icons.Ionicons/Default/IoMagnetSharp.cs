// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoMagnetSharp : ComponentBase
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
		builder.AddAttribute(14, "x1", "191.98");
		builder.AddAttribute(15, "y1", "463.58");
		builder.AddAttribute(16, "x2", "191.98");
		builder.AddAttribute(17, "y2", "415.58");
		builder.AddAttribute(18, "stroke-linecap", "square");
		builder.AddAttribute(19, "stroke-miterlimit", "10");
		builder.AddAttribute(20, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(21, "line");
		builder.AddAttribute(22, "x1", "90.16");
		builder.AddAttribute(23, "y1", "421.4");
		builder.AddAttribute(24, "x2", "124.1");
		builder.AddAttribute(25, "y2", "387.46");
		builder.AddAttribute(26, "stroke-linecap", "square");
		builder.AddAttribute(27, "stroke-miterlimit", "10");
		builder.AddAttribute(28, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(29, "line");
		builder.AddAttribute(30, "x1", "47.98");
		builder.AddAttribute(31, "y1", "319.58");
		builder.AddAttribute(32, "x2", "95.98");
		builder.AddAttribute(33, "y2", "319.58");
		builder.AddAttribute(34, "stroke-linecap", "square");
		builder.AddAttribute(35, "stroke-miterlimit", "10");
		builder.AddAttribute(36, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M422.2,89.82a144,144,0,0,0-203.71-.07l-67.88,67.88,67.88,67.89,67.88-67.89a48,48,0,0,1,68.46.59c18.3,18.92,17.48,49.24-1.14,67.86L286.37,293.4l67.88,67.88,66.91-66.91C477.53,238,478.53,146.22,422.2,89.82Z");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "107.29");
		builder.AddAttribute(41, "y", "188.83");
		builder.AddAttribute(42, "width", "64");
		builder.AddAttribute(43, "height", "96");
		builder.AddAttribute(44, "transform", "translate(-126.67 167.86) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "x", "243.06");
		builder.AddAttribute(47, "y", "324.59");
		builder.AddAttribute(48, "width", "64");
		builder.AddAttribute(49, "height", "96");
		builder.AddAttribute(50, "transform", "translate(-182.9 303.62) rotate(-45)");
		builder.CloseElement();
		builder.CloseElement();
    }
}
