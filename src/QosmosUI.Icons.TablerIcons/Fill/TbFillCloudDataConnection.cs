// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillCloudDataConnection : ComponentBase
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
		builder.AddAttribute(14, "d", "M15.262 4.087c.974 .768 1.566 1.848 1.678 2.997l.007 .107l.18 .025a3.42 3.42 0 0 1 2.867 3.184l.006 .188a3.42 3.42 0 0 1 -3.425 3.412h-3.575l.001 1.171a3 3 0 0 1 1.829 1.829h6.17a1 1 0 0 1 0 2h-6.17a3.001 3.001 0 0 1 -5.66 0h-6.17a1 1 0 0 1 0 -2h6.171a3 3 0 0 1 1.829 -1.83v-1.17h-2.74c-2.341 0 -4.26 -1.826 -4.26 -4.103c0 -2.001 1.481 -3.655 3.43 -4.026l.086 -.015l.049 -.112c.514 -1.124 1.508 -2.01 2.756 -2.447l.222 -.072c1.627 -.49 3.42 -.166 4.72 .862");
		builder.CloseElement();
		builder.CloseElement();
    }
}
