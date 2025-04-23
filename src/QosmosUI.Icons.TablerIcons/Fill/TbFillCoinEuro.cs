// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillCoinEuro : ComponentBase
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
		builder.AddAttribute(14, "d", "M17 3.34a10 10 0 1 1 -15 8.66l.005 -.324a10 10 0 0 1 14.995 -8.336zm-5 2.66c-2.052 0 -3.768 1.449 -4.549 3.5h-.451a1 1 0 0 0 -.117 1.993l.134 .007a7.298 7.298 0 0 0 0 1h-.017a1 1 0 0 0 0 2h.452c.78 2.053 2.496 3.5 4.548 3.5c1.141 0 2.217 -.457 3.084 -1.27a1 1 0 0 0 -1.368 -1.46c-.509 .478 -1.102 .73 -1.716 .73c-.922 0 -1.776 -.578 -2.335 -1.499l1.335 -.001a1 1 0 0 0 0 -2h-1.977a5.342 5.342 0 0 1 0 -1h1.977a1 1 0 0 0 0 -2h-1.336c.56 -.921 1.414 -1.5 2.336 -1.5c.615 0 1.208 .252 1.717 .73a1 1 0 0 0 1.368 -1.46c-.867 -.812 -1.943 -1.27 -3.085 -1.27z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
