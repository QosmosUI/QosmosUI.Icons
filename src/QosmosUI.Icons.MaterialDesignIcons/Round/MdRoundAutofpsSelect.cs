// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAutofpsSelect : ComponentBase
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
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "polygon");
		builder.AddAttribute(21, "points", "12.03,6.3 11.97,6.3 10.95,9.19 13.05,9.19");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M4,22L4,22c0.55,0,1-0.45,1-1v-3c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v3C3,21.55,3.45,22,4,22z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12,15c3.31,0,6-2.69,6-6s-2.69-6-6-6S6,5.69,6,9S8.69,15,12,15z M12,5L12,5c0.38,0,0.71,0.23,0.85,0.59l2.12,5.65 c0.14,0.37-0.13,0.76-0.53,0.76h0c-0.24,0-0.45-0.15-0.53-0.38l-0.49-1.41h-2.83l-0.5,1.41C10.01,11.85,9.8,12,9.56,12h0 c-0.39,0-0.67-0.39-0.53-0.76l2.12-5.65C11.29,5.23,11.62,5,12,5z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M8,22L8,22c0.55,0,1-0.45,1-1v-3c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v3C7,21.55,7.45,22,8,22z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M12,22L12,22c0.55,0,1-0.45,1-1v-3c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v3C11,21.55,11.45,22,12,22z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M15,18v3c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1v-3c0-0.55-0.45-1-1-1h-4C15.45,17,15,17.45,15,18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
