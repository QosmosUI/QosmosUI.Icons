// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneTty : ComponentBase
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
		builder.AddAttribute(18, "x", "0");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M4.13,5C4.3,6.37,4.66,7.71,5.18,8.99l1.65-1.65L6.36,5H4.13z M15.66,16.17l-1.65,1.65 c1.28,0.52,2.63,0.87,3.99,1.05v-2.23L15.66,16.17z");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M19.2,14.84l-3.67-0.73c-0.33-0.07-0.67,0.04-0.9,0.27L12.1,16.9c-2.5-1.43-4.57-3.5-6-6l2.52-2.52 C8.86,8.14,8.96,7.8,8.9,7.48L8.16,3.8C8.07,3.34,7.66,3,7.18,3H3.03C2.47,3,2,3.47,2.03,4.03C2.2,6.92,3.05,9.63,4.43,12 c1.58,2.73,3.85,4.99,6.57,6.57c2.37,1.37,5.08,2.23,7.97,2.4c0.56,0.03,1.03-0.44,1.03-1v-4.15C20,15.34,19.66,14.93,19.2,14.84z M4.13,5h2.23l0.47,2.34L5.18,8.99C4.66,7.71,4.3,6.37,4.13,5z M18,18.87c-1.37-0.17-2.71-0.53-3.99-1.05l1.65-1.65L18,16.64V18.87 z M14,4h2v2h-2V4z M13,7h2v2h-2V7z M11,4h2v2h-2V4z M18,9h-2V7h2V9z M19,6h-2V4h2V6z M21,9h-2V7h2V9z M22,6h-2V4h2V6z M14,10h2v2 h-2V10z M11,10h2v2h-2V10z M19,12h-2v-2h2V12z M22,12h-2v-2h2V12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
