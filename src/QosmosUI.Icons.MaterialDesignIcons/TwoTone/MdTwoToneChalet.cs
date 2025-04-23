// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneChalet : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "polygon");
		builder.AddAttribute(18, "opacity", ".3");
		builder.AddAttribute(19, "points", "13,18 11,18 11,15 9,15 9,18 7,18 7,13.33 10,10.33 13,13.33");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M17.5,15L10,7.5L2.5,15l1.41,1.41L5,15.33V20h10v-4.67l1.09,1.09L17.5,15z M13,18h-2v-3H9v3H7v-4.67l3-3l3,3V18z M22,7.5 h-1.19l0.75,0.75l-0.71,0.71L19.39,7.5H18.5v0.89l1.45,1.45l-0.71,0.71L18.5,9.81V11h-1V9.81l-0.75,0.75l-0.71-0.71l1.45-1.45V7.5 h-0.89l-1.45,1.45l-0.71-0.71l0.75-0.75H14v-1h1.19l-0.75-0.75l0.71-0.71l1.45,1.45h0.89V5.61l-1.45-1.45l0.71-0.71l0.75,0.75V3h1 v1.19l0.75-0.75l0.71,0.71L18.5,5.61V6.5h0.89l1.45-1.45l0.71,0.71L20.81,6.5H22V7.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
