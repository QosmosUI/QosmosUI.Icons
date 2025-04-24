// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiQaitbayCitadel : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M208 80v25h-13v126h18v-71c0-5.5 1.4-10.5 4.3-14.4 3-3.9 7.8-6.5 12.7-6.5 5 0 9.7 2.7 12.7 6.6 2.9 3.9 4.3 8.8 4.3 14.3v71h18v-71c0-5.5 1.4-10.5 4.3-14.4 2.9-3.9 7.7-6.6 12.7-6.6 5 0 9.8 2.7 12.7 6.6 2.9 3.9 4.3 8.9 4.3 14.4v71h18V105h-13V80h-18v25h-21V80h-18v25h-21V80h-18zM16 112v32h9v71h78v-65.9h9V112H94v25H73v-25H55v25H34v-25H16zm384 0v32h9v71h78v-71h9v-32h-18v25h-21v-25h-18v25h-21v-25h-18zm-265 32v25h-14v64h-16v254h110v-81.6c0-17.5 4.4-31.5 11.8-41.4 7.4-9.9 18.2-15.6 29.2-15.6s21.8 5.7 29.2 15.6c7.4 9.9 11.8 23.9 11.8 41.4V487h110V233h-16v-64h-14v-25h-18v25h-24v80H177v-80h-24v-25h-18zm-94 89v254h46V233H41zm384 0v254h46V233h-46zm-290 7h18v48h-18v-48zm224 0h18v48h-18v-48zM135 359h50v50h-50v-50zm192 0h50v50h-50v-50zm-71 7.4c-5 0-10.2 2.3-14.8 8.4-4.6 6.1-8.2 16.1-8.2 30.6V432h46v-26.6c0-14.5-3.6-24.5-8.2-30.6-4.6-6.1-9.8-8.4-14.8-8.4zM153 377v14h14v-14h-14zm192 0v14h14v-14h-14z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
