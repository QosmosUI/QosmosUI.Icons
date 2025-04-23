// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcNegativeDynamic : ComponentBase
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
		builder.AddAttribute(14, "fill", "#00BCD4");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "19");
		builder.AddAttribute(17, "y", "22");
		builder.AddAttribute(18, "width", "10");
		builder.AddAttribute(19, "height", "20");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "6");
		builder.AddAttribute(22, "y", "8");
		builder.AddAttribute(23, "width", "10");
		builder.AddAttribute(24, "height", "34");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "32");
		builder.AddAttribute(27, "y", "30");
		builder.AddAttribute(28, "width", "10");
		builder.AddAttribute(29, "height", "12");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(30, "g");
		builder.AddAttribute(31, "fill", "#3F51B5");
		builder.OpenElement(32, "polygon");
		builder.AddAttribute(33, "points", "42,12 32,22 42,22");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "32");
		builder.AddAttribute(36, "y", "6.9");
		builder.AddAttribute(37, "transform", "matrix(.707 -.707 .707 .707 .059 28.142)");
		builder.AddAttribute(38, "width", "4");
		builder.AddAttribute(39, "height", "14.1");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
