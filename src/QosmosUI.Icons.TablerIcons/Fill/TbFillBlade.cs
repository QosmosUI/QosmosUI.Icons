// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillBlade : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.586 3a2 2 0 0 1 2.828 0l.586 .585l.586 -.585a2 2 0 0 1 2.7 -.117l.128 .117l2.586 2.586a2 2 0 0 1 0 2.828l-.586 .586l.586 .586a2 2 0 0 1 0 2.828l-8.586 8.586a2 2 0 0 1 -2.828 0l-.586 -.586l-.586 .586a2 2 0 0 1 -2.828 0l-2.586 -2.586a2 2 0 0 1 0 -2.828l.585 -.587l-.585 -.585a2 2 0 0 1 -.117 -2.7l.117 -.129zm3.027 4.21a1 1 0 0 0 -1.32 1.497l.292 .293l-1.068 1.067a2.003 2.003 0 0 0 -2.512 1.784l-.005 .149l.005 .15c.01 .125 .03 .248 .062 .367l-1.067 1.068l-.293 -.292l-.094 -.083a1 1 0 0 0 -1.32 1.497l.292 .293l-.292 .293l-.083 .094a1 1 0 0 0 1.497 1.32l.293 -.292l.293 .292l.094 .083a1 1 0 0 0 1.32 -1.497l-.292 -.293l1.069 -1.067a2.003 2.003 0 0 0 2.449 -2.45l1.067 -1.068l.293 .292l.094 .083a1 1 0 0 0 1.32 -1.497l-.292 -.293l.292 -.293l.083 -.094a1 1 0 0 0 -1.497 -1.32l-.293 .292l-.293 -.292z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
