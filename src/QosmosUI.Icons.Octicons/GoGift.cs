// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoGift : ComponentBase
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
		builder.AddAttribute(14, "d", "M3.75 3.75A3.75 3.75 0 0 1 7.5 0c1.455 0 3.436.901 4.5 3.11C13.064.901 15.044 0 16.5 0a3.75 3.75 0 0 1 3 6h1.75c.966 0 1.75.784 1.75 1.75v2.5c0 .698-.409 1.301-1 1.582v8.418A1.75 1.75 0 0 1 20.25 22H3.75A1.75 1.75 0 0 1 2 20.25v-8.418c-.591-.282-1-.884-1-1.582v-2.5C1 6.784 1.784 6 2.75 6H4.5a3.733 3.733 0 0 1-.75-2.25ZM20.5 12h-7.75v8.5h7.5a.25.25 0 0 0 .25-.25Zm-9.25 8.5V12H3.5v8.25c0 .138.112.25.25.25Zm10-10a.25.25 0 0 0 .25-.25v-2.5a.25.25 0 0 0-.25-.25h-8.5v3Zm-18.5 0h8.5v-3h-8.5a.25.25 0 0 0-.25.25v2.5c0 .138.112.25.25.25Zm16-6.75A2.25 2.25 0 0 0 16.5 1.5c-1.15 0-3.433 1.007-3.72 4.5h3.72a2.25 2.25 0 0 0 2.25-2.25ZM11.22 6c-.287-3.493-2.57-4.5-3.72-4.5a2.25 2.25 0 1 0 0 4.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
