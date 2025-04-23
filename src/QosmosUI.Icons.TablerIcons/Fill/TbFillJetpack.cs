// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillJetpack : ComponentBase
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
		builder.AddAttribute(14, "d", "M17 2a4 4 0 0 1 4 4v7a1 1 0 0 1 -1 1h-6a1 1 0 0 1 -1 -1v-1h-2v1a1 1 0 0 1 -1 1h-6a1 1 0 0 1 -1 -1v-7a4 4 0 0 1 8 0v1h2v-1a4 4 0 0 1 4 -4m-4 8v-1h-2v1zm-4 5a1 1 0 0 1 1 1c0 2.623 -.787 4.59 -2.4 5.8a1 1 0 0 1 -1.2 0c-1.613 -1.21 -2.4 -3.177 -2.4 -5.8a1 1 0 0 1 2 0c0 1.532 .308 2.684 .906 3.498l.094 .119l.094 -.12c.558 -.759 .864 -1.813 .902 -3.196l.004 -.301a1 1 0 0 1 1 -1m10 0a1 1 0 0 1 1 1c0 2.623 -.787 4.59 -2.4 5.8a1 1 0 0 1 -1.2 0c-1.613 -1.21 -2.4 -3.177 -2.4 -5.8a1 1 0 0 1 2 0c0 1.532 .308 2.684 .906 3.498l.094 .119l.094 -.12c.558 -.759 .864 -1.813 .902 -3.196l.004 -.301a1 1 0 0 1 1 -1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
