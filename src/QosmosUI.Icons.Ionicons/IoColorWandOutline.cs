// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoColorWandOutline : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-miterlimit", "10");
		builder.AddAttribute(16, "stroke-width", "32");
		builder.AddAttribute(17, "x", "280.48");
		builder.AddAttribute(18, "y", "122.9");
		builder.AddAttribute(19, "width", "63.03");
		builder.AddAttribute(20, "height", "378.2");
		builder.AddAttribute(21, "rx", "31.52");
		builder.AddAttribute(22, "transform", "translate(-129.23 312) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M178.38,178.38h0a31.64,31.64,0,0,0,0,44.75L223.25,268,268,223.25l-44.87-44.87A31.64,31.64,0,0,0,178.38,178.38Z");
		builder.CloseElement();
		builder.OpenElement(25, "line");
		builder.AddAttribute(26, "stroke-miterlimit", "10");
		builder.AddAttribute(27, "stroke-width", "32");
		builder.AddAttribute(28, "stroke-linecap", "round");
		builder.AddAttribute(29, "x1", "48");
		builder.AddAttribute(30, "y1", "192");
		builder.AddAttribute(31, "x2", "96");
		builder.AddAttribute(32, "y2", "192");
		builder.CloseElement();
		builder.OpenElement(33, "line");
		builder.AddAttribute(34, "stroke-miterlimit", "10");
		builder.AddAttribute(35, "stroke-width", "32");
		builder.AddAttribute(36, "stroke-linecap", "round");
		builder.AddAttribute(37, "x1", "90.18");
		builder.AddAttribute(38, "y1", "90.18");
		builder.AddAttribute(39, "x2", "124.12");
		builder.AddAttribute(40, "y2", "124.12");
		builder.CloseElement();
		builder.OpenElement(41, "line");
		builder.AddAttribute(42, "stroke-miterlimit", "10");
		builder.AddAttribute(43, "stroke-width", "32");
		builder.AddAttribute(44, "stroke-linecap", "round");
		builder.AddAttribute(45, "x1", "192");
		builder.AddAttribute(46, "y1", "48");
		builder.AddAttribute(47, "x2", "192");
		builder.AddAttribute(48, "y2", "96");
		builder.CloseElement();
		builder.OpenElement(49, "line");
		builder.AddAttribute(50, "stroke-miterlimit", "10");
		builder.AddAttribute(51, "stroke-width", "32");
		builder.AddAttribute(52, "stroke-linecap", "round");
		builder.AddAttribute(53, "x1", "293.82");
		builder.AddAttribute(54, "y1", "90.18");
		builder.AddAttribute(55, "x2", "259.88");
		builder.AddAttribute(56, "y2", "124.12");
		builder.CloseElement();
		builder.OpenElement(57, "line");
		builder.AddAttribute(58, "stroke-miterlimit", "10");
		builder.AddAttribute(59, "stroke-width", "32");
		builder.AddAttribute(60, "stroke-linecap", "round");
		builder.AddAttribute(61, "x1", "124.12");
		builder.AddAttribute(62, "y1", "259.88");
		builder.AddAttribute(63, "x2", "90.18");
		builder.AddAttribute(64, "y2", "293.82");
		builder.CloseElement();
		builder.CloseElement();
    }
}
