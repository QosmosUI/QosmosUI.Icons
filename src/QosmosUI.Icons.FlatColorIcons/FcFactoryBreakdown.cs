// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcFactoryBreakdown : ComponentBase
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
		builder.AddAttribute(14, "fill", "#E64A19");
		builder.AddAttribute(15, "points", "29,23 29,17 21,21 21,23 17,23 17,27 13,27 13,23 5,23 5,43 33,43 33,23");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "25");
		builder.AddAttribute(18, "y", "27");
		builder.AddAttribute(19, "fill", "#992B0A");
		builder.AddAttribute(20, "width", "4");
		builder.AddAttribute(21, "height", "4");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "x", "9");
		builder.AddAttribute(24, "y", "35");
		builder.AddAttribute(25, "fill", "#992B0A");
		builder.AddAttribute(26, "width", "4");
		builder.AddAttribute(27, "height", "4");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "x", "25");
		builder.AddAttribute(30, "y", "35");
		builder.AddAttribute(31, "fill", "#992B0A");
		builder.AddAttribute(32, "width", "4");
		builder.AddAttribute(33, "height", "4");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "17");
		builder.AddAttribute(36, "y", "35");
		builder.AddAttribute(37, "fill", "#992B0A");
		builder.AddAttribute(38, "width", "4");
		builder.AddAttribute(39, "height", "4");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "17");
		builder.AddAttribute(42, "y", "27");
		builder.AddAttribute(43, "fill", "#992B0A");
		builder.AddAttribute(44, "width", "4");
		builder.AddAttribute(45, "height", "4");
		builder.CloseElement();
		builder.OpenElement(46, "polygon");
		builder.AddAttribute(47, "fill", "#BF360C");
		builder.AddAttribute(48, "points", "41.2,5 38,5 38,7 36,7 36,9 33.7,9 32,43 43,43");
		builder.CloseElement();
		builder.CloseElement();
    }
}
