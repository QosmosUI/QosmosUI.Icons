// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcExpired : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "fill", "#00ACC1");
		builder.AddAttribute(15, "cx", "17");
		builder.AddAttribute(16, "cy", "17");
		builder.AddAttribute(17, "r", "14");
		builder.CloseElement();
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "fill", "#eee");
		builder.AddAttribute(20, "cx", "17");
		builder.AddAttribute(21, "cy", "17");
		builder.AddAttribute(22, "r", "11");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "x", "16");
		builder.AddAttribute(25, "y", "8");
		builder.AddAttribute(26, "width", "2");
		builder.AddAttribute(27, "height", "9");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "x", "18.2");
		builder.AddAttribute(30, "y", "16");
		builder.AddAttribute(31, "transform", "matrix(-.707 .707 -.707 -.707 46.834 19.399)");
		builder.AddAttribute(32, "width", "2.4");
		builder.AddAttribute(33, "height", "6.8");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "17");
		builder.AddAttribute(36, "cy", "17");
		builder.AddAttribute(37, "r", "2");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "fill", "#00ACC1");
		builder.AddAttribute(40, "cx", "17");
		builder.AddAttribute(41, "cy", "17");
		builder.AddAttribute(42, "r", "1");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "fill", "#FFC107");
		builder.AddAttribute(45, "d", "M11.9,42l14.4-24.1c0.8-1.3,2.7-1.3,3.4,0L44.1,42c0.8,1.3-0.2,3-1.7,3H13.6C12.1,45,11.1,43.3,11.9,42z");
		builder.CloseElement();
		builder.OpenElement(46, "path");
		builder.AddAttribute(47, "fill", "#263238");
		builder.AddAttribute(48, "d", "M26.4,39.9c0-0.2,0-0.4,0.1-0.6s0.2-0.3,0.3-0.5s0.3-0.2,0.5-0.3s0.4-0.1,0.6-0.1s0.5,0,0.7,0.1 s0.4,0.2,0.5,0.3s0.2,0.3,0.3,0.5s0.1,0.4,0.1,0.6s0,0.4-0.1,0.6s-0.2,0.3-0.3,0.5s-0.3,0.2-0.5,0.3s-0.4,0.1-0.7,0.1 s-0.5,0-0.6-0.1s-0.4-0.2-0.5-0.3s-0.2-0.3-0.3-0.5S26.4,40.1,26.4,39.9z M29.2,36.8h-2.3L26.5,27h3L29.2,36.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
