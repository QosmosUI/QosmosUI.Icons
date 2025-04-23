// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcDoNotMix : ComponentBase
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
		builder.OpenElement(13, "polygon");
		builder.AddAttribute(14, "fill", "#00BCD4");
		builder.AddAttribute(15, "points", "26.9,42 17,42 17,32.1");
		builder.CloseElement();
		builder.OpenElement(16, "polygon");
		builder.AddAttribute(17, "fill", "#00BCD4");
		builder.AddAttribute(18, "points", "30,6 30,26.2 19.8,36.4 22.6,39.2 34,27.8 34,6");
		builder.CloseElement();
		builder.OpenElement(19, "polygon");
		builder.AddAttribute(20, "fill", "#2196F3");
		builder.AddAttribute(21, "points", "15.9,31 6,31 6,21.1");
		builder.CloseElement();
		builder.OpenElement(22, "polygon");
		builder.AddAttribute(23, "fill", "#2196F3");
		builder.AddAttribute(24, "points", "20.2,14 8.8,25.4 11.6,28.2 21.8,18 41,18 41,14");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "22");
		builder.AddAttribute(27, "y", "-2.9");
		builder.AddAttribute(28, "transform", "matrix(.707 -.707 .707 .707 -9.941 24)");
		builder.AddAttribute(29, "fill", "#37474F");
		builder.AddAttribute(30, "width", "4");
		builder.AddAttribute(31, "height", "53.7");
		builder.CloseElement();
		builder.CloseElement();
    }
}
