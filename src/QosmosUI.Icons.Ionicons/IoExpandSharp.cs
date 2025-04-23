// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoExpandSharp : ComponentBase
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
		builder.AddAttribute(14, "points", "432 320 432 432 320 432");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linecap", "square");
		builder.AddAttribute(17, "stroke-miterlimit", "10");
		builder.AddAttribute(18, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(19, "line");
		builder.AddAttribute(20, "x1", "421.8");
		builder.AddAttribute(21, "y1", "421.77");
		builder.AddAttribute(22, "x2", "304");
		builder.AddAttribute(23, "y2", "304");
		builder.AddAttribute(24, "fill", "none");
		builder.AddAttribute(25, "stroke-linecap", "square");
		builder.AddAttribute(26, "stroke-miterlimit", "10");
		builder.AddAttribute(27, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(28, "polyline");
		builder.AddAttribute(29, "points", "80 192 80 80 192 80");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linecap", "square");
		builder.AddAttribute(32, "stroke-miterlimit", "10");
		builder.AddAttribute(33, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(34, "line");
		builder.AddAttribute(35, "x1", "90.2");
		builder.AddAttribute(36, "y1", "90.23");
		builder.AddAttribute(37, "x2", "208");
		builder.AddAttribute(38, "y2", "208");
		builder.AddAttribute(39, "fill", "none");
		builder.AddAttribute(40, "stroke-linecap", "square");
		builder.AddAttribute(41, "stroke-miterlimit", "10");
		builder.AddAttribute(42, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(43, "polyline");
		builder.AddAttribute(44, "points", "320 80 432 80 432 192");
		builder.AddAttribute(45, "fill", "none");
		builder.AddAttribute(46, "stroke-linecap", "square");
		builder.AddAttribute(47, "stroke-miterlimit", "10");
		builder.AddAttribute(48, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(49, "line");
		builder.AddAttribute(50, "x1", "421.77");
		builder.AddAttribute(51, "y1", "90.2");
		builder.AddAttribute(52, "x2", "304");
		builder.AddAttribute(53, "y2", "208");
		builder.AddAttribute(54, "fill", "none");
		builder.AddAttribute(55, "stroke-linecap", "square");
		builder.AddAttribute(56, "stroke-miterlimit", "10");
		builder.AddAttribute(57, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(58, "polyline");
		builder.AddAttribute(59, "points", "192 432 80 432 80 320");
		builder.AddAttribute(60, "fill", "none");
		builder.AddAttribute(61, "stroke-linecap", "square");
		builder.AddAttribute(62, "stroke-miterlimit", "10");
		builder.AddAttribute(63, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(64, "line");
		builder.AddAttribute(65, "x1", "90.23");
		builder.AddAttribute(66, "y1", "421.8");
		builder.AddAttribute(67, "x2", "208");
		builder.AddAttribute(68, "y2", "304");
		builder.AddAttribute(69, "fill", "none");
		builder.AddAttribute(70, "stroke-linecap", "square");
		builder.AddAttribute(71, "stroke-miterlimit", "10");
		builder.AddAttribute(72, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
