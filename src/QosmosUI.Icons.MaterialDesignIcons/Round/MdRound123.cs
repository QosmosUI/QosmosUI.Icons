// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRound123 : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M4.75,10.5C4.34,10.5,4,10.16,4,9.75S4.34,9,4.75,9H6c0.55,0,1,0.45,1,1v4.25C7,14.66,6.66,15,6.25,15S5.5,14.66,5.5,14.25 V10.5H4.75z M9.75,9C9.34,9,9,9.34,9,9.75s0.34,0.75,0.75,0.75H12v1h-2c-0.55,0-1,0.45-1,1V14c0,0.55,0.45,1,1,1h2.75 c0.41,0,0.75-0.34,0.75-0.75c0-0.41-0.34-0.75-0.75-0.75H10.5v-1h2c0.55,0,1-0.45,1-1V10c0-0.55-0.45-1-1-1H9.75z M18.5,15 c0.55,0,1-0.45,1-1v-4c0-0.55-0.45-1-1-1h-2.75C15.34,9,15,9.34,15,9.75s0.34,0.75,0.75,0.75H18v1h-1.5c-0.28,0-0.5,0.22-0.5,0.5 s0.22,0.5,0.5,0.5H18v1h-2.25c-0.41,0-0.75,0.34-0.75,0.75S15.34,15,15.75,15H18.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
