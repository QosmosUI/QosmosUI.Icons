// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillCarCrane : ComponentBase
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
		builder.AddAttribute(14, "d", "M3.06 5.66l.035 -.085l.07 -.125l.033 -.048l.063 -.075l.064 -.065l.098 -.079l.106 -.065l.067 -.033l.048 -.02l.139 -.041l18.053 -3.01a1 1 0 0 1 1.164 .986v2a1 1 0 0 1 -2 0v-.82l-13.802 2.3l1.25 .626a1 1 0 0 1 .552 .894l-.001 3h2.001v-4a1 1 0 0 1 1 -1h4a6 6 0 0 1 6 6v5a1 1 0 0 1 -1 1h-1.17a3.001 3.001 0 0 1 -5.66 0h-6.34a3.001 3.001 0 0 1 -5.83 -1v-5a1 1 0 0 1 1 -1v-4.99a1 1 0 0 1 .06 -.35m1.94 10.34a1 1 0 1 0 0 2a1 1 0 0 0 0 -2m12 0a1 1 0 1 0 .992 1.124l.008 -.132l-.007 -.109a1 1 0 0 0 -.993 -.883m-.652 -7.985l.895 2.985h2.63l-.042 -.155a4 4 0 0 0 -3.223 -2.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
