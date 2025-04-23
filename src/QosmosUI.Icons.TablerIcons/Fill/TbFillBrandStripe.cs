// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillBrandStripe : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.5 2c2.45 0 4.543 .44 5.928 1.096a1 1 0 0 1 .564 1.028l-.5 4a1 1 0 0 1 -1.429 .776c-1.047 -.509 -2.618 -.823 -4.168 -.823q -.206 .001 -.332 .026l.028 .024l.07 .047c.314 .207 .832 .437 1.672 .746c3.824 1.351 5.667 3.24 5.667 6.58c0 2.13 -.758 3.732 -2.295 4.924c-1.293 1.023 -3.422 1.576 -5.705 1.576c-2.4 0 -4.72 -.644 -6.486 -1.626a1 1 0 0 1 -.506 -.998l.5 -4a1 1 0 0 1 1.494 -.741c1.292 .75 3.64 1.365 4.998 1.365c.39 0 .704 -.147 .87 -.295l.035 -.035l-.09 -.035c-.167 -.06 -1.583 -.493 -2.153 -.694c-3.626 -1.304 -5.662 -3.609 -5.662 -6.941c0 -1.887 .882 -3.563 2.37 -4.777c1.22 -.987 2.517 -1.223 5.13 -1.223");
		builder.CloseElement();
		builder.CloseElement();
    }
}
