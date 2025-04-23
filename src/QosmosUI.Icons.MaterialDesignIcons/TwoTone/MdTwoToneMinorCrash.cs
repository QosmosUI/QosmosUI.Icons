// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneMinorCrash : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M5,15v5h14v-5H5z M7.5,19C6.67,19,6,18.33,6,17.5S6.67,16,7.5,16S9,16.67,9,17.5S8.33,19,7.5,19z M16.5,19 c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5S17.33,19,16.5,19z");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M9.41,5L8,6.41l-3-3L6.41,2L9.41,5z M19,3.41L17.59,2l-3,3L16,6.41L19,3.41z M13,0h-2v5h2V0z M21,15v8c0,0.55-0.45,1-1,1 h-1c-0.55,0-1-0.45-1-1v-1H6v1c0,0.55-0.45,1-1,1H4c-0.55,0-1-0.45-1-1v-8l2.08-5.99C5.29,8.42,5.84,8,6.5,8h11 c0.66,0,1.22,0.42,1.42,1.01L21,15z M5.81,13h12.38l-1.04-3H6.85L5.81,13z M19,15H5v5h14V15z M7.5,19C8.33,19,9,18.33,9,17.5 S8.33,16,7.5,16S6,16.67,6,17.5S6.67,19,7.5,19z M16.5,19c0.83,0,1.5-0.67,1.5-1.5S17.33,16,16.5,16S15,16.67,15,17.5 S15.67,19,16.5,19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
