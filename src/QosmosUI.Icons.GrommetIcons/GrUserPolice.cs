// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrUserPolice : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M16,14 C18.3736719,15.1826446 20,17.6506255 20,21 L20,23 L4,23 L4,21 C4,17.6457258 5.6310898,15.1754259 8,14 M12,15 C15.2602409,15 17.9031883,12.3141492 17.9031883,9.00098429 C17.9031883,8.29933805 18.1210147,7.62582606 17.9031883,7 M6.09318017,7 C5.88352479,7.61511425 6.09318017,8.31344562 6.09318017,9.00098429 C6.09318017,12.3141492 8.73775349,15 12,15 L12,15 M6,8 L18,8 L21,4 C19.0884181,2.26537447 15.7904958,1 12,1 C8.16364606,1 4.83185613,2.29617718 3,4 L6,8 L6,8 L6,8 Z M12,5 C12.5522847,5 13,4.55228475 13,4 C13,4 11,4 11,4 C11,4.55228475 11.4477153,5 12,5 L12,5 L12,5 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
