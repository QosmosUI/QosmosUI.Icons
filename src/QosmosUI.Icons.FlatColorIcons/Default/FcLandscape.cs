// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcLandscape : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#FF9800");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "36.1");
		builder.AddAttribute(17, "y", "8.1");
		builder.AddAttribute(18, "transform", "matrix(.707 .707 -.707 .707 21.201 -25.184)");
		builder.AddAttribute(19, "width", "9.9");
		builder.AddAttribute(20, "height", "9.9");
		builder.CloseElement();
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "x", "36");
		builder.AddAttribute(23, "y", "8");
		builder.AddAttribute(24, "width", "10");
		builder.AddAttribute(25, "height", "10");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "fill", "#FFEB3B");
		builder.AddAttribute(28, "cx", "41");
		builder.AddAttribute(29, "cy", "13");
		builder.AddAttribute(30, "r", "3");
		builder.CloseElement();
		builder.OpenElement(31, "polygon");
		builder.AddAttribute(32, "fill", "#2E7D32");
		builder.AddAttribute(33, "points", "16.5,18 0,42 33,42");
		builder.CloseElement();
		builder.OpenElement(34, "polygon");
		builder.AddAttribute(35, "fill", "#4CAF50");
		builder.AddAttribute(36, "points", "33.6,24 19.2,42 48,42");
		builder.CloseElement();
		builder.CloseElement();
    }
}
