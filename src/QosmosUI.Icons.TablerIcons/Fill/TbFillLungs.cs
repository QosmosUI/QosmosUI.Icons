// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillLungs : ComponentBase
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
		builder.AddAttribute(14, "d", "M12 3a1 1 0 0 1 1 1v5a2 2 0 0 0 1 1.732v-3.475c0 -1.242 .995 -2.257 2.233 -2.257c.372 0 .738 .094 1.122 .307l.18 .117c1.695 1.23 2.76 3.035 3.773 6.34q .674 2.204 .692 5.06c.016 2.195 -1.657 4.024 -3.843 4.168l-.237 .008c-2.17 0 -3.92 -1.787 -3.92 -3.98v-4.146a4 4 0 0 1 -1.893 -1.112l-.107 -.118l-.107 .118a4 4 0 0 1 -1.892 1.112l-.001 4.146c0 2.193 -1.75 3.98 -3.919 3.98l-.268 -.01c-2.155 -.142 -3.827 -1.971 -3.811 -4.165q .018 -2.858 .692 -5.06c1.011 -3.307 2.076 -5.112 3.822 -6.375l.188 -.117a2.2 2.2 0 0 1 1.064 -.273c1.237 0 2.232 1.015 2.232 2.257l.001 3.475a2 2 0 0 0 .999 -1.732v-5a1 1 0 0 1 1 -1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
