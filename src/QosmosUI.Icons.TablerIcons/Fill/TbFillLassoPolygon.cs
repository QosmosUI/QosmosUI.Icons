// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillLassoPolygon : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M5.581 2.186l6.566 4.69l7.502 -2.812a1 1 0 0 1 1.326 .714l.019 .112l1 9a1 1 0 0 1 -.678 1.059l-9 3a1 1 0 0 1 -.553 .023l-4.434 -1.082a3 3 0 0 1 -1.287 .923c.095 .986 .374 1.9 .826 2.69a1 1 0 0 1 -1.736 .993c-.624 -1.09 -.99 -2.335 -1.098 -3.656a3 3 0 0 1 -2.034 -2.84l.005 -.176a3 3 0 0 1 .86 -1.932l-.818 -2.59a1 1 0 0 1 -.009 -.577l2 -7a1 1 0 0 1 1.543 -.539m-.009 2.451l-1.528 5.348l.642 2.031q .155 -.016 .314 -.016a3 3 0 0 1 3 2.995l3.957 .965l7.96 -2.654l-.769 -6.919l-6.797 2.55a1 1 0 0 1 -.827 -.058l-.105 -.065z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
