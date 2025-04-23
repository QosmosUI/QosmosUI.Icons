// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcFactory : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "#BF360C");
		builder.AddAttribute(15, "d", "M41.2,5h-7.3L32,43h11L41.2,5z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#E64A19");
		builder.AddAttribute(18, "d", "M33,23h-4v-6l-12,6v-6L5,23v20h28V23z");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "9");
		builder.AddAttribute(21, "y", "27");
		builder.AddAttribute(22, "fill", "#FFC107");
		builder.AddAttribute(23, "width", "4");
		builder.AddAttribute(24, "height", "4");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "17");
		builder.AddAttribute(27, "y", "27");
		builder.AddAttribute(28, "fill", "#FFC107");
		builder.AddAttribute(29, "width", "4");
		builder.AddAttribute(30, "height", "4");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "25");
		builder.AddAttribute(33, "y", "27");
		builder.AddAttribute(34, "fill", "#FFC107");
		builder.AddAttribute(35, "width", "4");
		builder.AddAttribute(36, "height", "4");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "x", "9");
		builder.AddAttribute(39, "y", "35");
		builder.AddAttribute(40, "fill", "#FFC107");
		builder.AddAttribute(41, "width", "4");
		builder.AddAttribute(42, "height", "4");
		builder.CloseElement();
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "x", "17");
		builder.AddAttribute(45, "y", "35");
		builder.AddAttribute(46, "fill", "#FFC107");
		builder.AddAttribute(47, "width", "4");
		builder.AddAttribute(48, "height", "4");
		builder.CloseElement();
		builder.OpenElement(49, "rect");
		builder.AddAttribute(50, "x", "25");
		builder.AddAttribute(51, "y", "35");
		builder.AddAttribute(52, "fill", "#FFC107");
		builder.AddAttribute(53, "width", "4");
		builder.AddAttribute(54, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
    }
}
