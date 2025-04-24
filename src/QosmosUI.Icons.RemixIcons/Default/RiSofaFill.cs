// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiSofaFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M15 3H9C6.02024 3 3.54782 5.17213 3.07974 8.01937C3.21811 8.00655 3.35829 8 3.5 8C5.98528 8 8 10.0147 8 12.5V14H16V12.5C16 10.0147 18.0147 8 20.5 8C20.6417 8 20.7819 8.00655 20.9203 8.01937C20.4522 5.17213 17.9798 3 15 3ZM21 10.05C20.8384 10.0172 20.6712 10 20.5 10C19.1193 10 18 11.1193 18 12.5V17H16V16H8V17H6V12.5C6 11.1193 4.88071 10 3.5 10C3.32877 10 3.16156 10.0172 3 10.05C1.85888 10.2816 1 11.2905 1 12.5C1 13.0886 1.18173 13.5388 1.39024 14.0554C1.67083 14.7505 1.9999 15.5658 1.99978 17V20C1.99978 20.5523 2.44749 21 2.99978 21H12H21.0002C21.5525 21 22.0002 20.5523 22.0002 20V17C22.0001 15.5658 22.3292 14.7505 22.6098 14.0554C22.8183 13.5388 23 13.0886 23 12.5C23 11.2905 22.1411 10.2816 21 10.05Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
