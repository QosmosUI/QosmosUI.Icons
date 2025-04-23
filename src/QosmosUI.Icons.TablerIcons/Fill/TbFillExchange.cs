// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillExchange : ComponentBase
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
		builder.AddAttribute(14, "d", "M19 3a3 3 0 0 1 1 5.83v4.17a6 6 0 0 1 -6 6h-.585l1.292 1.293a1 1 0 0 1 .083 1.32l-.083 .094a1 1 0 0 1 -1.414 0l-2.959 -2.959a1 1 0 0 1 -.238 -.32l-.038 -.091l-.028 -.094a.98 .98 0 0 1 .187 -.866l.076 -.084l3 -3a1 1 0 0 1 1.414 1.414l-1.293 1.293h.586a4 4 0 0 0 3.995 -3.8l.005 -.2v-4.171a3 3 0 0 1 -2 -2.829l.005 -.176a3 3 0 0 1 2.995 -2.824m-8.293 -.707l3 3a.98 .98 0 0 1 .263 .95l-.01 .031l-.003 .018l-.008 .018l-.007 .027l-.016 .035l-.01 .032l-.007 .01l-.005 .014a1 1 0 0 1 -.232 .316l-2.965 2.963a1 1 0 0 1 -1.32 .083l-.094 -.083a1 1 0 0 1 0 -1.414l1.291 -1.293h-.584a4 4 0 0 0 -3.995 3.8l-.005 .2v4.171a3.001 3.001 0 1 1 -4 2.829l.005 -.176a3 3 0 0 1 1.995 -2.654v-4.17a6 6 0 0 1 6 -6h.585l-1.292 -1.293a1 1 0 0 1 -.083 -1.32l.083 -.094a1 1 0 0 1 1.414 0");
		builder.CloseElement();
		builder.CloseElement();
    }
}
